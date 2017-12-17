using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Casulties.Classes.Objects;
using Casulties.Classes.Component;

namespace Casulties.GameDatabase
{
    /// <summary>
    /// LocalDB static class
    /// </summary>
    internal static class LocalDB
    {
        private static LocalDBConnector localDBConnector = new LocalDBConnector();

        /// <summary>
        /// Returns Troop object from local database by Troop's ID
        /// </summary>
        /// <param name="TroopID">Troop's ID</param>
        internal static Troop ExportTroopData(int TroopID)
        {
            #region ExportTroopData method code

            // Gets DataTable of troop data
            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = "GetTroopData";
            Cmd.Parameters.AddWithValue("@TroopID", TroopID);
            DataTable TroopData = localDBConnector.GetDataSet(Cmd).Tables[0];

            // Store GeneralProperty information
            int ID = (int)TroopData.Rows[0]["ID"];
            String Name = (String)TroopData.Rows[0]["Name"];
            int Tier = (int)TroopData.Rows[0]["Tier"];
            String Class = (String)TroopData.Rows[0]["Class"];
            int DeployCost = (int)TroopData.Rows[0]["DeployCost"];
            int Value = (int)TroopData.Rows[0]["Value"];
            Troop.GeneralProperty GeneralProperty = new Troop.GeneralProperty(ID, Name, Tier, Class, DeployCost, Value);

            // Store StatProperty information
            int HP = (int)TroopData.Rows[0]["HP"];
            int ATK = (int)TroopData.Rows[0]["ATK"];
            int DEF = (int)TroopData.Rows[0]["DEF"];
            int RES = (int)TroopData.Rows[0]["RES"];
            int RNG = (int)TroopData.Rows[0]["RNG"];
            int Movement = (int)TroopData.Rows[0]["Movement"];
            Troop.StatProperty StatProperty = new Troop.StatProperty(HP, ATK, DEF, RES, RNG, Movement);

            // Store AbilityProperty information (Not done yet)
            Troop.AbilityProperty AbilityProperty = new Troop.AbilityProperty();

            // Return Troop object
            return new Troop(GeneralProperty, StatProperty, AbilityProperty);

            #endregion
        }
    }
}
