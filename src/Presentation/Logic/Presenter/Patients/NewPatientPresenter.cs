using CIS.Application.BusinessComponents;
using CIS.Application.Façade;
using CIS.Presentation.Model.Common;
using CIS.Presentation.Model.Patients;
using CIS.Presentation.UI.Contracts.Patients;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Patients
{
    public class NewPatientPresenter : IDisposable
    {
        private INewPatientView _view;
        private PatientBusinessLogic _logic;
        private TitleBusinessLogic _titleLogic;
        private GenreBusinessLogic _genreLogic;
        private MaritalStatusBusinessLogic _maritalStatusLogic;

        private ChannelFactory<IApplicationFaçade> _facade;

        public NewPatientPresenter(INewPatientView view)
        {
            _view = view;
            _logic = new PatientBusinessLogic();
            // _titleLogic = new TitleBusinessLogic();
            // _genreLogic = new GenreBusinessLogic();
            _maritalStatusLogic = new MaritalStatusBusinessLogic();

            _facade = new ChannelFactory<IApplicationFaçade>("ApplicationEndPoint");
        }

        public void Save()
        {
            NewPatientViewModel data = _view.GetFormData();
            _logic.AddPatient(data);
        }

        public void LoadTitles()
        {
            using (var proxy = _facade.CreateChannel())
            {
                IEnumerable<ComboTitleViewModel> titles = proxy.Title.GetTitles();
                _view.LoadTitles(titles);
            }
        }

        public void LoadGenres()
        {
            using(var proxy = _facade.CreateChannel())
            {
                IEnumerable<ComboGenreViewModel> genres = proxy.Genre.GetGenres();
                _view.LoadGenres(genres);
            }
        }

        public void LoadMaritalStatuses()
        {
            IEnumerable<ComboMaritalStatusViewModel> maritalStatuses = _maritalStatusLogic.GetMaritalStatuses();
            _view.LoadMaritalStatuses(maritalStatuses);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _logic.Dispose();
                _logic = null;
                _titleLogic.Dispose();
                _titleLogic = null;
                _genreLogic.Dispose();
                _genreLogic = null;
                _maritalStatusLogic.Dispose();
                _maritalStatusLogic = null;
            }
        }
    }
}
