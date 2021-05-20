using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace BlazorAppDemoServer.Data
{
	public class DummyModel<T> where T : class
	{
		public string kind { get; set; }
		public string etag { get; set; }
		public IEnumerable<Item<T>> items { get; set; }
	}
	public class Item<T> : BloggerPosts where T : class
	{
		public string kind { get; set; }
		public string etag { get; set; }
		public string id { get; set; }
		public T snippet { get; set; }
	}

	public class BloggerPosts
	{
		public string title { get; set; }
		public string content { get; set; }
		public string url { get; set; }
		//public DateTime published { get; set; }
		//public DateTime updated { get; set; }
		//public BloggerAuthor author { get; set; }
	}
}
