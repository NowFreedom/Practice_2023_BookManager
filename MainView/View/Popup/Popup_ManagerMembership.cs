using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BookManagerSystem
{
    public partial class Popup_ManagerMembership : DevExpress.XtraEditors.XtraForm
    {
        public static Popup_ManagerMembership o_Popup = new Popup_ManagerMembership();
        private string sID = string.Empty;

        public Popup_ManagerMembership()
        {
            InitializeComponent();
        }

        public static DialogResult fsShow(IWin32Window p_oOwner, string[] p_sVal, out string p_sID)
        {
            p_sID = string.Empty;

            DialogResult eResult = o_Popup.ShowDialog();
            {
                if(eResult == DialogResult.OK)
                {
                    p_sID = o_Popup.sID;
                }
            }

            return eResult;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}