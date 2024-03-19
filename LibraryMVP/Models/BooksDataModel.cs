using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVP.Models
{
	internal class BooksDataModel
	{
		public int Book_ID { get; set; }
		public string Book_Title { get; set; }
		public string Book_Author { get; set; }
		public int Book_PageNumber { get; set; }
		public string Book_Publisher { get; set; }
		public string Book_PublicationDate { get; set; }
		public string Book_Category { get; set; }
		public string Book_Language {  get; set; }
		public string Book_Country {  get; set; }
	}
}
