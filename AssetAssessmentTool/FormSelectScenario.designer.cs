namespace AssetAssessmentTool
{
    partial class FormSelectScenario
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
            this.btnCancelScenario = new System.Windows.Forms.Button();
            this.btnOkScenario = new System.Windows.Forms.Button();
            this.lblSelectScenario = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelScenario
            // 
            this.btnCancelScenario.Location = new System.Drawing.Point(370, 43);
            this.btnCancelScenario.Name = "btnCancelScenario";
            this.btnCancelScenario.Size = new System.Drawing.Size(53, 26);
            this.btnCancelScenario.TabIndex = 7;
            this.btnCancelScenario.Text = "Cancel";
            this.btnCancelScenario.UseVisualStyleBackColor = true;
            // 
            // btnOkScenario
            // 
            this.btnOkScenario.Location = new System.Drawing.Point(311, 44);
            this.btnOkScenario.Name = "btnOkScenario";
            this.btnOkScenario.Size = new System.Drawing.Size(53, 25);
            this.btnOkScenario.TabIndex = 6;
            this.btnOkScenario.Text = "OK";
            this.btnOkScenario.UseVisualStyleBackColor = true;
            // 
            // lblSelectScenario
            // 
            this.lblSelectScenario.AutoSize = true;
            this.lblSelectScenario.Location = new System.Drawing.Point(12, 19);
            this.lblSelectScenario.Name = "lblSelectScenario";
            this.lblSelectScenario.Size = new System.Drawing.Size(146, 13);
            this.lblSelectScenario.TabIndex = 4;
            this.lblSelectScenario.Text = "Select Water Level Scenario:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // FormSelectScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 77);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCancelScenario);
            this.Controls.Add(this.btnOkScenario);
            this.Controls.Add(this.lblSelectScenario);
            this.Name = "FormSelectScenario";
            this.Text = "Water Level Scenario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelScenario;
        private System.Windows.Forms.Button btnOkScenario;
        private System.Windows.Forms.Label lblSelectScenario;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}