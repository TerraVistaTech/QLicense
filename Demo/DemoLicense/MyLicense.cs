using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using Licensing;

namespace DemoLicense
{
    public class MyLicense : LicenseEntity
    {
        [DisplayName("Enable Feature 01")]
        [Category("License Options")]        
        [XmlElement("EnableFeature01")]
        [ShowInLicenseInfo(true, "Enable Feature 01", ShowInLicenseInfoAttribute.FormatType.String)]
        public bool EnableFeature01 { get; set; }

        [DisplayName("Enable Feature 02")]
        [Category("License Options")]        
        [XmlElement("EnableFeature02")]
        [ShowInLicenseInfo(true, "Enable Feature 02", ShowInLicenseInfoAttribute.FormatType.String)]
        public bool EnableFeature02 { get; set; }


        [DisplayName("Enable Feature 03")]
        [Category("License Options")]
        [XmlElement("EnableFeature03")]
        [ShowInLicenseInfo(true, "Enable Feature 03", ShowInLicenseInfoAttribute.FormatType.List)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<int> EnableFeature03 { get; set; }

        [DisplayName("Enable Feature 04")]
        [Category("License Options")]
        [XmlElement("EnableFeature04")]
        [ShowInLicenseInfo(true, "Enable Feature 04", ShowInLicenseInfoAttribute.FormatType.List)]
        public List<int> EnableFeature04 { get; set; }

        public MyLicense()
        {
            //Initialize app name for the license
            AppName = "DemoWinFormApp";
            EnableFeature03 = new List<int>();
            EnableFeature04 = new List<int>();
        }

        public override LicenseStatus DoExtraValidation(string origValidationMsg, out string validationMsg)
        {
            var _licStatus = LicenseStatus.VALID;
            validationMsg = origValidationMsg;

            switch (Type)
            {
                case LicenseTypes.Single:
                    //For Single License, check whether UID is matched
                    if (UID != LicenseHandler.GenerateUID(AppName)) {
                        validationMsg = "The license is NOT for this copy!";
                        _licStatus = LicenseStatus.INVALID;                    
                    }
                    break;
                case LicenseTypes.Volume:
                    //No UID checking for Volume License
                    validationMsg = "Volume license";
                    break;
                default:
                    validationMsg = "Invalid license";
                    _licStatus= LicenseStatus.INVALID;
                    break;
            }

            return _licStatus;
        }
    }
}
