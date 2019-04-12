using ca.HenrySoftware;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace NewTestChat.Pages
{
	public class IndexModel : PageModel
	{
		private Gename _gename = new Gename();
		[ViewData]
		public string Name => _gename.Name();
	}
}
