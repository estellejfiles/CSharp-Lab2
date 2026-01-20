using System.ComponentModel;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaPartyCalculator.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    // attritubutes - properties of class that describe the object
    public int NumberOfGuests { get; set; }
    public int PizzasNeeded { get; set; }
    public double TotalCost { get; set; }
    public bool ShowResult { get; set; }

    // method that is called when the web page is displayed
    public void OnGet()
    {
        // hide the calculator's result
        ShowResult = false;

    } // end method

    // method called when web page is displayed in response to a post request
    public void OnPost ()
    {
        // declare variables
        int slicesPerGuest = 3;
        int slicesPerPizza = 8;
        double costPerPizza = 12.99;

        // calculate the total number of slices needed
        int totalSlicesNeeded = NumberOfGuests * slicesPerGuest;

        // calculate the number of pizzas requires (rounds up to int using Math.Ceiling)
        PizzasNeeded = (int)Math.Ceiling((double)totalSlicesNeeded / slicesPerPizza);

        // calculate the total cost (store in TotalCost attribute)
        TotalCost = PizzasNeeded * costPerPizza;

        // set the show result attribute to true
        ShowResult = true;

    }

} // end class
