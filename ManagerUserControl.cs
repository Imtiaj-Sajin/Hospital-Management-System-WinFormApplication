using HospitalManagementSystem.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ManagerUserControl : UserControl
    {
        public ManagerUserControl()
        {
            InitializeComponent();
            
        }

        private void doctorsButton_Click(object sender, EventArgs e)
        {
            DoctorsListUserControl doctorsListControl = new DoctorsListUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(doctorsListControl);
        }

        private void patientsButton_Click(object sender, EventArgs e)
        {
            PatientsListUC patientsListUC = new PatientsListUC();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(patientsListUC);
        }
    }
}
