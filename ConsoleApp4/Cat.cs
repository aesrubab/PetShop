using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    public class Cat : Animal
    {
        public Cat(string nickname, int age, string gender, int energy, decimal price, int mealQuantity)
            : base(nickname, age, gender, energy, price, mealQuantity) { }

        public override void Eat()
        {
            MealQuantity++;
            Energy += 10; 
            Age++;
            Price += 10; 
        }

        public override void Sleep()
        {
            Energy = 100; 
        }

        public override void Play()
        {
            if (Energy > 0)
            {
                Energy -= 10; 
                if (Energy <= 0)
                {
                    Sleep();
                    Console.WriteLine("slipppp");
                }
            }
        }
    }

}
