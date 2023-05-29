namespace MethodOverridingDemo
{
    public abstract class Car
    {
        public virtual void StartCar()
        {
            Console.WriteLine("Turn key and start engine.");
        }

        public abstract void SetClock();
        
    }
}