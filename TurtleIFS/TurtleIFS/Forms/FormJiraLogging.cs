using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TurtleEazyCheckout.Classes;

namespace TurtleEazyCheckout.Forms
{
    public partial class FormJiraLogging : Form
    {
        public FormJiraLogging()
        {
            InitializeComponent();

            userControlJiraLogging1.OnSaveButtonClick += new UserControlJiraLogging.SaveButtonEventHandler(userControlJiraLogging1_OnSaveButtonClick);
        }

        void userControlJiraLogging1_OnSaveButtonClick(object sender, EventArgs args)
        {
            try
            {
                Authenticator.AuthenticateUser();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error logging to JIRA.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }            
    }
}
