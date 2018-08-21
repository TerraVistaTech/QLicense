using System;

namespace Licensing.GUI
{
    public class LicenseSettingsValidatingEventArgs:EventArgs
    {
        public LicenseEntity License { get; set; }
        public bool CancelGenerating { get; set; }
    }
}
