namespace myProject {
    class Employee {
      static void Main(string[] args) {
        // Console.WriteLine("Help Poor!");
        string? first_name, last_name;

        Console.Write("Type your First Name : ");
        first_name = Console.ReadLine();

        Console.Write("Type Your Last Name : ");
        last_name = Console.ReadLine();

        Console.Write("Here Your First Name : " + first_name + " And Your Last Name : " + last_name);
        // Another Way
        Console.Write($"\nYour Name is {first_name} {last_name} ");
        // Console.ReadKey(); 

        } // Main Method End

    } // Class End
}