abstract class Shape
{
    public abstract double CalculateSquare();
    public abstract double CalculatePerimeter();
}

class Circle : Shape, IPrintableShape
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Радиус должен быть больше нуля.");
            _radius = value;
        }
    }

    public override double CalculateSquare() => Math.PI * Math.Pow(Radius, 2);
    public override double CalculatePerimeter() => 2 * Math.PI * Radius;

    public void TrySet(double value)
    {
        bool isSuccess = false;

        if (value <= 0)
        {
            Console.WriteLine($"Статус: {isSuccess}");
        }

        Radius = value;
        isSuccess = true;
        Console.WriteLine($"Статус: {isSuccess}");
    }

    public void PrintType() => Console.WriteLine("Tип фигуры: Круг");
    public void PrintSquare() => Console.WriteLine($"Площадь: {CalculateSquare():F2}");
    public void PrintPerimeter() => Console.WriteLine($"Периметр: {CalculatePerimeter():F2}");
}

class Rectangle : Shape, IPrintableShape
{
    private double _width;
    private double _height;

    public double Width
    {
        get => _width;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Ширина должна быть больше нуля.");
            _width = value;
        }
    }

    public double Height
    {
        get => _height;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Высота должна быть больше нуля.");
            _height = value;
        }
    }

    public override double CalculateSquare() => Width * Height;

    public override double CalculatePerimeter() => 2 * (Width + Height);

    public void TrySet(double width, double height)
    {
        bool isSuccess = false;

        if (width <= 0 || height <= 0)
        {
            Console.WriteLine($"Статус: {isSuccess}");
        }

        Width = width;
        Height = height;
        isSuccess = true;
        Console.WriteLine($"Статус: {isSuccess}");
    }

    public void PrintType() => Console.WriteLine("Тип фигуры: Прямоугольник.");
    public void PrintSquare() => Console.WriteLine($"Площадь: {CalculateSquare():F2}");
    public void PrintPerimeter() => Console.WriteLine($"Периметр: {CalculatePerimeter():F2}");
}

class Triangle : Shape, IPrintableShape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public bool TrySet(double a, double b, double c, out string message)
    {
        message = string.Empty;

        if (a <= 0 || b <= 0 || c <= 0)
        {
            message = "Все стороны треугольника должны быть больше нуля.";
            return false;
        }

        if (!IsValidTriangle(a, b, c))
        {
            message = "Сумма любых двух сторон должна быть больше третьей стороны.";
            return false;
        }

        SideA = a;
        SideB = b;
        SideC = c;

        return true;
    }

    private static bool IsValidTriangle(double a, double b, double c) =>
        a + b > c && a + c > b && b + c > a;

    public override double CalculateSquare()
    {
        double semiPerimeter = CalculatePerimeter() / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }

    public override double CalculatePerimeter() => SideA + SideB + SideC;

    public void PrintType() => Console.WriteLine("Тип фигуры: Треугольник.");
    public void PrintSquare() => Console.WriteLine($"Площадь: {CalculateSquare():F2}");
    public void PrintPerimeter() => Console.WriteLine($"Периметр: {CalculatePerimeter():F2}");
}

class Trapezoid : Shape, IPrintableShape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }
    public double SideD { get; set; }
    public double Height { get; set; }

    public bool TrySet(double a, double b, double c, double d, double h, out string message)
    {
        message = string.Empty;

        if (a <= 0 || b <= 0 || c <= 0 || d <= 0 || h <= 0)
        {
            message = "Все стороны и высота трапеции должны быть больше нуля.";
            return false;
        }

        SideA = a;
        SideB = b;
        SideC = c;
        SideD = d;
        Height = h;

        return true;
    }

    public override double CalculateSquare() => (SideA + SideB) * Height / 2;
    public override double CalculatePerimeter() => SideA + SideB + SideC + SideD;

    public void PrintType() => Console.WriteLine("Тип фигуры: Трапеция.");
    public void PrintSquare() => Console.WriteLine($"Площадь: {CalculateSquare():F2}");
    public void PrintPerimeter() => Console.WriteLine($"Периметр: {CalculatePerimeter():F2}");
}