using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFollow
{
    public class Enemy
    {

        public int x, y, size, speed;
        string direction;

        public Enemy(int _x, int _y, int _size, int _speed)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;

            direction = "down";
        }

        public void Move()
        {
            if (direction == "down")
            {
                y += speed;
            }
            else if (direction == "right")
            {
                x += speed;
            }
            else if (direction == "up")
            {
                y -= speed;
            }
            else if (direction == "left")
            {
                x -= speed;
            }

            if (x == 50 && y == 400)
            {
                direction = "right";
            }

            if (x == 200 && y == 400)
            {
                direction = "up";
            }

            if (x == 200 && y == 200)
            {
                direction = "right";
            }
        }

    }
}
