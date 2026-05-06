using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace FullmetalLibrary
{
    public partial class Component1
    {
        public Vector2 position;
        public Vector2 direction;
        public float speed;

        public void Transform(Vector2 position, Vector2 direction, float speed)
        {
            this.position = position;
            this.direction = direction;
            this.speed = speed;
        }

        public void Move(float deltaTime)
        {
            position += direction * speed * deltaTime;
        }

        public void KeyboardControl(KeyboardKey W, KeyboardKey S, KeyboardKey A, KeyboardKey D, float deltaTime)
        {
            if (Raylib.IsKeyDown(KeyboardKey.W))
            {
                direction = new Vector2(0, -1);
            }
            else if (Raylib.IsKeyDown(KeyboardKey.S))
            {
                direction = new Vector2(0, 1);
            }
            if (Raylib.IsKeyDown(KeyboardKey.A))
            {
                direction = new Vector2(-1, 0);
            }
            else if (Raylib.IsKeyDown(KeyboardKey.D))
            {
                direction = new Vector2(1, 0);
            }
            Move(deltaTime);
        }
    }
}
