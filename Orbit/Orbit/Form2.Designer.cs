namespace Orbit
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoadApiKey = new System.Windows.Forms.Button();
            this.linkLabelRegisterApiKey = new System.Windows.Forms.LinkLabel();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLoadApiKey
            // 
            this.buttonLoadApiKey.Location = new System.Drawing.Point(104, 32);
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
            this.linkLabelRegisterApiKey.Location = new System.Drawing.Point(74, 69);
            this.linkLabelRegisterApiKey.Name = "linkLabelRegisterApiKey";
            this.linkLabelRegisterApiKey.Size = new System.Drawing.Size(127, 15);
            this.linkLabelRegisterApiKey.TabIndex = 3;
            this.linkLabelRegisterApiKey.TabStop = true;
            this.linkLabelRegisterApiKey.Text = "Don\'t have an API key?";
            this.linkLabelRegisterApiKey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegisterApiKey_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log into bungie on your browser BEFORE you click";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Click \"Create New App\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name can be whatever, leave website blank";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 314);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabelRegisterApiKey);
            this.Controls.Add(this.buttonLoadApiKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxApiKey);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxApiKey;
        private Label label1;
        private Button buttonLoadApiKey;
        private LinkLabel linkLabelRegisterApiKey;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}