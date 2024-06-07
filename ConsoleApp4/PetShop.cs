namespace ConsoleApp4
{
    public class PetShop
    {
        List<Cat> Cats {  get; set; }= new List<Cat>();
        List<Dog> Dog { get; set; } = new List<Dog>();

        public void addCat(Cat cat)
        {
            Cats.Add(cat);
        }

        public void addDog(Dog dog)
        {
            Dog.Add(dog);
        }

        public void RemoveByNickName(string nickname)
        {
            Cats.RemoveAll(c => c.Nickname == nickname);
            Dog.RemoveAll(d => d.Nickname == nickname);
           
        }

        public int TotalMealQuantity()
        {
            int total = 0;
            total += Cats.Sum(c => c.MealQuantity);
            total += Dog.Sum(d => d.MealQuantity);
       
            return total;
        }

        public decimal TotalCatPrice()
        {
            return Cats.Sum(c => c.Price);
        }
    }
}
