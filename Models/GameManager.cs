using System;
namespace FlappyZor.Models
{
    public class GameManager
    {

        public BirdModel Bird { get; set; }

        public GameManager()
        {
            Bird = new BirdModel();
        }
    }
}

