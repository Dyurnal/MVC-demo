using ASPDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDemo.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {

            
            return View();
        }
        public IActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Jomari", LastName = "Elardo", Age = 27, isAlive = true });
            people.Add(new PersonModel { FirstName = "Jandell", LastName = "Carrascal", Age = 25, isAlive = true });
            people.Add(new PersonModel { FirstName = "Hanphil", LastName = "Remoto", Age = 26, isAlive = true });
            people.Add(new PersonModel { FirstName = "Justine", LastName = "Neri", Age = 24, isAlive = true });
            people.Add(new PersonModel { FirstName = "Grace", LastName = "Ocampo", Age = 24, isAlive = true });
            return View(people);
        }
    }
}
