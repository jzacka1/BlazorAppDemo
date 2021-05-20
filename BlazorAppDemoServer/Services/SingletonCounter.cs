using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppDemoServer
{
	public interface ISingletonCounter{

	}

	public class SingletonCounter: ISingletonCounter
	{
		public int MyCounterValue { get; set; }

		public void IncrementCount()
		{
			MyCounterValue++;
		}
	}
}
