using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Administration;
using CIS.Presentation.UI.Contracts.Administration;
using CIS.Transversal.SharedKernel.Patterns.MVP;
using System;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Administration
{
    public class NewUserPresenter : Presenter<INewUserView>
    {
        private ChannelFactory<IAdministrationContract> channel;

        public NewUserPresenter(INewUserView view) : base(view)
        {
            channel = new ChannelFactory<IAdministrationContract>("AdministrationEndPoint");
        }

        public void SaveUser()
        {
            NewUserViewModel data = View.GetUserData();

            try
            {
                using (var proxy = channel.CreateChannel())
                {
                    proxy.Save(data);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
