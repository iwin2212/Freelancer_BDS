using System.Text;
using System.Windows;
using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;
using System.Linq;

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
			crawlData();
		}
		private void crawlData()
		{
			HtmlWeb htmlWeb = new() { 
				AutoDetectEncoding= true,
				OverrideEncoding = Encoding.UTF8
			};
			HtmlDocument doc = htmlWeb.Load("https://"+cbWebsite.Text+ "/nha-dat-cho-thue");
			var threadItems = doc.DocumentNode.QuerySelectorAll(".js__product-link-for-product-id").ToList();

		}
	}
}
