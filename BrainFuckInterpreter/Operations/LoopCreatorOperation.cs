using System.Collections.Generic;
using System.Linq;

namespace BrainFuckInterpreter.Operations
{
	class LoopCreatorOperation : IBrainFuckOperation
	{
		public LoopCreatorOperation(Pointer pointer, SignBus signBus)
		{
			this.pointer = pointer;
			this.signBus = signBus;
			currentLoop = null;
		}
		public string HandleSign(char sign)
		{
			if (sign == '[')
			{
				var newLoop = new Loop();

				if (currentLoop != null)
					currentLoop.AddLoop(newLoop);
				else
					signBus.HandleJustOneOperation(this);

				currentLoop = newLoop;
				loops.Push(currentLoop);
			}
			if(sign == ']')
			{
				if (loops.Count == 1)
				{
					signBus.HandleAllRegisteredOperationExpect(this);
					currentLoop.Execute(signBus, pointer);
					loops.Pop();
					currentLoop = null;
					signBus.RevertRegisteredOperations();
				}
				else
				{
					loops.Pop();
					currentLoop = loops.Peek();
				}
			}
			if(loops.Any() && operationSignExpectLooping.Contains(sign))
			{
				currentLoop.AddOperation(sign);
			}

			return loops.Any()
				? string.Format("creating loop: '{0}'", new string('[', loops.Count))
				: string.Empty;
		}

		private IList<char> operationSignExpectLooping = new[] { '+', '-', '>', '<', '.', ',' };
		private readonly Stack<Loop> loops = new Stack<Loop>();
		private Loop currentLoop;
		private Pointer pointer;
		private SignBus signBus;

		class Loop
		{
			public void AddLoop(Loop loop)
			{
				var loopKey = string.Format("#{0}", Inners.Count);
				Inners.Add(loopKey, loop);
				Operations.Add(loopKey);
			}

			public void AddOperation(char operation)
			{
				Operations.Add(new string(new[] { operation }));
			}

			internal void Execute(SignBus signBus, Pointer pointer)
			{
				while (pointer.PointedValue != 0)
				{
					foreach (var operation in Operations)
					{
						if (operation.StartsWith("#"))
							Inners[operation].Execute(signBus, pointer);
						else
							signBus.Send(operation[0]);
					}
				}
			}

			private readonly Dictionary<string, Loop> Inners = new Dictionary<string, Loop>();
			private readonly IList<string> Operations = new List<string>();
		}
	}
}
