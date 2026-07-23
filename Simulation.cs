using System;

namespace Pigeonotchi
{
    internal class Simulation
    {
        private readonly Pigeon _pigeon;

        public Simulation()
        {
            _pigeon = new Pigeon("Suspicious Pigeon");
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                TemporaryMethod();
                isRunning = false;
            }                        
        }

        private void TemporaryMethod() // will be removed soon
        {
            Console.WriteLine($"Hello, {_pigeon.Name}!!");
        }
    }
}
