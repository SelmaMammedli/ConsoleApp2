using ConsoleApp18.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.Models
{
    internal class Medicine
    {
        private int _medicineID;
        public int MedicineID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Count { get; set; }
        public Medicine( string name, int cost, int count)
        {
            _medicineID++;

            _medicineID = MedicineID;
            Name = name;
            Cost = cost;
            Count = count;
        }
        public Medicine(string input)
        {
            
        }
        public void Create()
        {
            Console.WriteLine("Derman adi daxil edin!");
            string input = Console.ReadLine();
            Medicine medicine= new Medicine(input);
            Context.Medicines.Add(medicine);


        }
        public void Delete()
        {
            Console.WriteLine("Derman yazin!");
            string input = Console.ReadLine();
            Medicine medicine = new Medicine(input);
            Context.Medicines.Remove(medicine);
        }

    }
}
