using System;
namespace FlappyZor.Models
{
    public class BirdModel
    {

        public int DsitanceFromGround { get; set;} = 100;

        public BirdModel()
        {
        }

        public void Fall(int gravity)
        {
            DsitanceFromGround -= gravity;
        }
    }
}

