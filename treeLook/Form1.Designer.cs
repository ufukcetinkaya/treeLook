﻿namespace treeLook
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
            this.logText = new System.Windows.Forms.RichTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btDonus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logText
            // 
            this.logText.Location = new System.Drawing.Point(12, 12);
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(776, 106);
            this.logText.TabIndex = 0;
            this.logText.Text = "";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 153);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(775, 294);
            this.treeView1.TabIndex = 1;
            // 
            // btDonus
            // 
            this.btDonus.Location = new System.Drawing.Point(363, 124);
            this.btDonus.Name = "btDonus";
            this.btDonus.Size = new System.Drawing.Size(75, 23);
            this.btDonus.TabIndex = 2;
            this.btDonus.Text = "Donustur";
            this.btDonus.UseVisualStyleBackColor = true;
            this.btDonus.Click += new System.EventHandler(this.BtDonus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDonus);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.logText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox logText;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btDonus;
    }
}

