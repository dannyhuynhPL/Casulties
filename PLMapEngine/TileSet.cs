using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLMapEngine
{
    /// <summary>
    /// TileSet class
    /// </summary>
    internal sealed class TileSet
    {
        private TileSet.Property tileSetProperty;
        private Tile[,] tileSet;

        /// <summary>
        /// Creates a TileSet object
        /// </summary>
        /// <param name="TileSetProperty">TileSetProperty object</param>
        internal TileSet(TileSet.Property TileSetProperty)
        {
            #region TileSet constructor code
            tileSetProperty = TileSetProperty;
            tileSet = new Tile[TileSetProperty.Y, TileSetProperty.X];
            #endregion
        }

        /// <summary>
        /// Gets the TileSetProperty for this TileSet
        /// </summary>
        internal TileSet.Property TileSetProperty
        {
            #region TileSetProperty property code
            get { return tileSetProperty; }
            #endregion
        }

        /// <summary>
        /// Property class
        /// </summary>
        internal sealed class Property
        {
            #region Property class code

            private int x, y, pixelPerTile;
            private Image tileSetImage;

            /// <summary>
            /// Creates a Property object that contains information about the TileSet
            /// </summary>
            /// <param name="X">X-length of tiles for this TileSet</param>
            /// <param name="Y">Y-length of tiles for this TileSet</param>
            /// <param name="PixelPerTile">Number of pixels (height and width) per tiles for this TileSet</param>
            /// <param name="TileSetImage">Image for this TileSet</param>
            internal Property(int X, int Y, int PixelPerTile, Image TileSetImage)
            {
                #region Property constructor code
                if (X > 0 && Y > 0 && X <= 2000000000 && Y <= 2000000000)
                {
                    x = X; y = Y;
                    pixelPerTile = PixelPerTile;
                    tileSetImage = TileSetImage;
                }
                else
                {
                    throw new Exception("X,Y length and PixelPerTile cannot be less than 0 and cannot exceed 2,000,000,000");
                }
                #endregion
            }

            /// <summary>
            /// Gets the X-length of tiles for this TileSet
            /// </summary>
            internal int X
            {
                #region X property code
                get { return x; }
                #endregion
            }

            /// <summary>
            /// Gets the Y-length of tiles for this TileSet
            /// </summary>
            internal int Y
            {
                #region Y property code
                get { return y; }
                #endregion
            }

            /// <summary>
            /// Gets the number of pixels (height and width) per tiles for this TileSet
            /// </summary>
            internal int PixelPerTile
            {
                #region PixelPerTile property code
                get { return pixelPerTile; }
                #endregion
            }

            /// <summary>
            /// Gets the image for this TileSet
            /// </summary>
            internal Image TileSetImage
            {
                #region TileSetImage property code
                get { return tileSetImage; }
                #endregion
            }

            #endregion
        }
    }
}