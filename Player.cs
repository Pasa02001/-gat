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
    class Player
    {
        Texture2D Eye;
        Vector2 Eyepos = new Vector2(300, 300);
        Vector2 mousePos;
        float angle = 0;

        public Player(Texture2D texture)
        {
            Eye = texture;

        }

        public void Update(GameTime time)
        {
            KeyboardState ks = Keyboard.GetState();
            if (ks.IsKeyDown(Keys.W))
            {
                Eyepos.Y -= 10 ;
            }
            if (ks.IsKeyDown(Keys.S))
            {
                Eyepos.Y += 10;
            }
            if (ks.IsKeyDown(Keys.A))
            {
                Eyepos.X -= 10;
            }
            if (ks.IsKeyDown(Keys.D))
            {
                Eyepos.X += 10;
            }

            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {

            }


            mousePos = Mouse.GetState().Position.ToVector2();
            angle = (float)Math.Atan2(Eyepos.Y - mousePos.Y, Eyepos.X - mousePos.X);
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            float scale = .5f;
            
            spriteBatch.Draw(Eye, new Rectangle((int)Eyepos.X, (int)Eyepos.Y, (int)(Eye.Width * scale), (int)(Eye.Height * scale)), null, Color.White, angle, new Vector2(Eye.Width / 2, Eye.Height / 2), SpriteEffects.None, 0);
          
        }
    }
}
