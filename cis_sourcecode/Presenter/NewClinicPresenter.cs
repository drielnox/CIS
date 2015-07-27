﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Presentation.Logic.Presenter
{
    public class NewClinicPresenter
    {
        private INewClinicView _view;

        public NewClinicPresenter(INewClinicView view)
        {
            this._view = view;
        }
    }

    public interface INewClinicView
    {
        void Initialize();
        void Save();
    }
}
