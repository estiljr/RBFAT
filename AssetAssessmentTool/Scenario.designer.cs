namespace AssetAssessmentTool
{
    partial class FormScenario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblScenarioName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOkScenario = new System.Windows.Forms.Button();
            this.btnCancelScenario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScenarioName
            // 
            this.lblScenarioName.AutoSize = true;
            this.lblScenarioName.Location = new System.Drawing.Point(12, 18);
            this.lblScenarioName.Name = "lblScenarioName";
            this.lblScenarioName.Size = new System.Drawing.Size(83, 13);
            this.lblScenarioName.TabIndex = 0;
            this.lblScenarioName.Text = "Scenario Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnOkScenario
            // 
            this.btnOkScenario.Location = new System.Drawing.Point(240, 42);
            this.btnOkScenario.Name = "btnOkScenario";
            this.btnOkScenario.Size = new System.Drawing.Size(53, 25);
            this.btnOkScenario.TabIndex = 2;
            this.btnOkScenario.Text = "OK";
            this.btnOkScenario.UseVisualStyleBackColor = true;
            // 
            // btnCancelScenario
            // 
            this.btnCancelScenario.Location = new System.Drawing.Point(299, 41);
            this.btnCancelScenario.Name = "btnCancelScenario";
            this.btnCancelScenario.Size = new System.Drawing.Size(53, 26);
            this.btnCancelScenario.TabIndex = 3;
            this.btnCancelScenario.Text = "Cancel";
            this.btnCancelScenario.UseVisualStyleBackColor = true;
            // 
            // FormScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 71);
            this.Controls.Add(this.btnCancelScenario);
            this.Controls.Add(this.btnOkScenario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblScenarioName);
            this.Name = "FormScenario";
            this.Text = " New Scenario";
            this.Load += new System.EventHandler(this.frmScenario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScenarioName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOkScenario;
        private System.Windows.Forms.Button btnCancelScenario;
    }
}