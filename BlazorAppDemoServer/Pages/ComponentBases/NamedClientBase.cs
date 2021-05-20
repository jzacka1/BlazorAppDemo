using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAppDemoServer.Data;
using BlazorAppDemoServer.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorAppDemoServer.Pages.ComponentBases
{
	public class NamedClientBase : ComponentBase
	{
		public List<Todos> todos = new List<Todos>();

		private IJsonPlaceHolderClient _jsonPlaceHolderClient;

		protected override async Task OnInitializedAsync()
		{
			todos = await _jsonPlaceHolderClient.GetTodos();
		}
	}
}
