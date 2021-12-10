using System.Collections.Generic;

namespace Ex1
{
    public abstract class Subject
    {
        //Observer pattern
        protected readonly List<IObserver> Observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public abstract void Update();
    }
}