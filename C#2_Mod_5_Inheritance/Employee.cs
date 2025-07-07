using System;
using C_2_Mod_5_Inheritance_Abstraction;

namespace C_2_Mod_5_Inheritance_Abstraction
{
    // Employee inherits from Person and implements IQuittable
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: "+ FirstName + " " + LastName);
        }

        // Implement the Quit method from the interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the job. ID: {Id}");
        }
    }
}
