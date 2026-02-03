/*
    Copyright © 2026 Angle-Tolib, All Rights Reserved.
 */

namespace Monolit.Infrastructure
{
    public class AppConfig
    {
        public TinyMCE TinyMCE { get; set; } = new TinyMCE();
        public Company Company { get; set; } = new Company();
    }
    public class TinyMCE
    {
        public string? APIKey { get; set; }
    }

    public class Company
    {
        public string? CompanyName { get; set; }
        public string? CompanyPhone { get; set; }
        public string? CompanyPhoneShort { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanySupportEmail { get; set; }
    }
}
