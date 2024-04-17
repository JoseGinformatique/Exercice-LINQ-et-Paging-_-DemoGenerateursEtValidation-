using System.ComponentModel.DataAnnotations;

namespace DemoGenerateursEtValidation.Models
{
    public class Auto
    {

        public int Id { get; set; }

        [Required]
        public string Marque { get; set; }

        [Display (Name = "Modèle")] //Modifier l'affichage des label
        [Required]
        public string Model { get; set; }

        [Required (ErrorMessage = "Le prix est obligatoire")] //Validation avec messages d'erreurs
        [Range (0, 200000, ErrorMessage = "Le pris doit être entre 0 et 200 000$")]
        [DisplayFormat(DataFormatString = "{0:C2}")] //Choisir le format d'affichage
        public double? Prix { get; set; }

        public Auto() { }

        public Auto(string marque, string model, double prix)
        {
            Marque = marque;
            Model = model;
            Prix = prix;
        }
    }
}
