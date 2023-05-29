namespace MethodOverridingDemo
{
    public class Supra : Car
    {
        public override void SetClock()
        {
            Console.WriteLine("Move the dial on the clock manually.");
        }
    }
}