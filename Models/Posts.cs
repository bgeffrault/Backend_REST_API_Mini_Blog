using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_Blog_Backend.Models
{
    public class Post
    {
		/*title: string; 
		content: string;  
		loveIts: number;
		created_at: string;
		photo: string;
		photoCropped: string;*/

		public string Title { get; set; }

		public string Content { get; set; }

		public string LoveIts { get; set; }

		public string Created_at { get; set; }

		public string Photo { get; set; }

		public string PhotoCropped { get; set; }

		public string Id { get; set; }

		public string ConvertForSQL(String str)
		{
			str = str.Replace("'", "''");
			return str;
		}

		public string ConvertForReturn(String str)
		{
			str = str.Replace("''", "'");
			return str;
		}
	}
}
