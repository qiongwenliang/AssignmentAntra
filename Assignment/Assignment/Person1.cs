//This is OOP Assignment
using System;
namespace Assignment
{
	public abstract class Person
	{
		private string name;
		private int age;
        public string game;

		public void getInfo()
		{
			Console.WriteLine("Please enter your name: ");
			name = (string)Console.ReadLine();
			Console.WriteLine("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"{name}, thank for providing your information :)");
		}

        public void Read()
        {
            Console.WriteLine($"{name} can read");
        }

        public void Write()
        {
            Console.WriteLine($"{name} can write");
        }

        public virtual void Work()
        {
            Console.WriteLine("How many days do you work a week?");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"I see, you work {days} days a week.");
        }

        public abstract void Behavior();
        //Abstraction
	}




	public class Student : Person
	{
        public override void Behavior()
        {
			Console.WriteLine("I study");
        }

        public bool Play()
        {
            Console.WriteLine("How many games do you play?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"I see, you play {n} games");

            Console.WriteLine($"Do you play {game}?");
            Console.WriteLine("Please answer 1 for Yes and 2 for No.");
            int ans = Convert.ToInt32(Console.ReadLine());

            bool res = false;
            if (ans == 1)
            {
                res = true;
            }
            else res = false;

            if (res)
            {
                Console.WriteLine($"I see, you play {game}");
            }
            else
            {
                Console.WriteLine($"{game} is fun, you can try :)");
            }

            return res;
        }

    }



	public class Instructor : Person
	{
        public override void Behavior()
        {
            Console.WriteLine("I teach");
        }

        public override void Work()
        {
            base.Work();

            Console.WriteLine("Where do you work?");
            string answer = Console.ReadLine();
            Console.WriteLine($"I see, you work at {answer}.");
        }
    }
}

