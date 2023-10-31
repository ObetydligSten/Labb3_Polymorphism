namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry areaS = new Square();
            Geometry areaC = new Circle();
            Geometry areaR = new Rectangle();

            Console.WriteLine($"Area Square : {areaS.Area()}\nArea Circle : {areaC.Area()}\nArea Rectangle : {areaR.Area()}");
        }
    }
}