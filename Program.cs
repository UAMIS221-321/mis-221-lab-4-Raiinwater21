   // Start
        Console.WriteLine("Enter 1 to display full triangle");
        Console.WriteLine("Enter 2 to display partial triangle");
        Console.WriteLine("Enter 3 to exit. Other choices are invalid");

        //  end
        while (true) {
            Console.Write("Enter choice: ");
            int triangleChoice = Convert.ToInt32(Console.ReadLine());

            if (triangleChoice == 1) {
                displayFullTriangle();
            }
            else if (triangleChoice == 2) {
                displayPartialTriangle();
            }
            else if (triangleChoice == 3) {
                Console.WriteLine("Exiting program...");
                break;
            }
            else {
                Console.WriteLine("Invalid choice. Please try 1, 2, or 3.");
            }
        }
//Display Full Triangle
    static void displayFullTriangle() {
        int numRows = new Random().Next(3, 10);
        for (int i = 1; i <= numRows; i++) {
            for (int j = 1; j <= i; j++) {
                Console.Write("O");
            }
            Console.WriteLine();
        }
    }
//Display partial
    static void displayPartialTriangle() {
        int numRows = new Random().Next(3, 10);
        Random random = new Random();
        for (int i = 1; i <= numRows; i++) {
            for (int j = 1; j <= i; j++) {
                if (random.Next(2) == 0) {
                    Console.Write(" ");
                }
                else {
                    Console.Write("O");
                }
            }
            Console.WriteLine();
        }
    }