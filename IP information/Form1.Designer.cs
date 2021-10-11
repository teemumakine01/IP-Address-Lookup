
namespace IP_information
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_IP = new System.Windows.Forms.TextBox();
            this.button1_start = new System.Windows.Forms.Button();
            this.label_C = new System.Windows.Forms.Label();
            this.label_Country = new System.Windows.Forms.Label();
            this.label_Region = new System.Windows.Forms.Label();
            this.label3_Region = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label4_City = new System.Windows.Forms.Label();
            this.label_Zip = new System.Windows.Forms.Label();
            this.label5_Zip = new System.Windows.Forms.Label();
            this.label_ISP = new System.Windows.Forms.Label();
            this.label6_ISP = new System.Windows.Forms.Label();
            this.label_ORG = new System.Windows.Forms.Label();
            this.label2_ORG = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type IP Address:";
            // 
            // textBox1_IP
            // 
            this.textBox1_IP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_IP.Location = new System.Drawing.Point(12, 29);
            this.textBox1_IP.Name = "textBox1_IP";
            this.textBox1_IP.Size = new System.Drawing.Size(420, 23);
            this.textBox1_IP.TabIndex = 1;
            this.textBox1_IP.Text = "Search for an IP address";
            // 
            // button1_start
            // 
            this.button1_start.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_start.Location = new System.Drawing.Point(12, 60);
            this.button1_start.Name = "button1_start";
            this.button1_start.Size = new System.Drawing.Size(75, 23);
            this.button1_start.TabIndex = 2;
            this.button1_start.Text = "Search";
            this.button1_start.UseVisualStyleBackColor = true;
            this.button1_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_C.Location = new System.Drawing.Point(12, 116);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(53, 15);
            this.label_C.TabIndex = 3;
            this.label_C.Text = "Country:";
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Country.Location = new System.Drawing.Point(108, 116);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(12, 15);
            this.label_Country.TabIndex = 4;
            this.label_Country.Text = "-";
            // 
            // label_Region
            // 
            this.label_Region.AutoSize = true;
            this.label_Region.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Region.Location = new System.Drawing.Point(12, 161);
            this.label_Region.Name = "label_Region";
            this.label_Region.Size = new System.Drawing.Size(47, 15);
            this.label_Region.TabIndex = 5;
            this.label_Region.Text = "Region:";
            // 
            // label3_Region
            // 
            this.label3_Region.AutoSize = true;
            this.label3_Region.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_Region.Location = new System.Drawing.Point(108, 161);
            this.label3_Region.Name = "label3_Region";
            this.label3_Region.Size = new System.Drawing.Size(12, 15);
            this.label3_Region.TabIndex = 6;
            this.label3_Region.Text = "-";
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_City.Location = new System.Drawing.Point(12, 210);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(31, 15);
            this.label_City.TabIndex = 7;
            this.label_City.Text = "City:";
            this.label_City.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4_City
            // 
            this.label4_City.AutoSize = true;
            this.label4_City.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4_City.Location = new System.Drawing.Point(108, 210);
            this.label4_City.Name = "label4_City";
            this.label4_City.Size = new System.Drawing.Size(12, 15);
            this.label4_City.TabIndex = 8;
            this.label4_City.Text = "-";
            // 
            // label_Zip
            // 
            this.label_Zip.AutoSize = true;
            this.label_Zip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Zip.Location = new System.Drawing.Point(12, 259);
            this.label_Zip.Name = "label_Zip";
            this.label_Zip.Size = new System.Drawing.Size(27, 15);
            this.label_Zip.TabIndex = 9;
            this.label_Zip.Text = "Zip:";
            // 
            // label5_Zip
            // 
            this.label5_Zip.AutoSize = true;
            this.label5_Zip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_Zip.Location = new System.Drawing.Point(108, 259);
            this.label5_Zip.Name = "label5_Zip";
            this.label5_Zip.Size = new System.Drawing.Size(12, 15);
            this.label5_Zip.TabIndex = 10;
            this.label5_Zip.Text = "-";
            // 
            // label_ISP
            // 
            this.label_ISP.AutoSize = true;
            this.label_ISP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ISP.Location = new System.Drawing.Point(12, 310);
            this.label_ISP.Name = "label_ISP";
            this.label_ISP.Size = new System.Drawing.Size(26, 15);
            this.label_ISP.TabIndex = 11;
            this.label_ISP.Text = "ISP:";
            // 
            // label6_ISP
            // 
            this.label6_ISP.AutoSize = true;
            this.label6_ISP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_ISP.Location = new System.Drawing.Point(108, 310);
            this.label6_ISP.Name = "label6_ISP";
            this.label6_ISP.Size = new System.Drawing.Size(12, 15);
            this.label6_ISP.TabIndex = 12;
            this.label6_ISP.Text = "-";
            // 
            // label_ORG
            // 
            this.label_ORG.AutoSize = true;
            this.label_ORG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ORG.Location = new System.Drawing.Point(12, 354);
            this.label_ORG.Name = "label_ORG";
            this.label_ORG.Size = new System.Drawing.Size(34, 15);
            this.label_ORG.TabIndex = 13;
            this.label_ORG.Text = "ORG:";
            // 
            // label2_ORG
            // 
            this.label2_ORG.AutoSize = true;
            this.label2_ORG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_ORG.Location = new System.Drawing.Point(108, 354);
            this.label2_ORG.Name = "label2_ORG";
            this.label2_ORG.Size = new System.Drawing.Size(12, 15);
            this.label2_ORG.TabIndex = 14;
            this.label2_ORG.Text = "-";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(352, 383);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 15);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "tprojects.me";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 409);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2_ORG);
            this.Controls.Add(this.label_ORG);
            this.Controls.Add(this.label6_ISP);
            this.Controls.Add(this.label_ISP);
            this.Controls.Add(this.label5_Zip);
            this.Controls.Add(this.label_Zip);
            this.Controls.Add(this.label4_City);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.label3_Region);
            this.Controls.Add(this.label_Region);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.label_C);
            this.Controls.Add(this.button1_start);
            this.Controls.Add(this.textBox1_IP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IP Address Lookup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_IP;
        private System.Windows.Forms.Button button1_start;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.Label label_Region;
        private System.Windows.Forms.Label label3_Region;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label4_City;
        private System.Windows.Forms.Label label_Zip;
        private System.Windows.Forms.Label label5_Zip;
        private System.Windows.Forms.Label label_ISP;
        private System.Windows.Forms.Label label6_ISP;
        private System.Windows.Forms.Label label_ORG;
        private System.Windows.Forms.Label label2_ORG;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

