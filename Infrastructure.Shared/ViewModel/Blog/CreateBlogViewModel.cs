using Microsoft.AspNetCore.Http;

namespace Infrastructure.Shared.ViewModel.Blog
{
    public class CreateBlogViewModel
    {
        public string title { get; set; }
        public string content { get; set; }
        public IFormFile image { set; get; }
        public string slug { get; set; }
        public string author { get; set; }
        public string categoryId { get; set; }
    }
}
