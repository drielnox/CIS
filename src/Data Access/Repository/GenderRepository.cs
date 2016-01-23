
namespace CIS.Data.DataAccess.Repository
{
    public class GenderRepository : IGenderRepository
    {
        private ClinicModel _context;

        public GenderRepository(ClinicModel context)
        {
            _context = context;
        }

        public int Add(Application.Entities.Gender entity)
        {
            throw new System.NotImplementedException();
        }

        public void Modify(Application.Entities.Gender entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Application.Entities.Gender entity)
        {
            throw new System.NotImplementedException();
        }

        public Application.Entities.Gender GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Application.Entities.Gender> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
