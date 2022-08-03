// See https://aka.ms/new-console-template for more information
using updateVerisoftTask;
GeometricObject[] geometricObjects = new GeometricObject[2];


for (int i = 0; i < geometricObjects.Length; i++)
{
    Console.WriteLine("enter A for circle or B for rectangle");
    string choise = Console.ReadLine();
    switch (choise)
    {
        case "A":
            {
                Console.WriteLine("enter a radius");
                int radius = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter a color");
                string color = Console.ReadLine();
                Console.WriteLine("enter  1 for fiiled 0 for not filled");
                Boolean fill = true;
                int filled = Convert.ToInt32(Console.ReadLine());
                if (filled == 0)
                {
                    fill = false;
                }
                geometricObjects[i] = new Circle(radius, color, fill);
                break;

            }
        case "B":
            {
                Console.WriteLine("enter a width");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter a length");
                int len = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter a color");
                string color = Console.ReadLine();
                Console.WriteLine("enter  1 for fiiled 0 for not filled");
                Boolean fill = true;
                int filled = Convert.ToInt32(Console.ReadLine());
                if (filled == 0)
                {
                    fill = false;
                }
                geometricObjects[i] = new Rectangle(width, len, color, fill);
                break;
            }

        default:
            break;
    }


}
for (int i = 0; i < geometricObjects.Length; i++)
{
    Console.WriteLine(geometricObjects[i]);
    Console.WriteLine(" perimeter : " + geometricObjects[i].getPerimeter());
    Console.WriteLine(" area : " + geometricObjects[i].getArea());

}
