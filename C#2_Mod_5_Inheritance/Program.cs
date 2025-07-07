using System;


namespace C_2_Mod_5_Inheritance_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 123
            };

            // Call the SayName() method from the Person base class
            employee.SayName();

            Console.ReadLine(); // Pause to see output

            // Use polymorphism: assign Employee to an IQuittable object
            IQuittable quittable = employee;
            quittable.Quit(); // Call the Quit method via interface reference

            Console.ReadLine(); // Pause to view output

        }
    }
}
    