using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProject_SibIntek.Models
{
    public class FileDetails
    {
        public string Name { get; set; }
        public string Path { get; set; }

    }

    public class FileView : Controller
    {
        public List<FileDetails> Files { get; set; }
             = new List<FileDetails>();
    }
}
