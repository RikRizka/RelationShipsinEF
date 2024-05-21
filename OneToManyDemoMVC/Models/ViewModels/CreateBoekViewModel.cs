using OneToManyDemo.Models;
using System.ComponentModel.DataAnnotations;

namespace OneToManyDemoMVC.Models.ViewModels
{
    public class CreateBoekViewModel
    {
            [Required(ErrorMessage = "Title Can't be empty")]
            public string Title { get; set; }
            public int AuteurId { get; set; }
            public List<Auteur>? Auteurs { get; set; }
       
    }
}
