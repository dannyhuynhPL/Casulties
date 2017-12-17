using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Casulties.GameInterface;

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
            TitleScreen TitleScreen = new TitleScreen(GameClient);
        }
    }
}
