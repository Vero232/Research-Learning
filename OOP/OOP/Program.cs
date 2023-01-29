// See https://aka.ms/new-console-template for more information

class OOPEXAMPLE
{
    //Encapsulation
    abstract class Vehicle
    {
        public string brand { get; set; }
        public string color { get; set; }

        public abstract void getTyreSize(); //abstraction

        public void getColor()
        {
            Console.WriteLine($"This car has a color of {color}");
        }

        public void Start()
        {

            Console.WriteLine("You have started your car");
        }


        public void Stop()
        {

            Console.WriteLine("Car has stopped");
        }

        //Method Overloading - polymorphism
        public void Stop(string location)
        {

            Console.WriteLine($"Car has stopped at {location}");
        }

        //Runtime Polymorphism
        public virtual void getSpeed()
        {
            Console.WriteLine("Vehicle speed is 0");
        }

    }


    //Inheritance
    class Truck : Vehicle
    {
        public string modelName = "Focus";

        public double speed { get; set; }
        public Truck() {
            speed = 120;
        }

        public override void getTyreSize()
        {
            Console.WriteLine("Truck tyre is 2");
        }
        
        public override void getSpeed()//runtime polymorphism
        {
            Console.WriteLine($"Truck speed is {speed}km/h");
        }

    }


    class Program {
        static void Main ()
        {
            Truck myTruck = new();
   
            myTruck.brand = "Ford";
            myTruck.color = "blue";
            myTruck.Start();
            myTruck.Stop();
            myTruck.Stop("Cape Town");
            Console.WriteLine(myTruck.modelName);
            myTruck.getTyreSize();
            myTruck.getSpeed();
            Console.ReadLine();

        }
    }
}