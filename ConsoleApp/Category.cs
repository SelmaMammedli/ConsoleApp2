using ConsoleApp18.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.Models
{
    internal class Category
    {
        private int _categoryID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        

        public Category( string name)
        {
            _categoryID++;
            _categoryID = CategoryID;
            Name = name;
            
        }
        public void Create()
        {
            Console.WriteLine("Kateqorya adi daxil edin!");
            string input = Console.ReadLine();
            Category category = new Category(input);
            Context.Categories.Add(category);


        }
        public void Delete()
        {
            Console.WriteLine("Kateqorya daxil edin");
            string input = Console.ReadLine();
            Category category = new Category(input);
            Context.Categories.Remove(category);

        }
        public void Update()
        {

        }



        
    }
}
