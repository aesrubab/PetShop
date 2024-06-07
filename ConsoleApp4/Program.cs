using ConsoleApp4;

class Program
{
    static void Main(string[] args)
    {
        PetShop shop = new PetShop();
        Cat cat1=new Cat("Mosi",2,"female",100,170,3);
        Dog dog1 = new Dog("Curry", 3, "male", 100, 100, 4);
        
        shop.addDog(dog1);
        shop.addCat(cat1);

        cat1.Play();
        cat1.Play();
        cat1.Play();
        cat1.Play();
        cat1.Play();
        cat1.Play();
        cat1.Play();
        cat1.Play();
        cat1.Play();
        cat1.Play();

    }
}
