namespace InterfaceDemo
{
    internal class Program
    {
        // Inter face is a contract
        // Classes are what implement interfaces

        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();
            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            NintendoController nsController = new NintendoController();
            USLayoutKeyboard uSLayoutKeyboard = new USLayoutKeyboard();
           
            controllers.Add(keyboard);
            controllers.Add(gameController);
            controllers.Add(nsController);

            foreach (IComputerController controller in controllers) 
            {
                controller.CurrentKeyPressed();
                controller.Connect();
                // the two other properties such as Keyboard's ConnectionType and GameController's ButtonLayout are now shown because the interface does not have these.

                if (controller is GameController gc)
                {
                    // we can use either of two variables here (gc or controller to access properties/methods within those classes)
                }

                if (controller is IBatteryPowered powered)
                {
                    // we can use either of two variables here (powered or controller to access properties/methods within those classes)
                }
            }

            using (GameController gc =  new GameController()) 
            {
                // dispose allows us to clear memory or terminate connections to databases. (these are just use cases)
            }

            List<IBatteryPowered> batteryPowereds = new List<IBatteryPowered>();

            batteryPowereds.Add(nsController);
            batteryPowereds.Add(uSLayoutKeyboard);

            Console.ReadLine();
        }
    }

    // standard for naming interface is "I" followed by pascal casing of words
    public interface IComputerController : IDisposable // this is combining two interfaces to become a larger interface ( do not confuse this with inheritance or implementation )
    {
        void Connect();
        void CurrentKeyPressed();
    }

    public interface IBatteryPowered
    {
        int BatteryLevel { get; set; }
    }

    public class Keyboard : IComputerController
    {
        public void Connect()
        {

        }

        public void CurrentKeyPressed()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public string ConnectionType { get; set; }
    }


    public class GameController : IComputerController, IDisposable
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void CurrentKeyPressed()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            // shutdown tasks (shut down class or get rid of it)
        }

        public void ButtonLayout()
        {

        }
      
    }

    public class USLayoutKeyboard : Keyboard, IBatteryPowered
    {
        public int BatteryLevel { get; set; }
    }

    public class NintendoController : GameController, IBatteryPowered
    {
        public int BatteryLevel { get; set; }
    }
}

// It is important to remember, inheritance first then interface. 