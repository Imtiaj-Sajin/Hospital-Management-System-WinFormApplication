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
    public partial class ManagerUC : UserControl
    {
        public ManagerUC()
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

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {

        }

        private void receptionistButton_Click(object sender, EventArgs e)
        {
            ReceiptionistsListUC receiptionists=new ReceiptionistsListUC();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(receiptionists);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
