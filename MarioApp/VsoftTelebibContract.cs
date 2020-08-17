namespace MarioApp
{
    class VsoftTelebibContract
    {
        public int Id { get; set; }
        public string Mij { get; set; }        
        public string MemoTb2 { get; set; }
        public string DocType { get; set; }
        public virtual VsoftContract VsoftContract { get; set; } // important for ON DELETE CASCADE when Customer is deleted
        public string VsoftContractId { get; internal set; } // Polis in MDV database TB2
    }
}
