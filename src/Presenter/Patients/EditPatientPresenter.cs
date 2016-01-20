using CIS.Application.BusinessComponents;
using CIS.Presentation.Model.Patients;
using CIS.Presentation.UI.Contracts.Patients;

namespace CIS.Presentation.Logic.Presenter.Patients
{
    public class EditPatientPresenter
    {
        private IEditPatientView _view;
        private TitleBusinessLogic _titleLogic;
        private GenreBusinessLogic _genrerLogic;
        private MaritalStatusBusinessLogic _maritalStatusLogic;
        private NationalIdentificationTypeBusinessLogic _nationalIdTypeLogic;
        private KinRelationshipBusinessLogic _kinRelationshipLogic;

        public EditPatientPresenter(IEditPatientView view)
        {
            _view = view;
            _titleLogic = new TitleBusinessLogic();
            _genrerLogic = new GenreBusinessLogic();
            _maritalStatusLogic = new MaritalStatusBusinessLogic();
            _nationalIdTypeLogic = new NationalIdentificationTypeBusinessLogic();
            _kinRelationshipLogic = new KinRelationshipBusinessLogic();
        }

        public void LoadPatient(EditPatientViewModel patient)
        {
            _view.LoadPatient(patient);
        }

        public void LoadTitles()
        {
            var titles = _titleLogic.GetTitles();
            _view.LoadTitles(titles);
        }

        public void LoadGenders()
        {
            var genrers = _genrerLogic.GetGenres();
            _view.LoadGenres(genrers);
        }

        public void LoadMaritalStatus()
        {
            var maritalStatuses = _maritalStatusLogic.GetMaritalStatuses();
            _view.LoadMaritalStatuses(maritalStatuses);
        }

        public void LoadNationalIdentificationTypes()
        {
            var nationalIdTypes = _nationalIdTypeLogic.GetNationalIdTypes();
            _view.LoadNationalIdTypes(nationalIdTypes);
        }

        public void LoadKinRelationships()
        {
            var relatioships = _kinRelationshipLogic.GetKinRelations();
            _view.LoadKinRelationships(relatioships);
        }
    }
}
