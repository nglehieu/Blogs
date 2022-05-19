using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Shared.ViewModel.Blog
{
    public class UpdateBlogViewModel
    {
        public string title { get; set; }
        public string content { get; set; }
        public string slug { get; set; }
        public string image { get; set; }
        public string author { get; set; }
        public string categoryId { get; set; }
    }
}
