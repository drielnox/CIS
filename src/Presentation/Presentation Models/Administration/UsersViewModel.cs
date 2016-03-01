using System.Collections.Generic;

namespace CIS.Presentation.Model.Administration
{
    public class UsersViewModel
    {
        public ICollection<UserViewModel> UserList { get; set; }

        public UsersViewModel()
        {
            UserList = new List<UserViewModel>();
        }
    }
}
