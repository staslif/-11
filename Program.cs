Cat koshka = new Cat("корм", "дом", "мила");
Dog sobaka = new Dog("кость", "будка", "шарик");
Horse loshad = new Horse("яблоко", "конюшня", "спирит");
koshka.sleep();
koshka.eat();
koshka.makeNoise();
sobaka.eat();
sobaka.makeNoise();
sobaka.sleep();
loshad.makeNoise();
loshad.eat();
loshad.sleep();
class Animal
{
    public string food;
    public string location;
    public Animal(string food, string location)
    {
        this.food = food;
        this.location = location;
    }
    public virtual void makeNoise()
    {
        Console.WriteLine("Животное издаёт звук");
    }
    public virtual void eat()
    {
        Console.WriteLine("Животное кушает");
    }
    public void sleep()
    {
        Console.WriteLine("Животное спит");
    }

}
class Cat : Animal
{
    public string name;
    public Cat(string food, string location, string name) : base(food, location) { this.name = name; }
    public override void eat()
    {
        Console.WriteLine("Кошка : жрет корм");
    }
    public override void makeNoise()
    {
        Console.WriteLine("Кошка : скребет диван");
    }
    public void sleep()
    {
        Console.WriteLine("Кошка : прекорнула");
    }
}
class Dog : Animal
{
    public string name;
    public Dog(string food, string location, string name) : base(food, location) { this.name = name; }
    public override void eat()
    {
        Console.WriteLine("Собака : грызет кость");
    }
    public override void makeNoise()
    {
        Console.WriteLine("Собака : Лает");
    }
    public void sleep()
    {
        Console.WriteLine("Собака : спит");
    }
}
class Horse : Animal
{
    public string name;
    public Horse(string food, string location, string name) : base(food, location) { this.name = name; }
    public override void eat()
    {
        Console.WriteLine("Лошадь : кушает яблоко");
    }
    public override void makeNoise()
    {
        Console.WriteLine("Лошадь : Ржёт");
    }
    public void sleep()
    {
        Console.WriteLine("Лошадь : ушла");
    }
}
