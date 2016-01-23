
namespace CIS.Data.DataAccess.Repository
{
    public class MaritalStatusRepository : IMaritalStatusRepository
    {
        private ClinicModel _context;

        public MaritalStatusRepository(ClinicModel context)
        {
            _context = context;
        }

        public int Add(Application.Entities.MaritalStatus entity)
        {
            throw new System.NotImplementedException();
        }

        public void Modify(Application.Entities.MaritalStatus entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Application.Entities.MaritalStatus entity)
        {
            throw new System.NotImplementedException();
        }

        public Application.Entities.MaritalStatus GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Application.Entities.MaritalStatus> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
