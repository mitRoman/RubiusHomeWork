interface IPrintableShape
{
    void PrintType();
    void PrintSquare();
    void PrintPerimeter();
}

class Program
{
    static void Main()
    {
        Parser parser = new Parser();
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        Triangle triangle = new Triangle();
        Trapezoid trapezoid = new Trapezoid();

        //--------- Circle --------
        bool isStop = false;
        while (!isStop)
        {
            try
            {
                Console.WriteLine("-----------------");
                Console.Write("Введите радус круга: ");
                double radius = parser.GetParseValue(Console.ReadLine());

                circle.TrySet(radius);
                circle.PrintType();
                circle.PrintSquare();
                circle.PrintPerimeter();

                isStop = true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //--------- Rectangle ----------
        isStop = false;
        while (!isStop)
        {
            try
            {
                Console.WriteLine("-----------------");
                Console.Write("Введите ширину прямоугольника: ");
                double width = parser.GetParseValue(Console.ReadLine());
                Console.Write("Введите высоту прямоугольника: ");
                double height = parser.GetParseValue(Console.ReadLine());

                rectangle.TrySet(width, height);
                rectangle.PrintType();
                rectangle.PrintSquare();
                rectangle.PrintPerimeter();

                isStop = true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //--------- Triangle -----------
        isStop = false;
        while (!isStop)
        {
            try
            {
                Console.WriteLine("-----------------");
                Console.Write("Введите длину стороны А треугольника: ");
                double sideA = parser.GetParseValue(Console.ReadLine());
                Console.Write("Введите длину стороны B треугольника: ");
                double sideB = parser.GetParseValue(Console.ReadLine());
                Console.Write("Введите длину стороны C треугольника: ");
                double sideC = parser.GetParseValue(Console.ReadLine());

                if (triangle.TrySet(sideA, sideB, sideC, out string message))
                {
                    triangle.PrintType();
                    triangle.PrintSquare();
                    triangle.PrintPerimeter();
                    isStop = true;
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //--------- Trapezoid -----------
        isStop = false;
        while (!isStop)
        {
            try
            {
                Console.WriteLine("-----------------");
                Console.Write("Введите длину основания А трапеции: ");
                double sideA = parser.GetParseValue(Console.ReadLine());
                Console.Write("Введите длину основания В трапеции: ");
                double sideB = parser.GetParseValue(Console.ReadLine());
                Console.Write("Введите длину боковой стороны С трапеции: ");
                double sideC = parser.GetParseValue(Console.ReadLine());
                Console.Write("Введите длину боковой стороны D трапеции: ");
                double sideD = parser.GetParseValue(Console.ReadLine());
                Console.Write("Введите высоту трапеции: ");
                double height = parser.GetParseValue(Console.ReadLine());

                if (trapezoid.TrySet(sideA, sideB, sideC, sideD, height, out string message))
                {
                    trapezoid.PrintType();
                    trapezoid.PrintSquare();
                    trapezoid.PrintPerimeter();
                    isStop = true;
                }
                else
                {
                    Console.WriteLine(message);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
