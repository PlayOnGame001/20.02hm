using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02hm
{
    delegate void Delegate();
    class Event
    {
        public event Delegate ev;
        public void EventPrint()
        {
            ev?.Invoke();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Event e = new Event();
            Credit_Card card = new Credit_Card();
            card.Enter();
            e.ev += new Delegate(card.Add);
            e.ev += new Delegate(card.ChangePin);
            e.EventPrint();
        }
    }
}