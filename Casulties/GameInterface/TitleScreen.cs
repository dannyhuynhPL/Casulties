using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Casulties.GameInterface
{
    /// <summary>
    /// TitleScreen class
    /// </summary>
    internal sealed class TitleScreen
    {
        private Panel titleScreen = new Panel();

        /// <summary>
        /// Creates a TitleScreen object that will represent
        /// the title screen for this game
        /// </summary>
        /// <param name="GameClient">GameClient form</param>
        internal TitleScreen(Form GameClient)
        {
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
        }

        internal void Play(Form GameClient)
        {
            //
        }

        private void TitleScreenPanel(Form GameClient)
        {
            //
        }
    }
}