using System;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            //Declare new shape object
            Shape myShape = new Shape();

            //Open the game window
            SwinGame.OpenGraphicsWindow("GameMain", 800, 600);
            SwinGame.ShowSwinGameSplashScreen();
            
            //Run the game loop
            while(false == SwinGame.WindowCloseRequested())
            {
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents();
                
                //Clear the screen and draw the framerate
                SwinGame.ClearScreen(Color.White);
                SwinGame.DrawFramerate(0,0);

                //draw myShape to the screen
                myShape.Colour(Color.Green);
                myShape.Draw();

                if (SwinGame.MouseClicked(MouseButton.LeftButton))
                {
                    Point2D mousepos = Input.MousePosition();
                    myShape.X(mousepos.X);
                    myShape.Y(mousepos.Y);
                }

                //Draw onto the screen
                SwinGame.RefreshScreen(60);
            }
        }
    }
}