using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casulties.Classes.Objects
{
    /// <summary>
    /// Troop class
    /// </summary>
    internal sealed class Troop
    {
        private Troop.GeneralProperty generalProperty;
        private Troop.StatProperty statProperty;

        internal Troop(Troop.GeneralProperty GeneralProperty,
            Troop.StatProperty StatProperty, Troop.AbilityProperty AbilityProperty)
        {
            generalProperty = GeneralProperty;
            statProperty = StatProperty;
        }

        /// <summary>
        /// Gets Troop's General Property
        /// </summary>
        internal Troop.GeneralProperty TroopGeneralProperty
        {
            #region GeneralProperty property code
            get { return generalProperty; }
            #endregion
        }

        /// <summary>
        /// Gets Troop's Stat Property
        /// </summary>
        internal Troop.StatProperty TroopStatProperty
        {
            #region StatProperty property code
            get { return statProperty; }
            #endregion
        }

        /// <summary>
        /// GeneralProperty class
        /// </summary>
        internal sealed class GeneralProperty
        {
            #region GeneralProperty class code

            private int id, tier, deployCost, value;
            private String name, className;

            /// <summary>
            /// Creates a GeneralProperty object for Troop
            /// </summary>
            /// <param name="ID">Troop's ID</param>
            /// <param name="Name">Troop's Name</param>
            /// <param name="Tier">Troop's Tier</param>
            /// <param name="Class">Troop's Class</param>
            /// <param name="DeployCost">Troop's Deploy Cost</param>
            /// <param name="Value">Troop's Value</param>
            internal GeneralProperty(int ID, String Name, int Tier, String Class, int DeployCost, int Value)
            {
                #region GeneralProperty constructor code
                id = ID;
                name = Name;
                tier = Tier;
                className = Class;
                deployCost = DeployCost;
                value = Value;
                #endregion
            }

            /// <summary>
            /// Gets Troop's ID
            /// </summary>
            internal int ID
            {
                #region ID property code
                get { return id; }
                #endregion
            }

            /// <summary>
            /// Gets Troop's Name
            /// </summary>
            internal String Name
            {
                #region Name property code
                get { return name; }
                #endregion
            }

            /// <summary>
            /// Gets Troop's Tier
            /// </summary>
            internal int Tier
            {
                #region Tier property code
                get { return tier; }
                #endregion
            }

            /// <summary>
            /// Gets Troop's class
            /// </summary>
            internal String Class
            {
                #region Class property code
                get { return className; }
                #endregion
            }

            /// <summary>
            /// Gets Troop's Deploy Cost
            /// </summary>
            internal int DeployCost
            {
                #region DeployCost property code
                get { return deployCost; }
                #endregion
            }

            /// <summary>
            /// Gets Troop's Value
            /// </summary>
            internal int Value
            {
                #region Value property code
                get { return value; }
                #endregion
            }

            #endregion
        }

        /// <summary>
        /// StatProperty class
        /// </summary>
        internal sealed class StatProperty
        {
            #region StatProperty class code

            private int hp, atk, def, res, rng, movement;

            /// <summary>
            /// Creates a StatProperty object for Troop
            /// </summary>
            /// <param name="HP">Troop's HP</param>
            /// <param name="ATK">Troop's ATK</param>
            /// <param name="DEF">Troop's DEF</param>
            /// <param name="RES">Troop's RES</param>
            /// <param name="RNG">Troop's RNG</param>
            /// <param name="Movement">Troop's Movement</param>
            internal StatProperty(int HP, int ATK, int DEF, int RES, int RNG, int Movement)
            {
                #region StatProperty constructor code
                hp = HP;
                atk = ATK;
                def = DEF;
                res = RES;
                rng = RNG;
                movement = Movement;
                #endregion
            }

            /// <summary>
            /// Gets or sets Troop's HP
            /// </summary>
            internal int HP
            {
                #region HP property code
                get { return hp; }
                set { hp = value; }
                #endregion
            }

            /// <summary>
            /// Gets or sets Troop's ATK
            /// </summary>
            internal int ATK
            {
                #region ATK property code
                get { return atk; }
                set { atk = value; }
                #endregion
            }

            /// <summary>
            /// Gets or sets Troop's DEF
            /// </summary>
            internal int DEF
            {
                #region DEF property code
                get { return def; }
                set { def = value; }
                #endregion
            }

            /// <summary>
            /// Gets or sets Troop's RES
            /// </summary>
            internal int RES
            {
                #region RES property code
                get { return res; }
                set { res = value; }
                #endregion
            }

            /// <summary>
            /// Gets or sets Troop's RNG
            /// </summary>
            internal int RNG
            {
                #region RNG property code
                get { return rng; }
                set { rng = value; }
                #endregion
            }

            /// <summary>
            /// Gets or sets Troop's Movement
            /// </summary>
            internal int Movement
            {
                #region Movement property code
                get { return movement; }
                set { movement = value; }
                #endregion
            }

            #endregion
        }

        /// <summary>
        /// AbilityProperty class
        /// </summary>
        internal sealed class AbilityProperty
        {
            internal AbilityProperty()
            {
                //
            }
        }
    }
}