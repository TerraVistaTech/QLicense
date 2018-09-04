using System;
using System.ComponentModel;
using System.Reflection;

namespace Licensing
{
    public enum LicenseStatus
    {
        [Description("Unknown")]
        UNDEFINED = 0,
        [Description("This license is valid.")]
        VALID = 1,
        [Description("This license is invalid.")]
        INVALID = 2,
        [Description("This license is has been tampered with.")]
        CRACKED = 4,
        [Description("This license is has expired.")]
        TRIALEXPIRED = 5
    }

    public static class LicenseStatusDescription
    {
        public static string GetDescription(this LicenseStatus value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            DescriptionAttribute attribute
                    = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))
                        as DescriptionAttribute;
                
                return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
