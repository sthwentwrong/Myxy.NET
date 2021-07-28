
namespace Myxy.NET.IdS4.Tester
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.txtTokenList = new System.Windows.Forms.TextBox();
            this.txtApiScopes = new System.Windows.Forms.TextBox();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtIdentityServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRescourceList = new System.Windows.Forms.TextBox();
            this.btnGetApi = new System.Windows.Forms.Button();
            this.txtApi = new System.Windows.Forms.TextBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAuthenticate);
            this.groupBox1.Controls.Add(this.txtTokenList);
            this.groupBox1.Controls.Add(this.txtApiScopes);
            this.groupBox1.Controls.Add(this.txtClientSecret);
            this.groupBox1.Controls.Add(this.txtClientId);
            this.groupBox1.Controls.Add(this.txtIdentityServer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(710, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ClientCredential";
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAuthenticate.Location = new System.Drawing.Point(265, 153);
            this.btnAuthenticate.Margin = new System.Windows.Forms.Padding(2);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(97, 22);
            this.btnAuthenticate.TabIndex = 9;
            this.btnAuthenticate.Text = "Authenticate";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
            // 
            // txtTokenList
            // 
            this.txtTokenList.Location = new System.Drawing.Point(366, 17);
            this.txtTokenList.Margin = new System.Windows.Forms.Padding(2);
            this.txtTokenList.Multiline = true;
            this.txtTokenList.Name = "txtTokenList";
            this.txtTokenList.Size = new System.Drawing.Size(338, 158);
            this.txtTokenList.TabIndex = 8;
            // 
            // txtApiScopes
            // 
            this.txtApiScopes.Location = new System.Drawing.Point(105, 110);
            this.txtApiScopes.Margin = new System.Windows.Forms.Padding(2);
            this.txtApiScopes.Name = "txtApiScopes";
            this.txtApiScopes.Size = new System.Drawing.Size(257, 22);
            this.txtApiScopes.TabIndex = 7;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(105, 79);
            this.txtClientSecret.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(257, 22);
            this.txtClientSecret.TabIndex = 6;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(105, 48);
            this.txtClientId.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(257, 22);
            this.txtClientId.TabIndex = 5;
            this.txtClientId.Text = "identity-server-demo-web";
            // 
            // txtIdentityServer
            // 
            this.txtIdentityServer.Location = new System.Drawing.Point(105, 17);
            this.txtIdentityServer.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdentityServer.Name = "txtIdentityServer";
            this.txtIdentityServer.Size = new System.Drawing.Size(257, 22);
            this.txtIdentityServer.TabIndex = 4;
            this.txtIdentityServer.Text = "https://localhost:8001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "API Scopes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client Secret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auth Server";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRescourceList);
            this.groupBox2.Controls.Add(this.btnGetApi);
            this.groupBox2.Controls.Add(this.txtApi);
            this.groupBox2.Controls.Add(this.txtToken);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(5, 192);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(712, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resource";
            // 
            // txtRescourceList
            // 
            this.txtRescourceList.Location = new System.Drawing.Point(368, 17);
            this.txtRescourceList.Margin = new System.Windows.Forms.Padding(2);
            this.txtRescourceList.Multiline = true;
            this.txtRescourceList.Name = "txtRescourceList";
            this.txtRescourceList.Size = new System.Drawing.Size(338, 138);
            this.txtRescourceList.TabIndex = 11;
            // 
            // btnGetApi
            // 
            this.btnGetApi.Location = new System.Drawing.Point(267, 133);
            this.btnGetApi.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetApi.Name = "btnGetApi";
            this.btnGetApi.Size = new System.Drawing.Size(97, 22);
            this.btnGetApi.TabIndex = 10;
            this.btnGetApi.Text = "Get Resource";
            this.btnGetApi.UseVisualStyleBackColor = true;
            this.btnGetApi.Click += new System.EventHandler(this.btnGetApi_Click);
            // 
            // txtApi
            // 
            this.txtApi.Location = new System.Drawing.Point(105, 48);
            this.txtApi.Margin = new System.Windows.Forms.Padding(2);
            this.txtApi.Name = "txtApi";
            this.txtApi.Size = new System.Drawing.Size(257, 22);
            this.txtApi.TabIndex = 9;
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(105, 17);
            this.txtToken.Margin = new System.Windows.Forms.Padding(2);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(257, 22);
            this.txtToken.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Resource API";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Token";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApiScopes;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtIdentityServer;
        private System.Windows.Forms.TextBox txtTokenList;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.TextBox txtApi;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGetApi;
        private System.Windows.Forms.TextBox txtRescourceList;
    }
}

