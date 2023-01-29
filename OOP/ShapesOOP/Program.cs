// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

    class Triangle
    {
        //member variables
        public int base1;
        public int height;

        public double GetArea()
        {
            return (base1 * height) / 2;
        }
        public void Displayarea()
        {
            Console.WriteLine("base: {0}", base1);
            Console.WriteLine("Width: {0}", height);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class triangle

    class ExecuteTriangle
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            t.base1 = 4;
            t.height = 5;
            t.Displayarea();
            Console.ReadLine();
        }
    }
