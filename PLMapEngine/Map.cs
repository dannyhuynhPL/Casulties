using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLMapEngine
{
    /// <summary>
    /// Map class
    /// </summary>
    internal sealed class Map
    {
        private String mapID;
        private Map.Dimension mapDimension;

        /// <summary>
        /// Creates a Map object
        /// </summary>
        /// <param name="MapID">Map's ID</param>
        /// <param name="MapDimension">Map's Dimension object</param>
        internal Map(String MapID, Map.Dimension MapDimension)
        {
            #region Map constructor code
            mapID = MapID;
            mapDimension = MapDimension;
            #endregion
        }

        /// <summary>
        /// Gets the Map ID
        /// </summary>
        internal String MapID
        {
            #region MapID property code
            get { return mapID; }
            #endregion
        }

        /// <summary>
        /// Gets the Map's Dimension object
        /// </summary>
        internal Map.Dimension MapDimension
        {
            #region MapDimension property code
            get { return mapDimension; }
            #endregion
        }

        /// <summary>
        /// Dimension class
        /// </summary>
        internal sealed class Dimension
        {
            #region Dimension class code

            private int x, y;

            /// <summary>
            /// Creates a Dimension object that holds the X and Y length
            /// value of the dimension
            /// </summary>
            /// <param name="X">X-length (Max value: 2,000,000,000)</param>
            /// <param name="Y">Y-length (Max value: 2,000,000,000)</param>
            internal Dimension(int X, int Y)
            {
                #region Dimension construcor code
                if(X > 0 && Y > 0 && X <= 2000000000 && Y <= 2000000000)
                {
                    x = X; y = Y;
                }
                else
                {
                    throw new Exception("Dimension X,Y length cannot be less than 0 and cannot exceed 2,000,000,000");
                }
                #endregion
            }

            /// <summary>
            /// Gets the X-length of Dimension object
            /// </summary>
            internal int X
            {
                #region X property code
                get { return x; }
                #endregion
            }

            /// <summary>
            /// Gets the Y-length of Dimension object
            /// </summary>
            internal int Y
            {
                #region Y property code
                get { return y; }
                #endregion
            }

            #endregion
        }
    }
}