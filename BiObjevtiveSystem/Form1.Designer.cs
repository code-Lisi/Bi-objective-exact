﻿namespace BiObjevtiveSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadData = new System.Windows.Forms.Button();
            this.Epslon = new System.Windows.Forms.Button();
            this.TwoPoleCUT_Epslon = new System.Windows.Forms.Button();
            this.EpslonCUT = new System.Windows.Forms.Button();
            this.TwoPoleCUT_EplsonCUT = new System.Windows.Forms.Button();
            this.IdeaPointCUT_EpslonCUT = new System.Windows.Forms.Button();
            this.TwoCUT_IdeaCUT_EpslonCUT = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generateData = new System.Windows.Forms.Button();
            this.geneDataTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ReadData
            // 
            this.ReadData.Location = new System.Drawing.Point(13, 58);
            this.ReadData.Name = "ReadData";
            this.ReadData.Size = new System.Drawing.Size(75, 23);
            this.ReadData.TabIndex = 0;
            this.ReadData.Text = "读数据";
            this.ReadData.UseVisualStyleBackColor = true;
            this.ReadData.Click += new System.EventHandler(this.ReadData_Click);
            // 
            // Epslon
            // 
            this.Epslon.Location = new System.Drawing.Point(13, 90);
            this.Epslon.Name = "Epslon";
            this.Epslon.Size = new System.Drawing.Size(143, 23);
            this.Epslon.TabIndex = 1;
            this.Epslon.Text = "原始Epslon";
            this.Epslon.UseVisualStyleBackColor = true;
            this.Epslon.Click += new System.EventHandler(this.Epslon_Click);
            // 
            // TwoPoleCUT_Epslon
            // 
            this.TwoPoleCUT_Epslon.Location = new System.Drawing.Point(13, 120);
            this.TwoPoleCUT_Epslon.Name = "TwoPoleCUT_Epslon";
            this.TwoPoleCUT_Epslon.Size = new System.Drawing.Size(143, 23);
            this.TwoPoleCUT_Epslon.TabIndex = 2;
            this.TwoPoleCUT_Epslon.Text = "两极点CUT+原始Epslon";
            this.TwoPoleCUT_Epslon.UseVisualStyleBackColor = true;
            this.TwoPoleCUT_Epslon.Click += new System.EventHandler(this.TwoPoleCUT_Epslon_Click);
            // 
            // EpslonCUT
            // 
            this.EpslonCUT.Location = new System.Drawing.Point(13, 150);
            this.EpslonCUT.Name = "EpslonCUT";
            this.EpslonCUT.Size = new System.Drawing.Size(143, 23);
            this.EpslonCUT.TabIndex = 3;
            this.EpslonCUT.Text = "EpslonCUT";
            this.EpslonCUT.UseVisualStyleBackColor = true;
            this.EpslonCUT.Click += new System.EventHandler(this.EpslonCUT_Click);
            // 
            // TwoPoleCUT_EplsonCUT
            // 
            this.TwoPoleCUT_EplsonCUT.Location = new System.Drawing.Point(13, 180);
            this.TwoPoleCUT_EplsonCUT.Name = "TwoPoleCUT_EplsonCUT";
            this.TwoPoleCUT_EplsonCUT.Size = new System.Drawing.Size(143, 23);
            this.TwoPoleCUT_EplsonCUT.TabIndex = 4;
            this.TwoPoleCUT_EplsonCUT.Text = "两极点CUT+EpslonCUT";
            this.TwoPoleCUT_EplsonCUT.UseVisualStyleBackColor = true;
            this.TwoPoleCUT_EplsonCUT.Click += new System.EventHandler(this.TwoPoleCUT_EplsonCUT_Click);
            // 
            // IdeaPointCUT_EpslonCUT
            // 
            this.IdeaPointCUT_EpslonCUT.Location = new System.Drawing.Point(13, 210);
            this.IdeaPointCUT_EpslonCUT.Name = "IdeaPointCUT_EpslonCUT";
            this.IdeaPointCUT_EpslonCUT.Size = new System.Drawing.Size(143, 23);
            this.IdeaPointCUT_EpslonCUT.TabIndex = 5;
            this.IdeaPointCUT_EpslonCUT.Text = "理想点CUT+EpslonCUT";
            this.IdeaPointCUT_EpslonCUT.UseVisualStyleBackColor = true;
            this.IdeaPointCUT_EpslonCUT.Click += new System.EventHandler(this.IdeaPointCUT_EpslonCUT_Click);
            // 
            // TwoCUT_IdeaCUT_EpslonCUT
            // 
            this.TwoCUT_IdeaCUT_EpslonCUT.Location = new System.Drawing.Point(13, 240);
            this.TwoCUT_IdeaCUT_EpslonCUT.Name = "TwoCUT_IdeaCUT_EpslonCUT";
            this.TwoCUT_IdeaCUT_EpslonCUT.Size = new System.Drawing.Size(199, 23);
            this.TwoCUT_IdeaCUT_EpslonCUT.TabIndex = 6;
            this.TwoCUT_IdeaCUT_EpslonCUT.Text = "两极点CUT+理想点CUT+EpslonCUT";
            this.TwoCUT_IdeaCUT_EpslonCUT.UseVisualStyleBackColor = true;
            this.TwoCUT_IdeaCUT_EpslonCUT.Click += new System.EventHandler(this.TwoCUT_IdeaCUT_EpslonCUT_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(241, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(241, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(241, 151);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(241, 181);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(241, 211);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(240, 241);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "时间/ms";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(66, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 126);
            this.panel1.TabIndex = 15;
            // 
            // generateData
            // 
            this.generateData.Location = new System.Drawing.Point(13, 24);
            this.generateData.Name = "generateData";
            this.generateData.Size = new System.Drawing.Size(75, 23);
            this.generateData.TabIndex = 16;
            this.generateData.Text = "生成数据";
            this.generateData.UseVisualStyleBackColor = true;
            this.generateData.Click += new System.EventHandler(this.generateData_Click);
            // 
            // geneDataTextBox
            // 
            this.geneDataTextBox.Location = new System.Drawing.Point(242, 24);
            this.geneDataTextBox.Name = "geneDataTextBox";
            this.geneDataTextBox.Size = new System.Drawing.Size(100, 21);
            this.geneDataTextBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 563);
            this.Controls.Add(this.geneDataTextBox);
            this.Controls.Add(this.generateData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TwoCUT_IdeaCUT_EpslonCUT);
            this.Controls.Add(this.IdeaPointCUT_EpslonCUT);
            this.Controls.Add(this.TwoPoleCUT_EplsonCUT);
            this.Controls.Add(this.EpslonCUT);
            this.Controls.Add(this.TwoPoleCUT_Epslon);
            this.Controls.Add(this.Epslon);
            this.Controls.Add(this.ReadData);
            this.Name = "Form1";
            this.Text = "BiObjevtiveSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadData;
        private System.Windows.Forms.Button Epslon;
        private System.Windows.Forms.Button TwoPoleCUT_Epslon;
        private System.Windows.Forms.Button EpslonCUT;
        private System.Windows.Forms.Button TwoPoleCUT_EplsonCUT;
        private System.Windows.Forms.Button IdeaPointCUT_EpslonCUT;
        private System.Windows.Forms.Button TwoCUT_IdeaCUT_EpslonCUT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button generateData;
        private System.Windows.Forms.TextBox geneDataTextBox;
    }
}

