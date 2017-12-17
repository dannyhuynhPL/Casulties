using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLMapEngine
{
    /// <summary>
    /// MapSet class
    /// </summary>
    internal sealed class MapSet
    {
        private List<Map> mapSet = new List<Map>();

        /// <summary>
        /// Creates a MapSet object
        /// </summary>
        internal MapSet()
        {
            // Default constructor for this class
        }

        /// <summary>
        /// Adds a Map to MapSet
        /// </summary>
        /// <param name="Map">Map object</param>
        internal void Add(Map Map)
        {
            #region Add method code
            if (!IDExist(Map.MapID))
            {
                mapSet.Add(Map);
            }
            else
            {
                throw new Exception("Map with that Map ID already exist in this MapSet");
            }
            #endregion
        }

        /// <summary>
        /// Removes a Map from MapSet
        /// </summary>
        /// <param name="MapID">Map ID</param>
        internal void Remove(String MapID)
        {
            #region Remove method code
            if (IDExist(MapID))
            {
                for(int Index = 0; Index < mapSet.Count; Index++)
                {
                    if(mapSet[Index].MapID == MapID)
                    {
                        mapSet.RemoveAt(Index);
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("Invalid Map ID");
            }
            #endregion
        }

        /// <summary>
        /// Removes all Map from MapSet
        /// </summary>
        internal void Clear()
        {
            #region Clear method code
            mapSet.Clear();
            #endregion
        }

        /// <summary>
        /// Gets a specific Map from MapSet based on Map ID
        /// </summary>
        /// <param name="MapID">Map ID</param>
        internal Map Map(String MapID)
        {
            #region Map method code
            if (IDExist(MapID))
            {
                for(int Index = 0; Index < mapSet.Count; Index++)
                {
                    if(mapSet[Index].MapID == MapID)
                    {
                        return mapSet[Index];
                    }
                } return null;
            }
            else
            {
                throw new Exception("Invalid Map ID");
            }
            #endregion
        }

        /// <summary>
        /// Gets size of MapSet
        /// </summary>
        internal int Size
        {
            #region Size property code
            get { return mapSet.Count; }
            #endregion
        }

        /// <summary>
        /// Checks to see if the ID already exist
        /// </summary>
        /// <param name="ID">Input ID</param>
        private bool IDExist(String ID)
        {
            #region IDExist method code
            for (int Index = 0; Index < mapSet.Count; Index++)
            {
                if (mapSet[Index].MapID == ID)
                {
                    return true;
                }
            }
            return false;
            #endregion
        }
    }
}