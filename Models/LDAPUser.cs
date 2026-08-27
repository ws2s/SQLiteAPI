namespace SQLiteAPI.Models
{
    public class LDAPUser
    {
        public int LDAPUserID { get; set; } = 0;
        public string ComputingID { get; set; } = string.Empty;
        public string ContactName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;

    }
}