﻿namespace ApiTest
{
    partial class FormApiTest
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
            this.BtnApiResponse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnApiResponse
            // 
            this.BtnApiResponse.Location = new System.Drawing.Point(324, 59);
            this.BtnApiResponse.Name = "BtnApiResponse";
            this.BtnApiResponse.Size = new System.Drawing.Size(149, 41);
            this.BtnApiResponse.TabIndex = 0;
            this.BtnApiResponse.Text = "Get Api Response";
            this.BtnApiResponse.UseVisualStyleBackColor = true;
            this.BtnApiResponse.Click += new System.EventHandler(this.BtnApiResponse_Click);
            // 
            // FormApiTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnApiResponse);
            this.Name = "FormApiTest";
            this.Text = "ApiTest";
            this.Load += new System.EventHandler(this.FormApiTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnApiResponse;
    }
}

