using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Shared.ViewModel.Blog
{
    public class BlogsDto
    {
        public string uuid { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string image { set; get; }
        public string slug { get; set; }
        public string author { get; set; }
        public string categoryId { get; set; }
        public string categoryName { get; set; }
        public DateTime createDate{ get; set; }
        public bool? status { get; set; }
    }
}
