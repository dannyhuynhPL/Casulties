using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Casulties
{
    /// <summary>
    /// Game class
    /// </summary>
    internal sealed class Game
    {
        /// <summary>
        /// Creates a Game object
        /// </summary>
        /// <param name="GameClient">GameClient form</param>
        internal Game(Form GameClient)
        {
            RenderGameControl(GameClient);
        }

        internal void SelectGameType(Form GameClient)
        {
            //
        }

        /// <summary>
        /// Add game controls to GameClient form
        /// </summary>
        /// <param name="GameClient">GameClient form</param>
        private void RenderGameControl(Form GameClient)
        {
            Game.TitleScreen.Create(GameClient);
        }

        /// <summary>
        /// TitleScreen class
        /// </summary>
        private sealed class TitleScreen
        {
            #region TitleScreen class code

            private static Panel titleScreen = new Panel();

            /// <summary>
            /// Add controls that represents the titlescreen to the game
            /// </summary>
            /// <param name="GameClient">GameClient form</param>
            internal static void Create(Form GameClient)
            {
                #region Create method code

                titleScreen.Name = "TitleScreen";
                titleScreen.Size = new Size(1500, 800);
                titleScreen.BackColor = Color.Red;
                titleScreen.Location = new Point(0, 0);

                Label Title = new Label();
                Title.Name = "Title";
                Title.Text = "CASULTIES";
                Title.Size = new Size(980, 150);
                Title.Font = new Font("Arial", 120, FontStyle.Bold);
                Title.ForeColor = Color.DarkRed;
                Title.BackColor = Color.Transparent;
                Title.Location = new Point(240, 30);
                titleScreen.Controls.Add(Title);

                Button Play = new Button();
                Play.Name = "Play";
                Play.Text = "PLAY";
                Play.Size = new Size(350, 120);
                Play.Font = new Font("Arial", 60, FontStyle.Bold);
                Play.ForeColor = Color.DarkRed;
                Play.BackColor = Color.Red;
                Play.FlatStyle = FlatStyle.Flat;
                Play.FlatAppearance.BorderColor = Color.DarkRed;
                Play.FlatAppearance.BorderSize = 5;
                Play.Location = new Point(570, 320);
                titleScreen.Controls.Add(Play);
                ((Button)titleScreen.Controls.Find("Play", false)[0]).BringToFront();

                Button Quit = new Button();
                Quit.Name = "Quit";
                Quit.Text = "QUIT";
                Quit.Size = new Size(350, 120);
                Quit.Font = new Font("Arial", 60, FontStyle.Bold);
                Quit.ForeColor = Color.DarkRed;
                Quit.BackColor = Color.Red;
                Quit.FlatStyle = FlatStyle.Flat;
                Quit.FlatAppearance.BorderColor = Color.DarkRed;
                Quit.FlatAppearance.BorderSize = 5;
                Quit.Location = new Point(570, 460);
                titleScreen.Controls.Add(Quit);
                ((Button)titleScreen.Controls.Find("Quit", false)[0]).BringToFront();

                GameClient.Controls.Add(titleScreen);

                #endregion
            }

            #endregion
        }

        private sealed class GameTypeSelectionScreen
        {
            //
        }
    }
}