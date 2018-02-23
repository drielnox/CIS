
using CIS.Presentation.UI.Contracts.Administration.Configuration.Gender;
using CIS.Transversal.SharedKernel.Patterns.MVP;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.Gender
{
    class NewGenderPresenter : Presenter<INewGenderView>
    {
        public NewGenderPresenter(INewGenderView view) : base(view)
        {
        }
    }
}
