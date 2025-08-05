static void GradeCalculator()
    {
        Console.Write("Enter numerical grade (0 - 100): ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
            Console.WriteLine("Letter Grade: A");
        else if (grade >= 80)
            Console.WriteLine("Letter Grade: B");
        else if (grade >= 70)
            Console.WriteLine("Letter Grade: C");
        else if (grade >= 60)
            Console.WriteLine("Letter Grade: D");
        else
            Console.WriteLine("Letter Grade: F");
    }

 static void TicketPriceCalculator()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age <= 12 || age >= 65)
            Console.WriteLine("Ticket Price: GHC7");
        else
            Console.WriteLine("Ticket Price: GHC10");
    }

static void TriangleTypeIdentifier()
    {
        Console.Write("Enter side 1: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        int side3 = int.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
            Console.WriteLine("Triangle Type: Equilateral");
        else if (side1 == side2 || side2 == side3 || side1 == side3)
            Console.WriteLine("Triangle Type: Isosceles");
        else
            Console.WriteLine("Triangle Type: Scalene");
    }
