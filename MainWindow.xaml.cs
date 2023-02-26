using System.Text;
using System.Windows;
using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;
using System.Linq;
using System.Threading.Tasks;

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
			crawlDataAsync();
		}
		private async Task crawlDataAsync()
		{
			HtmlWeb htmlWeb = new() { 
				AutoDetectEncoding= true,
				OverrideEncoding = Encoding.UTF8
			};
			var url = $"https://{cbWebsite.Text}/nha-dat-cho-thue";
			var doc = await htmlWeb.LoadFromWebAsync(url);
			var threadItems = doc.DocumentNode.QuerySelectorAll(".js__product-link-for-product-id").ToList();

		}
	}
}
