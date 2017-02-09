using Nancy;
using System.Collections.Generic;
using Tamagotchi.Objects;

namespace Tamagotchi
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/tamagotch_added.cshtml"] = _ => {
        Tamagotchi newTamagotchi = new Tamagotchi(Request.Form["new-tamagotchi"] );
        newTamagotchi.Save();
        
      }
    }
  }
}
