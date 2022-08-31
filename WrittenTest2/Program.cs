using System;

namespace WrittenTest2
{
    abstract class Animal
    {
        public int weight;
        public string name;

        public abstract void Show();
        
        public abstract void SetMe(int weight, string name);
        public Animal(int weight, string name)
        {
            Weight = weight;
            Name = name;
        }
        public abstract string Name
        {
            get;
            set;
        }

        public abstract int Weight
        {
            get;
            set;
        }

        public Animal() { }

    }

     class Lion : Animal
    {
        public override int Weight { get; set; }
        public override string Name { get; set; }

        public Lion() { }
        public Lion(int weight, string name) : base(weight, name)
        {
            Weight = weight;
            Name = name;
        }
        public override string ToString()
        {
            return "Name :" + Name + " Weight :" + Weight;
        }

        public override void SetMe(int weight, string name)
        {
           
            Weight = weight;
            Name = name;
        }

        public override void Show()
        {
            Name = "Lion";
            Weight = 300;
            Console.WriteLine(ToString());
        }

    }

    class Tiger : Animal
    {
        public override int Weight { get; set; }
        public override string Name { get; set; }
        public Tiger() { }
        public Tiger(int weight, string name) : base(weight, name)
        {
            Weight = weight;
            Name = name;
        }
        public override string ToString()
        {
            return "Name :" + Name + " Weight :" + Weight;
        }
        public override void SetMe(int weight, string name)
        {
            
            Weight = weight;
            Name = name;
        }

        public override void Show()
        {
            Name = "Tiger";
            Weight = 200;
            Console.WriteLine(ToString());
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Lion myLion = new Lion();
            Tiger myTiger = new Tiger();

            myLion.Show();
            myTiger.Show();

        }
    }
}


    
