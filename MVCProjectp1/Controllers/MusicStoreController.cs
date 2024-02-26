using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace MVCProjectp1.Controllers
{
    public class MusicStoreController : Controller
    {

       
        public IActionResult Index()
        {
            return View();
        }
      
        public string Welcome()
        {
            return "Hello this is message for action";

        }
        [ActionName("ShowMusicApp")]
        public string ShowMusic(string MusicTitle)
        {
            return "You Selected" + MusicTitle + "Music";
        }

        /* [HttpPost]*/

        
        public ActionResult PostMusic()
        {
            return  View();
        }
    }
}
