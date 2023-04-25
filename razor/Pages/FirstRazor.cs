using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor.Pages
{
    public class FirstRazor : PageModel
    {
        public string Title { set; get; } = "ĐÂY LÀ TRANG ĐẦU TIÊN";
        public string Welcome(string w)
        {
            return $"Chào mừng {w} đến với trang web của tôi";
        }
        public void OnGet()
        {
            Console.WriteLine("Phương thức Get");
            ViewData["myData"] = "Truy cập bằng phương thức Get";
        }
        public void OnGetXyz()
        {
            Console.WriteLine("Phương thức GetXyz");
            ViewData["myData"] = "Truy cập bằng phương thức GetXyz";
        }
    }
}
