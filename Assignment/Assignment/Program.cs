namespace Assignment;

class Program
{
    public static void Main()
    {
        Student betty = new Student();
        betty.getInfo();
        betty.Read();
        betty.Behavior();
        //Encapsulation


        betty.game = "Genshin";
        betty.Play();
        //Inheritance

        

        Instructor JeffBezo = new Instructor();
        JeffBezo.Work();
        //Polymorphism virtual methods

        Console.ReadLine();
    }
}
