
using CIS.Presentation.UI.Contracts.Administration.Configuration.Gender;
using CIS.Transversal.SharedKernel.Patterns.MVP;

namespace CIS.Presentation.Logic.Presenter.Administration.Configuration.Gender
{
    class ModifyGenderPresenter : Presenter<IModifyGenderView>
    {
        public ModifyGenderPresenter(IModifyGenderView view) : base(view)
        {
        }
    }
}
