using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animal = new Animal[2];
            animal[0] = new Cat("Кошка");
            animal[1] = new Dog("Собака");
            for  (int i=0; i<2;i++)       
            {
                Console.WriteLine(animal[i].ShouInfo()+"");
                animal[i].Say();
            }
            Console.ReadKey();
            

            


        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public  Animal(string a)
            {
            Name=a;
          
            }
        public abstract void Say( );

       
        public string ShouInfo()
        {
            return Name;
        }
        
    }
    class Cat:Animal
    {
        string a;
        public Cat(string a) : base(a)
        {
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
              
        public override string Name
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

    }
    class Dog : Animal
    {
        string a;

        public Dog(string a) : base(a)
        {
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
        public override string Name
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
    }

}
