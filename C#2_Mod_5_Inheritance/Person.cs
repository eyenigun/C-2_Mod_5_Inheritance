using System;

namespace C_2_Mod_5_Inheritance_Abstraction
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Void method to write full name
        public abstract void SayName();
       
    }
}
