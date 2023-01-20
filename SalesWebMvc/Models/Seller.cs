namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public Double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> SalesRecords { get; set; } = new List<SalesRecord>();

        public Seller(int id, string name, string email, DateTime date, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            Date = date;
            BaseSalary = baseSalary;
            Department = department;
        }

        public Seller()
        {
        }

        public void AddSale(SalesRecord sr) 
        {
            SalesRecords.Add(sr);
        }
        public void RemoveSale(SalesRecord sr)
        {
            SalesRecords.Remove(sr);
        }
        public double totalSales(DateTime initial, DateTime final)
        {
            return SalesRecords.Where(sr => sr.Date >= initial && sr.Date <=final).Sum(sr => sr.Amount);
        }
    }
}
