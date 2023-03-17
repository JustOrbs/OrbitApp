namespace Orbit
{
    partial class InitializeAPI
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
            this.textBoxApiKey = new System.Windows.Forms.TextBox();
            this.labelApiKey = new System.Windows.Forms.Label();
            this.buttonLoadApiKey = new System.Windows.Forms.Button();
            this.linkLabelRegisterApiKey = new System.Windows.Forms.LinkLabel();
            this.labelClientId = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxApiKey
            // 
            this.textBoxApiKey.Location = new System.Drawing.Point(89, 3);
            this.textBoxApiKey.Name = "textBoxApiKey";
            this.textBoxApiKey.Size = new System.Drawing.Size(178, 23);
            this.textBoxApiKey.TabIndex = 0;
            // 
            // labelApiKey
            // 
            this.labelApiKey.AutoSize = true;
            this.labelApiKey.Location = new System.Drawing.Point(36, 6);
            this.labelApiKey.Name = "labelApiKey";
            this.labelApiKey.Size = new System.Drawing.Size(47, 15);
            this.labelApiKey.TabIndex = 1;
            this.labelApiKey.Text = "API Key";
            // 
            // buttonLoadApiKey
            // 
            this.buttonLoadApiKey.Location = new System.Drawing.Point(102, 103);
            this.buttonLoadApiKey.Name = "buttonLoadApiKey";
            this.buttonLoadApiKey.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadApiKey.TabIndex = 2;
            this.buttonLoadApiKey.Text = "Load";
            this.buttonLoadApiKey.UseVisualStyleBackColor = true;
            this.buttonLoadApiKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabelRegisterApiKey
            // 
            this.linkLabelRegisterApiKey.AutoSize = true;
            this.linkLabelRegisterApiKey.Location = new System.Drawing.Point(74, 138);
            this.linkLabelRegisterApiKey.Name = "linkLabelRegisterApiKey";
            this.linkLabelRegisterApiKey.Size = new System.Drawing.Size(127, 15);
            this.linkLabelRegisterApiKey.TabIndex = 3;
            this.linkLabelRegisterApiKey.TabStop = true;
            this.linkLabelRegisterApiKey.Text = "Don\'t have an API key?";
            this.linkLabelRegisterApiKey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegisterApiKey_LinkClicked);
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(31, 39);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(52, 15);
            this.labelClientId.TabIndex = 4;
            this.labelClientId.Text = "Client ID";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(89, 36);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(178, 23);
            this.textBoxClientId.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Make sure to set redirect url to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "https://justorbs.github.io";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "And set scopes to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Read D2 info and Move/Equip";
            // 
            // InitializeAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 314);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.labelClientId);
            this.Controls.Add(this.linkLabelRegisterApiKey);
            this.Controls.Add(this.buttonLoadApiKey);
            this.Controls.Add(this.labelApiKey);
            this.Controls.Add(this.textBoxApiKey);
            this.Name = "InitializeAPI";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxApiKey;
        private Label labelApiKey;
        private Button buttonLoadApiKey;
        private LinkLabel linkLabelRegisterApiKey;
        private Label labelClientId;
        private TextBox textBoxClientId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}