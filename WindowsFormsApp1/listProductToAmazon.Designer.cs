namespace ListProductToAmazon
{
    partial class listProductToAmazon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listProductToAmazon));
            this.btn_start = new System.Windows.Forms.Button();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_time_sleep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_handing_time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_length_listed = new System.Windows.Forms.Label();
            this.btn_load_profile = new System.Windows.Forms.Button();
            this.btn_load_asin = new System.Windows.Forms.Button();
            this.lbl_length_product_find = new System.Windows.Forms.Label();
            this.btn_create_profile = new System.Windows.Forms.Button();
            this.lb_profile_name = new System.Windows.Forms.Label();
            this.lb_find_profile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 35);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(140, 99);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Bắt đầu";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(218, 52);
            this.tb_quantity.MaxLength = 4;
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(100, 20);
            this.tb_quantity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity";
            // 
            // tb_time_sleep
            // 
            this.tb_time_sleep.Location = new System.Drawing.Point(394, 91);
            this.tb_time_sleep.MaxLength = 4;
            this.tb_time_sleep.Name = "tb_time_sleep";
            this.tb_time_sleep.Size = new System.Drawing.Size(164, 20);
            this.tb_time_sleep.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thời gian chuyển mỗi SP";
            // 
            // tb_handing_time
            // 
            this.tb_handing_time.Location = new System.Drawing.Point(500, 51);
            this.tb_handing_time.Name = "tb_handing_time";
            this.tb_handing_time.Size = new System.Drawing.Size(100, 20);
            this.tb_handing_time.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Handling Time";
            // 
            // lb_length_listed
            // 
            this.lb_length_listed.AutoSize = true;
            this.lb_length_listed.Location = new System.Drawing.Point(466, 136);
            this.lb_length_listed.Name = "lb_length_listed";
            this.lb_length_listed.Size = new System.Drawing.Size(145, 13);
            this.lb_length_listed.TabIndex = 8;
            this.lb_length_listed.Text = "Chưa sản phẩm nào được list";
            // 
            // btn_load_profile
            // 
            this.btn_load_profile.Location = new System.Drawing.Point(218, 9);
            this.btn_load_profile.Name = "btn_load_profile";
            this.btn_load_profile.Size = new System.Drawing.Size(75, 23);
            this.btn_load_profile.TabIndex = 9;
            this.btn_load_profile.Text = "Load Profile";
            this.btn_load_profile.UseVisualStyleBackColor = true;
            this.btn_load_profile.Click += new System.EventHandler(this.Btn_load_profile_Click);
            // 
            // btn_load_asin
            // 
            this.btn_load_asin.Location = new System.Drawing.Point(407, 9);
            this.btn_load_asin.Name = "btn_load_asin";
            this.btn_load_asin.Size = new System.Drawing.Size(75, 23);
            this.btn_load_asin.TabIndex = 10;
            this.btn_load_asin.Text = "Load Asin";
            this.btn_load_asin.UseVisualStyleBackColor = true;
            this.btn_load_asin.Click += new System.EventHandler(this.Btn_load_asin_Click);
            // 
            // lbl_length_product_find
            // 
            this.lbl_length_product_find.AutoSize = true;
            this.lbl_length_product_find.Location = new System.Drawing.Point(488, 14);
            this.lbl_length_product_find.Name = "lbl_length_product_find";
            this.lbl_length_product_find.Size = new System.Drawing.Size(126, 13);
            this.lbl_length_product_find.TabIndex = 11;
            this.lbl_length_product_find.Text = "Không tìm thấy sản phẩm";
            // 
            // btn_create_profile
            // 
            this.btn_create_profile.Location = new System.Drawing.Point(311, 9);
            this.btn_create_profile.Name = "btn_create_profile";
            this.btn_create_profile.Size = new System.Drawing.Size(90, 23);
            this.btn_create_profile.TabIndex = 12;
            this.btn_create_profile.Text = "Tạo mới profile";
            this.btn_create_profile.UseVisualStyleBackColor = true;
            this.btn_create_profile.Click += new System.EventHandler(this.Btn_create_profile_Click);
            // 
            // lb_profile_name
            // 
            this.lb_profile_name.AutoSize = true;
            this.lb_profile_name.Location = new System.Drawing.Point(12, 9);
            this.lb_profile_name.Name = "lb_profile_name";
            this.lb_profile_name.Size = new System.Drawing.Size(76, 13);
            this.lb_profile_name.TabIndex = 13;
            this.lb_profile_name.Text = "Profile Name...";
            // 
            // lb_find_profile
            // 
            this.lb_find_profile.AutoSize = true;
            this.lb_find_profile.Location = new System.Drawing.Point(105, 9);
            this.lb_find_profile.Name = "lb_find_profile";
            this.lb_find_profile.Size = new System.Drawing.Size(87, 13);
            this.lb_find_profile.TabIndex = 14;
            this.lb_find_profile.Text = "Tìm thấy 0 profile";
            // 
            // listProductToAmazon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 170);
            this.Controls.Add(this.lb_find_profile);
            this.Controls.Add(this.lb_profile_name);
            this.Controls.Add(this.btn_create_profile);
            this.Controls.Add(this.lbl_length_product_find);
            this.Controls.Add(this.btn_load_asin);
            this.Controls.Add(this.btn_load_profile);
            this.Controls.Add(this.lb_length_listed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_handing_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_time_sleep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.btn_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "listProductToAmazon";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_time_sleep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_handing_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_length_listed;
        private System.Windows.Forms.Button btn_load_profile;
        private System.Windows.Forms.Button btn_load_asin;
        private System.Windows.Forms.Label lbl_length_product_find;
        private System.Windows.Forms.Button btn_create_profile;
        private System.Windows.Forms.Label lb_profile_name;
        private System.Windows.Forms.Label lb_find_profile;
    }
}

