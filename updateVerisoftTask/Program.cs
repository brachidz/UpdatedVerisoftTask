// See https://aka.ms/new-console-template for more information

using updateVerisoftTask;
Shape[] shapes = new Shape[2];



for (int i = 0; i < shapes.Length; i++)
{
    //get parametr from the user and creates the appropriate shape
    //and puts it in the  shapes array 
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
                shapes[i] = new Circle(radius, color, fill);
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
                shapes[i] = new Rectangle(width, len, color, fill);
                break;
            }

        default:
            break;
    }


}
//Go over the array and call the functions to calculate area and perimeter
//By checking the type of each element in the array of shapes (circle or rectangle)
//and converting it 
for (int i = 0; i < shapes.Length; i++)
{
    Console.WriteLine(shapes[i]);
    if (shapes[i] is  Circle)
    Console.WriteLine(" area : " + ((Circle)shapes[i]).getArea());
    else
        Console.WriteLine(" area : " + ((Rectangle)shapes[i]).getArea());
    if (shapes[i] is Circle)
        Console.WriteLine(" peremiter : " + ((Circle)shapes[i]).getPerimeter());
    else
        Console.WriteLine(" peremiter : " + ((Rectangle)shapes[i]).getPerimeter());

}
//exemple
/*enter A for circle or B for rectangle
A
enter a radius
4
enter a color
green
enter  1 for fiiled 0 for not filled
1
enter A for circle or B for rectangle
B
enter a width
3
enter a length
2
enter a color
red
enter  1 for fiiled 0 for not filled
0
A Circle with radius  of 4  which is a subclass of A shape with color pf green and filled
 perimeter : 25.132741228718345
 area: 50.26548245743669
A rectangle with width :3 and length:2 which is a subclass of A shape with color pf red and  not filled
 perimeter : 10
 area: 6*/