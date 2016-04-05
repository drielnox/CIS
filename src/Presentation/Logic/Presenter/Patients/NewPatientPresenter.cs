using CIS.Application.Service.Contract;
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

        private ChannelFactory<IPatientContract> _patientService;

        public NewPatientPresenter(INewPatientView view)
        {
            _view = view;

            _patientService = new ChannelFactory<IPatientContract>("PatientEndPoint");
        }

        public void Save()
        {
            NewPatientViewModel data = _view.GetFormData();

            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    proxy.AddPatient(data);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void LoadTitles()
        {
            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    IEnumerable<ComboTitleViewModel> titles = proxy.GetTitles();
                    _view.LoadTitles(titles);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void LoadGenres()
        {
            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    IEnumerable<ComboGenreViewModel> genres = proxy.GetGenders();
                    _view.LoadGenres(genres);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void LoadMaritalStatuses()
        {
            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    IEnumerable<ComboMaritalStatusViewModel> maritalStatuses = proxy.GetMaritalStatuses();
                    _view.LoadMaritalStatuses(maritalStatuses);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
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
                _patientService.Close();
                _patientService = null;
            }
        }
    }
}
