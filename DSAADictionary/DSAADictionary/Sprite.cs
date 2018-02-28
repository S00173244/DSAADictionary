using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using NSLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAADictionary
{
    public class Sprite
    {
        KeyValuePair<string, string> textureAndSound;

        Vector2 pos;
        Rectangle bounds;

        public Sprite(string texture, string sound, Vector2 position)
        {
            textureAndSound = new KeyValuePair<string, string>(texture, sound);
            pos = position;
            bounds = new Rectangle((int)this.pos.X - TextureManager.allTextures[texture].Width / 2, (int)this.pos.Y - TextureManager.allTextures[texture].Height / 2 - 10, TextureManager.allTextures[texture].Width, TextureManager.allTextures[texture].Height);
        }



        public void Draw(SpriteBatch sp)
        {
            sp.Begin();
            sp.Draw(TextureManager.allTextures[textureAndSound.Key], pos,Color.White);
            sp.End();
        }

        
    }
}
