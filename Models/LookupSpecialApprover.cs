namespace SQLiteAPI.Models
{
    public class LookupSpecialApprover
    {
        public int ID { get; set; }
        public int Seq { get; set; }
        public string ApprovalType { get; set; }
        public string ApproverComputingID { get; set; }
        public string ApproverFullName { get; set; }
        public string ApproverPhone { get; set; }
        public string ApproverEmail { get; set; }
        public string AlternateComputingID { get; set; }
        public bool ApproverIsValid { get; set; }
        public bool AlternateIsValid { get; set; }
    }
}
