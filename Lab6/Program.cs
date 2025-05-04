namespace Lab6;

class Program
{
    static void Main(string[] args)
    {
        public string model;
        public string color;
        public int year;

        public void Display()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("year: " + year);
        }
        // Problem 1:
        public void start()
        {
            Console.Writeline("The car is starting.");
        }
        // Problem 2
        public void Drive(int miles)
        {
            Console.WriteLine($"The car drove{miles} miles.");
        }
        // problem 3
        public string GetDescription()
        {
            return $"{year} {color} {model}";
        }
        // problem 4
        public void Repaint(string newColor)
        {
            color = newColor;
            Console.WriteLine($"The car has been repainted to {color}.");
        }
        
        Static void()
        {
            // creating car object
            Car myCar = new Car();
            myCar.model = "Toyota";
            myCar.color = "White";
            myCar.year = 2020;

           myCar.Display();
           myCar.start();
           myCar.Drive(0);

           string description = myCar.GetDescription();
           Console.WriteLine(description);

           myCar.Repaint("Black");
           Console.WriteLine("The car has been repainted to" + myCar.color);

        

        }

    }

    
}
