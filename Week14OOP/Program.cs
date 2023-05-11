Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);
Dog neighboursDog = new Dog("Good girl");
Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dog name is {neighboursDog.Name}.");
myDog.Rename("BadBoy");
while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}

myDog.TailWag();


class Dog
{
    private string _name = "Koer"; 
    private int _levelOfHapiness = 0;

    //constructor
    public Dog(string name)
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"My dog has been renamed to {newName}");
    }
    public void Bark()
    {
        Console.WriteLine("Woof, woof!");
        _levelOfHapiness++;
    }
    public void TailWag()
    {
        Console.WriteLine("Wiggle wiggle");
    }
}

