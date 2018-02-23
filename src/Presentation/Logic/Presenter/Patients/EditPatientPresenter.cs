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
    public class EditPatientPresenter : Presenter<IEditPatientView>, IDisposable
    {
        private ChannelFactory<IPatientContract> _patientService;

        public EditPatientPresenter(IEditPatientView view) : base(view)
        {
            _patientService = new ChannelFactory<IPatientContract>("PatientEndPoint");
        }

        public void LoadPatient(EditPatientViewModel patient)
        {
            View.LoadPatient(patient);
        }

        public void LoadTitles()
        {
            IEnumerable<ComboTitleViewModel> titles;

            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    titles = proxy.GetTitles();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            View.LoadTitles(titles);
        }

        public void LoadGenders()
        {
            IEnumerable<ComboGenreViewModel> genders;

            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    genders = proxy.GetGenders();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            View.LoadGenders(genders);
        }

        public void LoadMaritalStatus()
        {
            IEnumerable<ComboMaritalStatusViewModel> maritalStatuses;

            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    maritalStatuses = proxy.GetMaritalStatuses();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            View.LoadMaritalStatuses(maritalStatuses);
        }

        public void LoadNationalIdentificationTypes()
        {
            IEnumerable<ComboNationalIdTypesViewModel> nationalIdTypes;

            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    nationalIdTypes = proxy.GetNationalIdTypes();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            View.LoadNationalIdTypes(nationalIdTypes);
        }

        public void LoadKinRelationships()
        {
            IEnumerable<ComboKinRelationshipViewModel> relatioships;

            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    relatioships = proxy.GetKinRelations();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            View.LoadKinRelationships(relatioships);
        }

        public void Save()
        {
            EditPatientViewModel patient = View.GetPatient();

            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    proxy.UpdatePatient(patient);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeletePatient()
        {
            int patientId = View.GetCurrentPatientId();

            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    proxy.DeletePatient(patientId);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void LoadReport()
        {
            EditPatientViewModel patient;

            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    patient = proxy.GetPatient();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            string report = patient.ToString();
            View.SetReport(report);
        }

        public void LoadClinics()
        {
            IEnumerable<ClinicListViewModel> clinicians;

            try
            {
                using (var proxy = _patientService.CreateChannel())
                {
                    clinicians = proxy.GetClinicians();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            View.LoadClinics(clinicians);
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
