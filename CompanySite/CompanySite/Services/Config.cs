namespace CompanySite.Services
{
    public class Config
    {
        public static string ConnectionString { get; set; } = "Data Source=DESKTOP-4IV5752; Database=CompanySite; Persist Security Info=false; User ID='sa'; Password='admin'; MultipleActiveResultSets=True; Trusted_Connection=False;";
        public static string CompanyName { get; set; } = "My company";
        public static string CompanyPhone { get; set; } = "+38 (011) 111-11-11";
        public static string CompanyPhoneShort { get; set; } = "+380111111111";
        public static string CompanyEmail { get; set; } = "myCompany@company.com";
    }
}
