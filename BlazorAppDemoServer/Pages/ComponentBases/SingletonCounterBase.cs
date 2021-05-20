using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorAppDemoServer.Pages.ComponentBases
{
	public class SingletonCounterBase : ComponentBase
	{
		[Inject] 
		private ISingletonCounter _singletonCounter { get; set; }

		public SingletonCounterBase(ISingletonCounter singletonCounter)
		{
			_singletonCounter = singletonCounter;
		}

		protected override async Task OnInitializedAsync()
		{

		}

	}
}
