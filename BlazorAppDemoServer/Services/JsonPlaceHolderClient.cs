using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorAppDemoServer.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorAppDemoServer.Services
{
	public interface IJsonPlaceHolderClient
	{
		Task<List<Todos>> GetTodos();
	}

	public class JsonPlaceHolderClient : IJsonPlaceHolderClient
	{
		//[Inject] 
		//protected IJsonPlaceHolderClient jsnplchldr { get; set; }

		private HttpClient _httpClient;
		private static string _baseAddress = "https://jsonplaceholder.typicode.com/";

		public JsonPlaceHolderClient(HttpClient httpClient)
		{
			httpClient.BaseAddress = new Uri(_baseAddress);
			_httpClient = httpClient;
		}

		public async Task<List<Todos>> GetTodos()
		{
			return await _httpClient.GetFromJsonAsync<List<Todos>>("/todos");
		}
    }
}
