using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    public class Dog : Animal
    {
        public Dog(string nickname, int age, string gender, int energy, decimal price, int mealQuantity)
            : base(nickname, age, gender, energy, price, mealQuantity) { }

        public override void Eat()
        {
            MealQuantity++;
            Energy += 20;
            Age++;
            Price += 20;
        }

        public override void Sleep()
        {
            Energy = 120;
        }

        public override void Play()
        {
            if (Energy > 0)
            {
                Energy -= 20;
                if (Energy <= 0)
                {
                    Sleep();
                }
            }
        }
    }

}
