
namespace CIS.Data.DataAccess.Repository
{
    class TitleRepository : ITitleRepository
    {
        private ClinicModel _context;

        public TitleRepository(ClinicModel context)
        {
            _context = context;
        }

        public int Add(Application.Entities.Title entity)
        {
            throw new System.NotImplementedException();
        }

        public void Modify(Application.Entities.Title entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Application.Entities.Title entity)
        {
            throw new System.NotImplementedException();
        }

        public Application.Entities.Title GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Application.Entities.Title> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
