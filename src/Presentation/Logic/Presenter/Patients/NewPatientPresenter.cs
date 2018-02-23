using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Common;
using CIS.Presentation.Model.Patients;
using CIS.Presentation.UI.Contracts.Patients;
using CIS.Transversal.SharedKernel.Patterns.MVP;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Patients
{
    public class NewPatientPresenter : Presenter<INewPatientView>, IDisposable
    {
        private ChannelFactory<IPatientContract> _patientService;

        public NewPatientPresenter(INewPatientView view)
            : base(view)
        {
            _patientService = new ChannelFactory<IPatientContract>("PatientEndPoint");
        }

        public void Save()
        {
            NewPatientViewModel data = View.GetFormData();

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
                    View.LoadTitles(titles);
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
                    View.LoadGenres(genres);
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
                    View.LoadMaritalStatuses(maritalStatuses);
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
