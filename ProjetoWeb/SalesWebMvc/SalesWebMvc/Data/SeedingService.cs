using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;
        
        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecords.Any())
            {
                return; // db ja foi populado
            }
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1984, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "John Brown", "hohn@gmail.com", new DateTime(1974, 4, 21), 1050.0, d2);
            Seller s3 = new Seller(3, "Ted Brown", "Ted@gmail.com", new DateTime(1964, 4, 21), 6000.0, d1);
            Seller s4 = new Seller(4, "Mary Brown", "mary@gmail.com", new DateTime(1984, 4, 21), 4000.0, d4);
            Seller s5 = new Seller(5, "Paul Brown", "paul@gmail.com", new DateTime(1987, 4, 21), 2000.0, d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(1998, 4, 21), 11000.00, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2000, 4, 21), 1000.00, SalesStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(1999, 4, 21), 5000.00, SalesStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2002, 4, 21), 11000.00, SalesStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(1998, 4, 21), 300.00, SalesStatus.Billed, s5);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5);

            _context.SalesRecords.AddRange(r1, r2, r3, r4, r5);

            _context.SaveChanges();
        }
    }
}
