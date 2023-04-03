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
    public partial class Popup_Login : DevExpress.XtraEditors.XtraForm
    {
        CMannager_Manager m_oManager_Manager;

        public Popup_Login()
        {
            InitializeComponent();
        }

        private void Popup_Login_Load(object sender, EventArgs e)
        {
            this.chkPassShow.Checked    = false;
            this.txtID.Text             = string.Empty;
            this.txtPassword.Text       = string.Empty;

            this.m_oManager_Manager = new CMannager_Manager();

            if(!m_oManager_Manager.fnCreateData())
            {
                XtraMessageBox.Show("Manager data load error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbButton_ClickEvent(object sender, EventArgs e)
        {
            if(sender is Control oButton)
            {
                if(oButton.Name == "btnLogin")
                {
                    string sID      = this.txtID.Text.Trim();
                    string sPass    = this.txtPassword.Text.Trim();

                    if(sID      == string.Empty)     { XtraMessageBox.Show("ID is empty"        , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if(sPass    == string.Empty)     { XtraMessageBox.Show("Password is empty"  , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    if (!this.m_oManager_Manager.fnLogin_InfoCheck(sID, sPass)) { XtraMessageBox.Show("Login Fail", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        if(XtraMessageBox.Show("Login Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            //....B
                            this.Hide();
                            
                            //....
                            MainView o_MainView = new MainView();
                            o_MainView.Show();

                            this.m_oManager_Manager = null;
                        }
                    }
                }
                else if(oButton.Name == "btnJoin_Manager")
                {

                }
            }
        }

        private void chkPassShow_CheckedChanged(object sender, EventArgs e)
        {
            if      (this.chkPassShow.Checked == true)  { this.txtPassword.PasswordChar = default(char); }
            else if (this.chkPassShow.Checked == false) { this.txtPassword.PasswordChar = '*'; }
            else                                        { return; }
        }

        

        
    }
}