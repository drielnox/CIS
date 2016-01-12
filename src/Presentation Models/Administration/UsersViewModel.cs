using System.Collections.Generic;

namespace CIS.Presentation.Models.Administration
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
