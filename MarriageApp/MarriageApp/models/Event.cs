using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarriageApp.models
{
    internal abstract class Event<T>
    {
        public int Order { get; set; }
        public string Name { get; }

        public Event(int order, string name)
        {
            Order = order;
            Name = name;
        }

        public abstract void DisplayInfo();
    }
}
