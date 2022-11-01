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
    internal class UserInterface : GameObject
    {
        //-----FIELDS-----

        private int health;
        private Vector2 outlinePosition;
        private Vector2 healthBarPosition;
        private Texture2D outlineSprite;
        private Texture2D healthBarSprite;

        private Rectangle outlineR;
        private Rectangle healthBarR;

        //-----PROPERTIES-----



        //-----CONSTRUCTORS-----

        public UserInterface()
        {
            health = 100;
            outlinePosition = new Vector2(0, 0);
            healthBarPosition = new Vector2(10, 5);

            outlineR.Width = 120;
            outlineR.Height = 20;
            healthBarR.Width = 100;
            healthBarR.Height = 10;

        }

        //-----METHODS-----

        public override void Draw(SpriteBatch spriteBatch)
        {

        }

        public override void LoadContent(ContentManager content)
        {
            outlineSprite = content.Load<Texture2D>("");
            healthBarSprite = content.Load<Texture2D>("");
        }

        public override void Update(GameTime gameTime)
        {
            AdjustHealthBar();
        }

        private void AdjustHealthBar()
        {
            healthBarR.Width = health;
        }
    }
}
