using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Noun1 = "basketball";
      myLetterVariable.Noun2 = "spiders";
      myLetterVariable.Noun3 = "jellybeans";
      myLetterVariable.Noun4 = "sidecar";
      myLetterVariable.Name1 = "Mildred";
      myLetterVariable.Adjective1 = "swim";
      myLetterVariable.PastTenseAdjective = "poured";
      myLetterVariable.PastTenseAdjective2 = "danced";

      return View(myLetterVariable);
    }
  }
}