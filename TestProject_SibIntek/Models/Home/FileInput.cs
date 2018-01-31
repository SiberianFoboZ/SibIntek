using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProject_SibIntek.Models
{
    public class FileInput : Controller
    {
        public IFormFile FileToUpload { get; set; }
    }
}
