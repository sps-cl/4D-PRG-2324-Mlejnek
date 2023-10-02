using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarriageApp.models
{
    internal abstract class Attendee<T>
    {
        public string Role { get; set; }
        public string Name { get; }
        public bool Attending { get; set; }

        public Attendee(string role, string name)
        {
            Role = role;
            Name = name;
            Attending = true;
        }

        public abstract void DisplayInfo();
    }
}
