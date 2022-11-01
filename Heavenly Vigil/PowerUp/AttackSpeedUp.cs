using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heavenly_Vigil
{
    internal class AttackSpeedUp : PowerUp
    {
        //Fields
        public int attackSpdAmp;
        //Properties
        //Constructors
        //Methods
        public override void LoadContent(ContentManager content)
        {

        }

        public override void Update(GameTime gameTime, GraphicsDeviceManager _graphics)
        {

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
        public override void AddValue(GameObject player)
        {
            throw new NotImplementedException();
        }
    }
}
