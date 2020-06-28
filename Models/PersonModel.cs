using System;

// This is a model in .Net C#
namespace MVCDemo.Models
{
    public class PersonModel
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public int Age { get; set; } = 0;
       public bool IsAlive { get; set; } = true;
    }
}
