using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Casulties.Classes.Component;
using Casulties.Classes.Objects;
using Casulties.GameDatabase;

namespace Casulties
{
    /// <summary>
    /// TestClass static class
    /// </summary>
    internal static class TestClass
    {
        /// <summary>
        /// Grab troop data from local database and store it in a Troop object
        /// </summary>
        internal static void ExportTroopDataTest()
        {
            Troop TroopData = LocalDB.ExportTroopData(1);
            Debug.WriteLine(Environment.NewLine);
            Debug.WriteLine("[Troop Data]");
            Debug.WriteLine("ID: " + TroopData.TroopGeneralProperty.ID);
            Debug.WriteLine("Name: " + TroopData.TroopGeneralProperty.Name);
            Debug.WriteLine("Tier: " + TroopData.TroopGeneralProperty.Tier);
            Debug.WriteLine("Class: " + TroopData.TroopGeneralProperty.Class);
        }
    }
}
