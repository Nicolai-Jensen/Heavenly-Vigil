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
    public abstract class PowerUp : GameObject
    {
        //Fields
        protected int valueAmp;
        //Properties
        //Constructors
        //Methods
        public override void LoadContent(ContentManager content)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            
        }
        public abstract void AddValue(GameObject player);
    }
}
