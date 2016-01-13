using CIS.Application.BusinessComponents;
using CIS.Presentation.Model.Administration;
using CIS.Presentation.UI.Contracts.Administration;

namespace CIS.Presentation.Logic.Presenter.Administration
{
    public class ViewUsersPresenter
    {
        private IViewUsersView _view;
        private UserBusinessLogic _logic;

        public ViewUsersPresenter(IViewUsersView view)
        {
            _view = view;
            _logic = new UserBusinessLogic();
        }

        public void AddUser()
        {
            var result = _view.ShowAddUserDialog();

            _view.RefreshUserList();
        }

        public void ChangeUserPassword()
        {
            var user = _view.GetSelectedUser();
            _view.ShowChangeUserPasswordDialog(user);
        }

        public void LoadUserList()
        {
            var users = _logic.GetUsers();
            _view.LoadUserList(users);
        }
    }
}
