﻿using EXCSLA.Shared.Core.ValueObjects.Common;
using System.Collections.Generic;

namespace EXCSLA.Shared.Core.Interfaces
{
    public interface IAlertService
    {
        void AddAlert(string message, AlertType alertType = AlertType.Info);
        IReadOnlyList<Alert> ShowAlerts();
    }
}
