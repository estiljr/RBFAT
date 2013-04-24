namespace AssetAssessmentTool
{
    partial class FormNewAsset
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
            this.txtNewAsset = new System.Windows.Forms.TextBox();
            this.lblNewAsset = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelScenario
            // 
            this.btnCancelScenario.Location = new System.Drawing.Point(332, 38);
            this.btnCancelScenario.Name = "btnCancelScenario";
            this.btnCancelScenario.Size = new System.Drawing.Size(53, 26);
            this.btnCancelScenario.TabIndex = 7;
            this.btnCancelScenario.Text = "Cancel";
            this.btnCancelScenario.UseVisualStyleBackColor = true;
            // 
            // btnOkScenario
            // 
            this.btnOkScenario.Location = new System.Drawing.Point(273, 39);
            this.btnOkScenario.Name = "btnOkScenario";
            this.btnOkScenario.Size = new System.Drawing.Size(53, 25);
            this.btnOkScenario.TabIndex = 6;
            this.btnOkScenario.Text = "OK";
            this.btnOkScenario.UseVisualStyleBackColor = true;
            // 
            // txtNewAsset
            // 
            this.txtNewAsset.Location = new System.Drawing.Point(141, 12);
            this.txtNewAsset.Name = "txtNewAsset";
            this.txtNewAsset.Size = new System.Drawing.Size(244, 20);
            this.txtNewAsset.TabIndex = 5;
            // 
            // lblNewAsset
            // 
            this.lblNewAsset.AutoSize = true;
            this.lblNewAsset.Location = new System.Drawing.Point(12, 15);
            this.lblNewAsset.Name = "lblNewAsset";
            this.lblNewAsset.Size = new System.Drawing.Size(123, 13);
            this.lblNewAsset.TabIndex = 4;
            this.lblNewAsset.Text = "Asset Subsection Name:";
            // 
            // FormNewAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 72);
            this.Controls.Add(this.btnCancelScenario);
            this.Controls.Add(this.btnOkScenario);
            this.Controls.Add(this.txtNewAsset);
            this.Controls.Add(this.lblNewAsset);
            this.Name = "FormNewAsset";
            this.Text = "New Asset Subsection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelScenario;
        private System.Windows.Forms.Button btnOkScenario;
        private System.Windows.Forms.TextBox txtNewAsset;
        private System.Windows.Forms.Label lblNewAsset;
    }
}