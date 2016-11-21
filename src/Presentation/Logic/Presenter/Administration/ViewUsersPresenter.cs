using CIS.Application.Service.Contract;
using CIS.Presentation.Model.Administration;
using CIS.Presentation.UI.Contracts.Administration;
using CIS.Transversal.SharedKernel.Patterns.MVP;
using System;
using System.ServiceModel;

namespace CIS.Presentation.Logic.Presenter.Administration
{
    public class ViewUsersPresenter : Presenter<IViewUsersView>
    {
        private ChannelFactory<IAdministrationContract> channel;

        public ViewUsersPresenter(IViewUsersView view) : base(view)
        {
            channel = new ChannelFactory<IAdministrationContract>("AdministrationEndPoint");
        }

        public void AddUser()
        {
            var result = View.ShowAddUserDialog();

            View.RefreshUserList();
        }

        public void ChangeUserPassword()
        {
            var user = View.GetSelectedUser();
            View.ShowChangeUserPasswordDialog(user);
        }

        public void LoadUserList()
        {
            UsersViewModel users;

            try
            {
                using (var proxy = channel.CreateChannel())
                {
                    users = proxy.GetUsers();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            View.LoadUserList(users);
        }
    }
}
