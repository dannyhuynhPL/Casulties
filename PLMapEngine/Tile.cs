using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLMapEngine
{
    /// <summary>
    /// Tile class
    /// </summary>
    internal sealed class Tile
    {
        private TileData tileData;
        private int priority;

        /// <summary>
        /// Creates a Tile object
        /// </summary>
        internal Tile()
        {
            #region Tile constructor code
            tileData = new TileData();
            priority = 0;
            #endregion
        }

        /// <summary>
        /// Creates a Tile object
        /// </summary>
        /// <param name="Priority">Tile's Priority value)</param>
        internal Tile(int Priority)
        {
            #region Tile constructor code
            tileData = new TileData();
            priority = Priority;
            #endregion
        }

        /// <summary>
        /// Creates a Tile object
        /// </summary>
        /// <param name="TileData">TileData object</param>
        internal Tile(TileData TileData)
        {
            #region Tile constructor code
            tileData = TileData;
            priority = 0;
            #endregion
        }

        /// <summary>
        /// Creates a Tile object
        /// </summary>
        /// <param name="Priority">Tile's Priority value</param>
        /// <param name="TileData">TileData object</param>
        internal Tile(int Priority, TileData TileData)
        {
            #region Tile constructor code
            tileData = TileData;
            priority = Priority;
            #endregion
        }

        /// <summary>
        /// Gets or sets TileData for Tile
        /// </summary>
        internal TileData TileData
        {
            #region TileData property code
            get { return tileData; }
            set { tileData = value; }
            #endregion
        }
    }
}