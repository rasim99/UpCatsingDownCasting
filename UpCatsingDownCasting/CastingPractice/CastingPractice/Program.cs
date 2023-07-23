using System;

namespace CastingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            #region upcasting,boxing,implict

            /* Shark shark =new Shark();
             // shark.Eat();
             shark.Swim();

             Eagle eagle = new Eagle();

             Animal shark1 = shark; //upcasting 
             //shark1.Eat();
             //Console.WriteLine(shark1.GetType());

                  /* Here, since the shark is upcasting,
                  it loses its characteristics and carries 
                  the class characteristics it inherited from itself */

            /* Bird bird = new Eagle();
             bird.Eat();
             bird.Fly();

             Animal bird1 = bird;

             Animal[] array = {shark,eagle};
             foreach( var item in array)
             {
                Console.WriteLine(item.ToString());
             } */

            #endregion

            #region downcasting,unboxing,explict
            Shark shark = new Shark();

            Eagle eagle = new Eagle();

            Animal animal = shark;
            Shark shark1 = (Shark)animal; //we have to check whether,
                                          //the animal is a shark or not;

            object[] obj = { shark, animal, eagle };

            /* There are two ways to do downcasting, 
             one is "is" - returns true/false, 
             the other is "as" - checks each item separately */

            //#region security way first
            /*foreach(var item in obj)
            {
               if(item is Shark)
               {
                  Shark shark2 = (Shark)item;
                  shark2.Swim();
               }
               else
               {
                  Console.WriteLine("did not return");
               }
            }*/
            #endregion

            #region security way two
            foreach (var item in obj)
            {
                Shark shark2 = item as Shark;
                if (shark2 != null)
                {
                    shark2.Swim();
                }
                else
                {
                    Console.WriteLine("did not return");
                }
            }
            #endregion
            #endregion
        }
    }

    #region upcasting, boxing, implict  /  downcasting,unboxing,expilict

    abstract class Animal
    {
        abstract public void Eat();
    }

    abstract class Fish : Animal
    {
        public abstract void Swim();
    }

    class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("eat as shark");
        }

        public override void Swim()
        {
            Console.WriteLine("swim as shark");
        }
    }

    abstract class Bird : Animal
    {
        public abstract void Fly();
    }

    class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("eat as eagle");
        }
        public override void Fly()
        {
            Console.WriteLine("fly as eagle");
        }
        public override string ToString()
        {
            return "eagle classi";
        }
    }

    #endregion
}
