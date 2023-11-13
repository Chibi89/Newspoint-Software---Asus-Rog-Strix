using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NewSoft.Framework.MicaLibrary;
using static NewSoft.Framework.MicaLibrary.ParameterTypes;
using static NewSoft.Framework.MicaLibrary.MicaEffectMethods;
using NewSoft.Framework;

namespace Newspoint_Software___Asus_Rog_Strix_g15_g513rm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region"loadmicaEffecy"
            Form me = this;
            LoadMicaSet.ApplyEffectAllForm(ref me, Color.Maroon, 0, 3);
            PublicFunctions.WinFormFunctionStyle.FormTitle(me, "Newspoint Software - Asus Rog Strix G15 - G513RM");
            #endregion
            #region"LoadTime"
            LoadSetTime.Start();
            #endregion
        }

        private void LoadSetTime_Tick(object sender, EventArgs e)
        {
            loadChar.Visible = false;
            D_PANEL.Visible = true;
        }
    }
}
