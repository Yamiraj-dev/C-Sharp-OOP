namespace MethodOverridingDemo
{
    public class Tesla : Car
    {
        public override void StartCar()
        {
            Console.WriteLine("Set your destination or set the tesla key on the dash.");
        }
        public override void SetClock()
        {
            Console.WriteLine("The clock is automatically set.");
        }
    }
}