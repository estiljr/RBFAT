using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AssetAssessmentTool
{
    public partial class FormMain : Form
    {
        AssetToolDatabaseEntities publishContext;
        FormMain frmMain;

        public FormMain()
        {
            InitializeComponent();
            tblLoadingLocation.AllowUserToAddRows = false;
            tblAsset.AllowUserToAddRows = false;
            tblEvent.AllowUserToAddRows = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            publishContext = new AssetToolDatabaseEntities();
            defenceTypeCombo.DataSource = publishContext.tlkpAssetTypes.ToList();
            defenceTypeCombo.DisplayMember = "Description";

            conditionGradeCombo.DataSource = publishContext.tlkpConditionGrades.ToList();
            conditionGradeCombo.DisplayMember = "ConditionGrade";

            PopulateDataGridView();           
        }

        private void PopulateDataGridView()
        {
            unitComboBox.Items.Insert(0,"Metric");
            unitComboBox.Items.Insert(1, "American");
            unitComboBox.SelectedIndex = 0;

            genericRadioButton.Checked = true;

            string[] dataGridView5_row0 = {"45.00", "46.50" };
            string[] dataGridView5_row1 = {"46.00", "47.50" };

            string[] dataGridView6_row0 = { "43.00", "43.50" };
            string[] dataGridView6_row1 = { "44.00", "44.50" };
            
            tblEventSetting[2, 0].Value = "45.00";
            tblEventSetting[3, 0].Value = "1%";
            tblEventSetting[4, 0].Value = "75%";

            colDefenceSubsection.Items.Add("Levee Section 1");
            colDefenceSubsection.Items.Add("Levee Section 2");
            colFailureMode.Items.Add("Breaching");
            colFailureMode.Items.Add("Overtopping");

            tblRiskRun.Rows.Add("1", "", "12:00", "Scenario 1", "1", "3100");
            tblEventsSummary.Rows.Insert(0, "1", "Depth Grid Result", @"C:\Projects\Levee\FloodMap01.asc", "1500");
            tblEventsSummary.Rows.Insert(1, "2", "Constant Water Level", @"C:\Projects\Levee\FloodMap02.asc", "1600");

            tblRiskResult.Rows.Add("Levee Section 1", "1400", "1500", "1600", "45%");
            tblRiskResult.Rows.Add("Levee Section 2", "1500", "1600", "1700", "55%");        
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            switch (btnShowDetails.Text)
            {
                case "Show Details >>":
                    tblEventsSummary.Visible = true;
                    btnShowDetails.Text = "Hide Details <<";
                    break;
                case "Hide Details <<":
                    tblEventsSummary.Visible = false;
                    btnShowDetails.Text = "Show Details >>";
                    break;
            }
        }
        
        private void showEventDetailsButton_Click(object sender, EventArgs e)
        {
            switch (btnShowEventDetails.Text)
            {
                case "Show Event Details >>":
                    tblEventSetting.Visible = true;
                    btnShowEventDetails.Text = "Hide Event Details <<";
                    break;
                case "Hide Event Details <<":
                    tblEventSetting.Visible = false;
                    btnShowEventDetails.Text = "Show Event Details >>";
                    break;
            }
        }

        private void btnShowEventDetails_Click_1(object sender, EventArgs e)
        {
            switch (btnShowEventDetails.Text)
            {
                case "Show Event Details >>":
                    tblEventSetting.Visible = true;
                    btnShowEventDetails.Text = "Hide Event Details <<";
                    break;
                case "Hide Event Details <<":
                    tblEventSetting.Visible = false;
                    btnShowEventDetails.Text = "Show Event Details >>";
                    break;
            }
        }

        private void btnAddLevelLoadingPoint_Click(object sender, EventArgs e)
        {
            tblLoadingLocation.Rows.Add();
            /*
            string[] dataGridView2_row0 = { "5", "20%", "22.25", "22.50", "22.60" };
            string[] dataGridView2_row1 = { "20", "5%", "22.50", "22.60", "23.25" };
            string[] dataGridView2_row2 = { "75", "1.33%", "22.90", "23.50", "23.75" };
            dgvWaterLevelLoading.Rows.Add(dataGridView2_row0);
            dgvWaterLevelLoading.Rows.Add(dataGridView2_row1);
            dgvWaterLevelLoading.Rows.Add(dataGridView2_row2);
            */
           pbxWaterLevel.Visible = true;
        }

        private void btnRemoveLvlLoadPnt_Click(object sender, EventArgs e)
        {
            if (tblLoadingLocation.RowCount > 0)
                tblLoadingLocation.Rows.RemoveAt(0);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDefence_Click(object sender, EventArgs e)
        {
            FormNewAsset frmNewAsset = new FormNewAsset();
            frmNewAsset.StartPosition = FormStartPosition.CenterParent;
            frmNewAsset.ShowDialog(frmMain);
            
            string[] dataGridView1_row0 = { "1", "Levee Section 1" };
            string[] dataGridView1_row1 = { "2", "Levee Section 2" };
            tblAsset.Rows.Add(dataGridView1_row0);
            //dgvAssetTable.Rows.Add(dataGridView1_row1);

            pbxFragilityCurve.Visible = true;
        }

        private void btnRemoveDefence_Click(object sender, EventArgs e)
        {
            if (tblAsset.RowCount > 0)
                tblAsset.Rows.RemoveAt(0);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            FormScenario frmScenario = new FormScenario();
            frmScenario.StartPosition = FormStartPosition.CenterParent;
            frmScenario.ShowDialog(frmMain);
        }

        private void btnGenerateEvents_Click(object sender, EventArgs e)
        {
            FormSelectScenario frmSelectScenario = new FormSelectScenario();
            frmSelectScenario.StartPosition = FormStartPosition.CenterParent;
            frmSelectScenario.ShowDialog(frmMain);
        }

        private void btnRunAnalysis_Click(object sender, EventArgs e)
        {
            FormRun frmRun = new FormRun();
            frmRun.StartPosition = FormStartPosition.CenterParent;
            frmRun.ShowDialog(frmMain);
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            tblEvent.Rows.Add();
            tblEvent[0, 0].Value = "1";
            colTypeOfOutput.Items.Insert(0, "Depth Grid Result");
            colTypeOfOutput.Items.Insert(1, "Fixed Water Level");

            tblEvent[3, 0].Value = @"C:\Projects\Levee\FloodMap01.asc";
            tblEvent[4, 0].Value = "1500";
            tblEvent[5, 0].Value = true;
        }
    }
}
