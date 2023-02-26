using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using Extentions;
using HtmlAgilityPack;

namespace BDS
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Index();
		}
		private static async Task<string> CallUrl(string url)
		{
			try
			{
				HttpClient client = new();
				var response = await client.GetStringAsync(url);
				return response;
			}
			catch (Exception ex){
				Logger.Error(ex.Message);
				return null;
			}
		}
		public string Index()
		{
			//string url = "https://"+cbWebsite.Text;
			string url = "https://en.wikipedia.org/wiki/List_of_programmers";
			var response = CallUrl(url).Result;
			return response;
		}
		private void ParseHtml(string html)
		{
			HtmlDocument htmlDoc = new HtmlDocument();
			htmlDoc.LoadHtml(html);

			var programmerLinks = htmlDoc.DocumentNode.Descendants("li")
				.Where(node => !node.GetAttributeValue("class", "").Contains("tocsection"))
				.ToList();

		}
	}
}
