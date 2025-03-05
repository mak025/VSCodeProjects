using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TinderForPets.Model;
using System.Diagnostics;

namespace TinderForPets.Pages;

public class IndexModel : PageModel
{
    //public Animal Cat { set; get; }
    //public Animal Dog { set; get; }
    private Animal[] animals = new Animal[3];

    private readonly ILogger<IndexModel> _logger;

    public Animal[] Animals { get => animals; set => animals = value; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        //Dog = new Animal("Buster", "Møghund", "Dog.png");
        //Cat = new Animal("Findus", "Røvhullet", "Cat.png");
        animals[0] = new Animal("Buster", "Møghund", "Dog.png", "Male", "Rarebreed (fuckhead)");
        animals[1] = new Animal("Findus","Røvhullet", "Cat.png", "Female", "Dunno");
        animals[2] = new Animal("Barf", "Stinkeren", "Ferret.png", "Male", "No Clue...");
    }
}
