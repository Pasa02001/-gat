using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class Laser
    {
        Texture2D LaserT;
        Vector2 LaserPos = new Vector2(500, 500);
        Vector2 Eyepos = new Vector2(300, 300);
        Vector2 mousePos;
        float angle = 0;
        

        public Laser(Texture2D texture)
        {
            LaserT = texture;

        }

        public void Update(GameTime time)
        {
            KeyboardState ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.W))
            {
                LaserPos.Y -= 10;
            }
            if (ks.IsKeyDown(Keys.S))
            {
                LaserPos.Y += 10;
            }
            if (ks.IsKeyDown(Keys.A))
            {
                LaserPos.X -= 10;
            }
            if (ks.IsKeyDown(Keys.D))
            {
                LaserPos.X += 10;
            }

            mousePos = Mouse.GetState().Position.ToVector2();
            angle = (float)Math.Atan2(Eyepos.Y - mousePos.Y, Eyepos.X - mousePos.X);

            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
            }
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //float scale = .5f;

            //spriteBatch.Draw(LaserT, new Rectangle((int)LaserPos.X, (int)LaserPos.Y, (int)(LaserT.Width * scale), (int)(LaserT.Height * scale)), null, Color.White, angle, new Vector2(LaserT.Width / 2, LaserT.Height / 2), SpriteEffects.None, 0);
        }
    }
}
