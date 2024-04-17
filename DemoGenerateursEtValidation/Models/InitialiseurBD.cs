namespace DemoGenerateursEtValidation.Models
{
    public static class InitialiseurBD
    {
        public static List<Auto> _MesAutos = new List<Auto> {
            new Auto("Toyota", "Corolla", 25000),
            new Auto("Honda", "Civic", 45000),
            new Auto("Ford", "Focus", 29000),
            new Auto("Audi", "Q5", 75000),
            new Auto("Chevrolet", "Cruze", 26000),
            new Auto("Volkswagen", "Golf", 32000),
            new Auto("BMW", "3 Series", 42000),
            new Auto("Mercedes-Benz", "C-Class", 51000),
            new Auto("Nissan", "Sentra", 23000),
            new Auto("Hyundai", "Elantra", 22000),
            new Auto("Kia", "Forte", 21000),
            new Auto("Subaru", "Impreza", 27000),
            new Auto("Mazda", "3", 28000),
            new Auto("Jeep", "Wrangler", 35000),
            new Auto("Toyota", "Camry", 33000),
            new Auto("Honda", "Accord", 34000),
            new Auto("Ford", "Fusion", 32000),
            new Auto("Audi", "A4", 45000),
            new Auto("Chevrolet", "Malibu", 28000),
            new Auto("Volkswagen", "Jetta", 26000),
            new Auto("BMW", "5 Series", 55000),
            new Auto("Mercedes-Benz", "E-Class", 60000),
            new Auto("Nissan", "Altima", 29000),
            new Auto("Hyundai", "Sonata", 26000),
            new Auto("Kia", "Optima", 27000),
            new Auto("Subaru", "Legacy", 29000),
            new Auto("Mazda", "6", 31000),
            new Auto("Jeep", "Grand Cherokee", 40000),
            new Auto("Toyota", "RAV4", 35000),
            new Auto("Honda", "CR-V", 36000),
            new Auto("Ford", "Escape", 33000),
            new Auto("Audi", "Q7", 67000),
            new Auto("Chevrolet", "Equinox", 32000),
            new Auto("Volkswagen", "Tiguan", 31000),
            new Auto("BMW", "X3", 48000),
            new Auto("Mercedes-Benz", "GLC-Class", 52000),
            new Auto("Nissan", "Rogue", 31000),
            new Auto("Hyundai", "Tucson", 28000),
            new Auto("Kia", "Sportage", 29000),
            new Auto("Subaru", "Forester", 33000),
            new Auto("Mazda", "CX-5", 34000),
            new Auto("Jeep", "Cherokee", 36000),
            new Auto("Toyota", "Highlander", 40000),
            new Auto("Honda", "Pilot", 42000),
            new Auto("Ford", "Explorer", 40000),
            new Auto("Audi", "A6", 57000),
            new Auto("Chevrolet", "Traverse", 37000),
            new Auto("Volkswagen", "Atlas", 35000),
            new Auto("BMW", "X5", 60000),
            new Auto("Mercedes-Benz", "GLE-Class", 65000),
            new Auto("Nissan", "Pathfinder", 38000),
            new Auto("Hyundai", "Santa Fe", 34000),
            new Auto("Kia", "Sorento", 35000),
            new Auto("Subaru", "Outback", 37000),
            new Auto("Mazda", "CX-9", 38000),
            new Auto("Jeep", "Renegade", 29000),
            new Auto("Toyota", "4Runner", 45000),
            new Auto("Honda", "Odyssey", 42000),
            new Auto("Ford", "Expedition", 55000),
            new Auto("Audi", "Q8", 80000),
            new Auto("Chevrolet", "Tahoe", 52000),
            new Auto("Volkswagen", "Passat", 30000),
            new Auto("BMW", "X7", 75000),
            new Auto("Mercedes-Benz", "GLS-Class", 70000),
            new Auto("Nissan", "Armada", 53000),
            new Auto("Hyundai", "Palisade", 42000),
            new Auto("Kia", "Telluride", 43000),
            new Auto("Subaru", "Ascent", 40000),
            new Auto("Mazda", "CX-30", 28000),
            new Auto("Jeep", "Compass", 29000),
            new Auto("Toyota", "Sienna", 40000),
            new Auto("Honda", "Ridgeline", 42000),
            new Auto("Ford", "Ranger", 35000),
            new Auto("Audi", "A8", 90000),
            new Auto("Chevrolet", "Colorado", 28000),
            new Auto("Volkswagen", "Arteon", 38000),
            new Auto("BMW", "4 Series", 48000),
            new Auto("Mercedes-Benz", "S-Class", 95000),
            new Auto("Nissan", "Frontier", 31000),
            new Auto("Hyundai", "Kona", 25000),
            new Auto("Kia", "Niro", 28000),
            new Auto("Subaru", "Crosstrek", 27000),
            new Auto("Mazda", "MX-5 Miata", 32000),
            new Auto("Jeep", "Gladiator", 35000),
            new Auto("Toyota", "Tacoma", 32000),
            new Auto("Honda", "Fit", 18000),
            new Auto("Ford", "F-150", 45000),
            new Auto("Audi", "S4", 59000),
            new Auto("Chevrolet", "Silverado", 40000),
            new Auto("Volkswagen", "ID.4", 42000),
            new Auto("BMW", "M3", 67000),
            new Auto("Mercedes-Benz", "AMG GT", 150000),
            new Auto("Nissan", "Titan", 45000),
            new Auto("Hyundai", "Veloster", 22000),
            new Auto("Kia", "Stinger", 40000),
            new Auto("Subaru", "BRZ", 30000),
            new Auto("Mazda", "CX-3", 26000),
            new Auto("Jeep", "Trackhawk", 90000),
            new Auto("Toyota", "Supra", 55000),
            new Auto("Honda", "Insight", 28000)
        };


        /// <summary>
        /// Méthode appelée pour ajouter les données initiales aux tables Gateaux et Ingredients.
        /// </summary>
        /// <param name="applicationBuilder">Utilisé pour avoir le DbContext.</param>
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            // On ne peut pas utiliser l'injection de dépendances ici, 
            // le DbContext CatalogueGateauxDbContext sera donc récupéré à partir de applicationBuilder.
            CatalogueAutoDbContext catalogueAutoDbContext = applicationBuilder.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<CatalogueAutoDbContext>();

            if (!catalogueAutoDbContext.Autos.Any())
            {
                catalogueAutoDbContext.Autos.AddRange(_MesAutos);
            }

            catalogueAutoDbContext.SaveChanges();
        }
    }
}
