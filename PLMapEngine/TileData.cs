using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLMapEngine
{
    /// <summary>
    /// TileData class
    /// </summary>
    internal sealed class TileData
    {
        private List<String> idList = new List<String>();
        private List<Object> dataList = new List<Object>();

        /// <summary>
        /// Creates a TileData object
        /// </summary>
        internal TileData()
        {
            // Default Constructor for this class
        }

        /// <summary>
        /// Adds a Segment Data to TileData
        /// </summary>
        /// <param name="SegmentID">ID representing the Segment Data for this TileData</param>
        /// <param name="SegmentData">Contains information for this Segment Data</param>
        internal void Add(String SegmentID, Object SegmentData)
        {
            #region Add method code
            if (!IDExist(SegmentID))
            {
                idList.Add(SegmentID);
                dataList.Add(SegmentData);
            }
            else
            {
                throw new Exception("Segment ID already exist in TileData");
            }
            #endregion
        }

        /// <summary>
        /// Removes a Segment Data from TileData
        /// </summary>
        /// <param name="SegmentID"></param>
        internal void Remove(String SegmentID)
        {
            #region Remove method code
            if (IDExist(SegmentID))
            {
                int Index = idList.IndexOf(SegmentID);
                idList.RemoveAt(Index);
                dataList.RemoveAt(Index);
            }
            else
            {
                throw new Exception("Invalid Segment ID");
            }
            #endregion
        }

        /// <summary>
        /// Removes all Segment Data from TileData
        /// </summary>
        internal void Clear()
        {
            #region Clear method code
            idList.Clear();
            dataList.Clear();
            #endregion
        }

        /// <summary>
        /// Gets a specific Segment Data for TileData based on Segment ID
        /// </summary>
        /// <param name="SegmentID">Segment Data's ID</param>
        internal Object SegmentData(String SegmentID)
        {
            #region SegmentData method code
            if (IDExist(SegmentID))
            {
                int Index = idList.IndexOf(SegmentID);
                return dataList[Index];
            }
            else
            {
                throw new Exception("Invalid Segment ID");
            }
            #endregion
        }

        /// <summary>
        /// Gets size of TileData
        /// </summary>
        internal int Size
        {
            #region Size property code
            get { return dataList.Count; }
            #endregion
        }

        /// <summary>
        /// Checks to see if the ID already exist
        /// </summary>
        /// <param name="ID">Input ID</param>
        private bool IDExist(String ID)
        {
            #region IDExist method code
            for(int Index = 0; Index < idList.Count; Index++)
            {
                if(idList[Index] == ID)
                {
                    return true;
                }
            } return false;
            #endregion
        }
    }
}