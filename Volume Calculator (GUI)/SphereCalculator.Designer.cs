
namespace Volume_Calculator__GUI_
{
    partial class SphereCalculator
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
            this.labelVC = new System.Windows.Forms.Label();
            this.labelEnterRad = new System.Windows.Forms.Label();
            this.textBoxSphereRadius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelSVol = new System.Windows.Forms.Label();
            this.buttonReplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVC
            // 
            this.labelVC.AutoSize = true;
            this.labelVC.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVC.ForeColor = System.Drawing.Color.Brown;
            this.labelVC.Location = new System.Drawing.Point(233, 22);
            this.labelVC.Name = "labelVC";
            this.labelVC.Size = new System.Drawing.Size(315, 58);
            this.labelVC.TabIndex = 1;
            this.labelVC.Text = "Sphere Volume";
            this.labelVC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEnterRad
            // 
            this.labelEnterRad.AutoSize = true;
            this.labelEnterRad.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterRad.ForeColor = System.Drawing.Color.Black;
            this.labelEnterRad.Location = new System.Drawing.Point(211, 100);
            this.labelEnterRad.Name = "labelEnterRad";
            this.labelEnterRad.Size = new System.Drawing.Size(337, 33);
            this.labelEnterRad.TabIndex = 2;
            this.labelEnterRad.Text = "Enter the length of the Radius";
            this.labelEnterRad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSphereRadius
            // 
            this.textBoxSphereRadius.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSphereRadius.Location = new System.Drawing.Point(217, 136);
            this.textBoxSphereRadius.Name = "textBoxSphereRadius";
            this.textBoxSphereRadius.Size = new System.Drawing.Size(100, 40);
            this.textBoxSphereRadius.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(323, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "cm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonSubmit.Location = new System.Drawing.Point(426, 136);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(108, 41);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelSVol
            // 
            this.labelSVol.AutoSize = true;
            this.labelSVol.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSVol.ForeColor = System.Drawing.Color.Black;
            this.labelSVol.Location = new System.Drawing.Point(211, 209);
            this.labelSVol.Name = "labelSVol";
            this.labelSVol.Size = new System.Drawing.Size(0, 33);
            this.labelSVol.TabIndex = 6;
            this.labelSVol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonReplay
            // 
            this.buttonReplay.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplay.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonReplay.Location = new System.Drawing.Point(217, 251);
            this.buttonReplay.Name = "buttonReplay";
            this.buttonReplay.Size = new System.Drawing.Size(108, 41);
            this.buttonReplay.TabIndex = 7;
            this.buttonReplay.Text = "Replay";
            this.buttonReplay.UseVisualStyleBackColor = true;
            this.buttonReplay.Visible = false;
            this.buttonReplay.Click += new System.EventHandler(this.buttonReplay_Click);
            // 
            // SphereCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReplay);
            this.Controls.Add(this.labelSVol);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSphereRadius);
            this.Controls.Add(this.labelEnterRad);
            this.Controls.Add(this.labelVC);
            this.Name = "SphereCalculator";
            this.Text = "SphereCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVC;
        private System.Windows.Forms.Label labelEnterRad;
        private System.Windows.Forms.TextBox textBoxSphereRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelSVol;
        private System.Windows.Forms.Button buttonReplay;
    }
}