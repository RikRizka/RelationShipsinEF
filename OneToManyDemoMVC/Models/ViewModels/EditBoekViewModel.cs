using Microsoft.EntityFrameworkCore;
using OneToManyDemo.Models;
using System.ComponentModel.DataAnnotations;

namespace OneToManyDemoMVC.Models.ViewModels
{
    [Keyless]
    public class EditBoekViewModel
    {
        public int BoekId { get; set; }
        [Required(ErrorMessage ="Title is verplicht")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Title is verplicht")]
        public int AuteurId { get; set; } // maak AuteurId nullabel
        public List<Auteur>? Auteurs { get; set; }
    }
}
