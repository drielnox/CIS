﻿using CIS.Presentation.Model.Administration.MaritalStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Presentation.UI.Contracts.Administration.Configuration.MaritalStatus
{
    public interface IModifyMaritalStatusView
    {
        MaritalStatusViewModel GetCurrentMaritalStatus();

        void SetIdentifier(int p);

        void SetAbbreviation(string p);

        void SetDescription(string p);

        int GetIdentifier();

        string GetAbbreviation();

        string GetDescription();

        void EnableAcceptButton(bool enable);

        void SetTag(MaritalStatusViewModel model);
    }
}