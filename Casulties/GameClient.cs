﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casulties
{
    public partial class GameClient : Form
    {
        public GameClient()
        {
            InitializeComponent();

            TestClass.ExportTroopDataTest();

            // Test commit
        }
    }
}
