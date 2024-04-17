namespace DemoGenerateursEtValidation.Models
{
    public class DBAutoRep : IAutoRep
    {
        private CatalogueAutoDbContext _db;

        public DBAutoRep(CatalogueAutoDbContext catalogueAutoDbContext)
        {
            _db = catalogueAutoDbContext;
        }


        public IQueryable<Auto> MesAutoQuery => _db.Autos;
        public IEnumerable<Auto> MesAuto => _db.Autos.ToList();

        public void AddAuto(Auto auto)
        {
            _db.Autos.Add(auto);
        }

        public Auto GetAuto(int? id)
        {
            return _db.Autos.FirstOrDefault(auto => auto.Id == id);
        }

        void IAutoRep.SupprimerAuto(int id)
        {
            _db.Autos.Remove(GetAuto(id));
            _db.SaveChanges();
        }

        void IAutoRep.ModifierAuto(Auto auto)
        {
            _db.Autos.Remove(GetAuto(auto.Id));
            _db.Autos.Add(auto);
            _db.SaveChanges();
        }
    }
}
