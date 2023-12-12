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
    public partial class ReceiptionistUC : UserControl
    {
        public ReceiptionistUC()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void doctorsButton_Click(object sender, EventArgs e)
        {
            DoctorsListUserControl doctorsListControl = new DoctorsListUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(doctorsListControl);
            doctorsListControl.crudPanel.Dispose();
        }

        private void patientEntryButton_Click(object sender, EventArgs e)
        {
           PatientEntryUC patientEntryUC = new PatientEntryUC();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add( patientEntryUC);
        }

        private void patientQueueBtn_Click(object sender, EventArgs e)
        {
            PatientQueueUC patientQueueUC = new PatientQueueUC();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(patientQueueUC);
        }

        private void patientSumBtn_Click(object sender, EventArgs e)
        {
            PatientSummaryUC patientSummaryUC = new PatientSummaryUC();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(patientSummaryUC);
        }
    }
}
