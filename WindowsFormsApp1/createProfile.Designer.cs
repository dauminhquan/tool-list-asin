namespace WindowsFormsApp1
{
    partial class createProfile
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
            this.tb_profile_name = new System.Windows.Forms.TextBox();
            this.lb_profile_name = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_profile_name
            // 
            this.tb_profile_name.Location = new System.Drawing.Point(121, 30);
            this.tb_profile_name.Name = "tb_profile_name";
            this.tb_profile_name.Size = new System.Drawing.Size(154, 20);
            this.tb_profile_name.TabIndex = 0;
            // 
            // lb_profile_name
            // 
            this.lb_profile_name.AutoSize = true;
            this.lb_profile_name.Location = new System.Drawing.Point(35, 33);
            this.lb_profile_name.Name = "lb_profile_name";
            this.lb_profile_name.Size = new System.Drawing.Size(67, 13);
            this.lb_profile_name.TabIndex = 1;
            this.lb_profile_name.Text = "Profile Name";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(142, 86);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // createProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 126);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lb_profile_name);
            this.Controls.Add(this.tb_profile_name);
            this.Name = "createProfile";
            this.Text = "createProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_profile_name;
        private System.Windows.Forms.Label lb_profile_name;
        private System.Windows.Forms.Button btn_ok;
    }
}