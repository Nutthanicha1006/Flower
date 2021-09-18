using System;

namespace Quizflower
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalRose, TotalSunflower;

            Console.Write("Input Total Rose : ");
            TotalRose = int.Parse(Console.ReadLine());
            Console.Write("Input Total Sun Flower : ");
            TotalSunflower = int.Parse(Console.ReadLine());

            
            Details Rose1 = new Details(1,"ดอกกุหลาบสีขาว","สวยงามมาก",2,"10.5","6");
            
            Details Sunflower1 = new Details(1, "ดอกทานตะวันเล็ก", "สวยงาม", 1, "2.0", "2.0");

            InputRose.Add(Rose1);
            InputSunflower.Add(Sunflower1);

            foreach ()
            {

            }

        }
    }

    class Rose : Details
    {
        public Rose (int id, string name, string description, int amount, string height, string circumference) : base(id, name, description, amount, height, circumference)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Circumference = circumference;
        }
        public void ReccordRose()

    }

    class Sunflower : Details
    {
        public Sunflower (int id, string name, string description, int amount, string height, string circumference) : base(id, name, description, amount, height, circumference)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Circumference = circumference;
        }

    }

    class Details
    {
        public int ID;
        public string Name;
        public string Description;
        public int Amount;
        public string Height;
        public string Circumference;

        public Details (int id, string name, string description, int amount, string height, string circumference)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Amount = amount;
            this.Height = height;
            this.Circumference = circumference;
        }
    }
}
