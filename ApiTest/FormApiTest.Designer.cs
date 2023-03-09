namespace ApiTest
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
            this.lblApiResponse = new System.Windows.Forms.Label();
            this.lblApiListResponse = new System.Windows.Forms.Label();
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
            // lblApiResponse
            // 
            this.lblApiResponse.AutoSize = true;
            this.lblApiResponse.Location = new System.Drawing.Point(356, 142);
            this.lblApiResponse.Name = "lblApiResponse";
            this.lblApiResponse.Size = new System.Drawing.Size(73, 13);
            this.lblApiResponse.TabIndex = 1;
            this.lblApiResponse.Text = "Api Response";
            this.lblApiResponse.Click += new System.EventHandler(this.lblApiResponseClick);
            // 
            // lblApiListResponse
            // 
            this.lblApiListResponse.AutoSize = true;
            this.lblApiListResponse.Location = new System.Drawing.Point(356, 203);
            this.lblApiListResponse.Name = "lblApiListResponse";
            this.lblApiListResponse.Size = new System.Drawing.Size(92, 13);
            this.lblApiListResponse.TabIndex = 1;
            this.lblApiListResponse.Text = "Api List Response";
            this.lblApiListResponse.Click += new System.EventHandler(this.lblApiListResponseClick);
            // 
            // FormApiTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblApiListResponse);
            this.Controls.Add(this.lblApiResponse);
            this.Controls.Add(this.BtnApiResponse);
            this.Name = "FormApiTest";
            this.Text = "ApiTest";
            this.Load += new System.EventHandler(this.FormApiTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnApiResponse;
        private System.Windows.Forms.Label lblApiResponse;
        private System.Windows.Forms.Label lblApiListResponse;
    }
}

