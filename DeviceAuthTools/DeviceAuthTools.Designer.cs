﻿namespace DeviceAuthGenerator
{
    partial class DeviceAuthTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceAuthTools));
            this.RichTextBoxLogger = new System.Windows.Forms.RichTextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonShow = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.LabelSetUserAgent = new System.Windows.Forms.Label();
            this.ButtonGetExchange = new System.Windows.Forms.Button();
            this.LabelSetClient = new System.Windows.Forms.Label();
            this.LabelSetIOSClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RichTextBoxLogger
            // 
            this.RichTextBoxLogger.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxLogger.Location = new System.Drawing.Point(12, 77);
            this.RichTextBoxLogger.Name = "RichTextBoxLogger";
            this.RichTextBoxLogger.ReadOnly = true;
            this.RichTextBoxLogger.Size = new System.Drawing.Size(776, 335);
            this.RichTextBoxLogger.TabIndex = 0;
            this.RichTextBoxLogger.Text = "";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(43, 12);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(123, 59);
            this.ButtonLogin.TabIndex = 1;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Enabled = false;
            this.ButtonCreate.Location = new System.Drawing.Point(193, 12);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(123, 59);
            this.ButtonCreate.TabIndex = 2;
            this.ButtonCreate.Text = "Create Device Auth";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonShow
            // 
            this.ButtonShow.Enabled = false;
            this.ButtonShow.Location = new System.Drawing.Point(343, 12);
            this.ButtonShow.Name = "ButtonShow";
            this.ButtonShow.Size = new System.Drawing.Size(123, 59);
            this.ButtonShow.TabIndex = 3;
            this.ButtonShow.Text = "Show Device Auths";
            this.ButtonShow.UseVisualStyleBackColor = true;
            this.ButtonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Location = new System.Drawing.Point(493, 12);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(123, 59);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "Delete Device Auth";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // LabelSetUserAgent
            // 
            this.LabelSetUserAgent.AutoSize = true;
            this.LabelSetUserAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSetUserAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.LabelSetUserAgent.Location = new System.Drawing.Point(709, 428);
            this.LabelSetUserAgent.Name = "LabelSetUserAgent";
            this.LabelSetUserAgent.Size = new System.Drawing.Size(79, 13);
            this.LabelSetUserAgent.TabIndex = 5;
            this.LabelSetUserAgent.Text = "Set User-Agent";
            this.LabelSetUserAgent.Click += new System.EventHandler(this.LabelSetUserAgent_Click);
            this.LabelSetUserAgent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelSetUserAgent_MouseDown);
            this.LabelSetUserAgent.MouseLeave += new System.EventHandler(this.LabelSetUserAgent_MouseLeave);
            this.LabelSetUserAgent.MouseHover += new System.EventHandler(this.LabelSetUserAgent_MouseHover);
            this.LabelSetUserAgent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelSetUserAgent_MouseMove);
            this.LabelSetUserAgent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelSetUserAgent_MouseUp);
            // 
            // ButtonGetExchange
            // 
            this.ButtonGetExchange.Enabled = false;
            this.ButtonGetExchange.Location = new System.Drawing.Point(641, 12);
            this.ButtonGetExchange.Name = "ButtonGetExchange";
            this.ButtonGetExchange.Size = new System.Drawing.Size(123, 59);
            this.ButtonGetExchange.TabIndex = 6;
            this.ButtonGetExchange.Text = "Get Exchange Code";
            this.ButtonGetExchange.UseVisualStyleBackColor = true;
            this.ButtonGetExchange.Click += new System.EventHandler(this.ButtonGetExchange_Click);
            // 
            // LabelSetClient
            // 
            this.LabelSetClient.AutoSize = true;
            this.LabelSetClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSetClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.LabelSetClient.Location = new System.Drawing.Point(651, 428);
            this.LabelSetClient.Name = "LabelSetClient";
            this.LabelSetClient.Size = new System.Drawing.Size(52, 13);
            this.LabelSetClient.TabIndex = 7;
            this.LabelSetClient.Text = "Set Client";
            this.LabelSetClient.Click += new System.EventHandler(this.LabelSetClient_Click);
            this.LabelSetClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelSetClient_MouseDown);
            this.LabelSetClient.MouseLeave += new System.EventHandler(this.LabelSetClient_MouseLeave);
            this.LabelSetClient.MouseHover += new System.EventHandler(this.LabelSetClient_MouseHover);
            this.LabelSetClient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelSetClient_MouseMove);
            this.LabelSetClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelSetClient_MouseUp);
            // 
            // LabelSetIOSClient
            // 
            this.LabelSetIOSClient.AutoSize = true;
            this.LabelSetIOSClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSetIOSClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.LabelSetIOSClient.Location = new System.Drawing.Point(572, 428);
            this.LabelSetIOSClient.Name = "LabelSetIOSClient";
            this.LabelSetIOSClient.Size = new System.Drawing.Size(73, 13);
            this.LabelSetIOSClient.TabIndex = 8;
            this.LabelSetIOSClient.Text = "Set IOS Client";
            this.LabelSetIOSClient.Click += new System.EventHandler(this.LabelSetIOSClient_Click);
            this.LabelSetIOSClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelSetIOSClient_MouseDown);
            this.LabelSetIOSClient.MouseHover += new System.EventHandler(this.LabelSetIOSClient_MouseHover);
            this.LabelSetIOSClient.MouseLeave += new System.EventHandler(this.LabelSetIOSClient_MouseLeave);
            this.LabelSetIOSClient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelSetIOSClient_MouseMove);
            this.LabelSetIOSClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelSetIOSClient_MouseUp);
            // 
            // DeviceAuthTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelSetIOSClient);
            this.Controls.Add(this.LabelSetClient);
            this.Controls.Add(this.ButtonGetExchange);
            this.Controls.Add(this.LabelSetUserAgent);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonShow);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.RichTextBoxLogger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeviceAuthTools";
            this.Text = "DeviceAuthTools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBoxLogger;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonShow;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label LabelSetUserAgent;
        private System.Windows.Forms.Button ButtonGetExchange;
        private System.Windows.Forms.Label LabelSetClient;
        private System.Windows.Forms.Label LabelSetIOSClient;
    }
}

