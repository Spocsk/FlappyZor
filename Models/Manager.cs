using System;
using System.Threading.Tasks;

namespace FlappyZor.Models
{
    public class Manager
    {

        public BirdModel Bird { get; set; }
        private bool IsRunning { get; set; } = false;

        public readonly int Gravity = 2;

        public Manager()
        {
            Bird = new BirdModel();
        }

        public async void Loop()
        {
            IsRunning = true;
            while (IsRunning)
            {
                Bird.Fall(Gravity);
                await Task.Delay(20);
            }
        }
    }
}

