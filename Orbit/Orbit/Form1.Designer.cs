namespace Orbit
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
            this.buttonCrucibleStatViewerLoad = new System.Windows.Forms.Button();
            this.buttonInventoryManagerLoad = new System.Windows.Forms.Button();
            this.buttonDestinyManifestLoad = new System.Windows.Forms.Button();
            this.buttonBungieAuth = new System.Windows.Forms.Button();
            this.buttonLoadApiKey = new System.Windows.Forms.Button();
            this.labelOrbitMultitool = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCrucibleStatViewerLoad
            // 
            this.buttonCrucibleStatViewerLoad.Enabled = false;
            this.buttonCrucibleStatViewerLoad.Location = new System.Drawing.Point(117, 157);
            this.buttonCrucibleStatViewerLoad.Name = "buttonCrucibleStatViewerLoad";
            this.buttonCrucibleStatViewerLoad.Size = new System.Drawing.Size(187, 91);
            this.buttonCrucibleStatViewerLoad.TabIndex = 0;
            this.buttonCrucibleStatViewerLoad.TabStop = false;
            this.buttonCrucibleStatViewerLoad.Text = "Crucible Statistics";
            this.buttonCrucibleStatViewerLoad.UseVisualStyleBackColor = true;
            // 
            // buttonInventoryManagerLoad
            // 
            this.buttonInventoryManagerLoad.Enabled = false;
            this.buttonInventoryManagerLoad.Location = new System.Drawing.Point(310, 109);
            this.buttonInventoryManagerLoad.Name = "buttonInventoryManagerLoad";
            this.buttonInventoryManagerLoad.Size = new System.Drawing.Size(187, 91);
            this.buttonInventoryManagerLoad.TabIndex = 0;
            this.buttonInventoryManagerLoad.TabStop = false;
            this.buttonInventoryManagerLoad.Text = "Inventory Manager";
            this.buttonInventoryManagerLoad.UseVisualStyleBackColor = true;
            // 
            // buttonDestinyManifestLoad
            // 
            this.buttonDestinyManifestLoad.Enabled = false;
            this.buttonDestinyManifestLoad.Location = new System.Drawing.Point(503, 157);
            this.buttonDestinyManifestLoad.Name = "buttonDestinyManifestLoad";
            this.buttonDestinyManifestLoad.Size = new System.Drawing.Size(187, 91);
            this.buttonDestinyManifestLoad.TabIndex = 0;
            this.buttonDestinyManifestLoad.TabStop = false;
            this.buttonDestinyManifestLoad.Text = "Destiny Manifest";
            this.buttonDestinyManifestLoad.UseVisualStyleBackColor = true;
            // 
            // buttonBungieAuth
            // 
            this.buttonBungieAuth.Enabled = false;
            this.buttonBungieAuth.Location = new System.Drawing.Point(310, 206);
            this.buttonBungieAuth.Name = "buttonBungieAuth";
            this.buttonBungieAuth.Size = new System.Drawing.Size(187, 91);
            this.buttonBungieAuth.TabIndex = 0;
            this.buttonBungieAuth.TabStop = false;
            this.buttonBungieAuth.Text = "Authorize with Bungie";
            this.buttonBungieAuth.UseVisualStyleBackColor = true;
            this.buttonBungieAuth.Click += new System.EventHandler(this.buttonBungieAuth_Click);
            // 
            // buttonLoadApiKey
            // 
            this.buttonLoadApiKey.Location = new System.Drawing.Point(310, 333);
            this.buttonLoadApiKey.Name = "buttonLoadApiKey";
            this.buttonLoadApiKey.Size = new System.Drawing.Size(187, 42);
            this.buttonLoadApiKey.TabIndex = 0;
            this.buttonLoadApiKey.TabStop = false;
            this.buttonLoadApiKey.Text = "Load API Key";
            this.buttonLoadApiKey.UseVisualStyleBackColor = true;
            this.buttonLoadApiKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelOrbitMultitool
            // 
            this.labelOrbitMultitool.AutoSize = true;
            this.labelOrbitMultitool.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOrbitMultitool.Location = new System.Drawing.Point(316, 43);
            this.labelOrbitMultitool.Name = "labelOrbitMultitool";
            this.labelOrbitMultitool.Size = new System.Drawing.Size(173, 32);
            this.labelOrbitMultitool.TabIndex = 1;
            this.labelOrbitMultitool.Text = "Orbit Multitool";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOrbitMultitool);
            this.Controls.Add(this.buttonDestinyManifestLoad);
            this.Controls.Add(this.buttonLoadApiKey);
            this.Controls.Add(this.buttonBungieAuth);
            this.Controls.Add(this.buttonInventoryManagerLoad);
            this.Controls.Add(this.buttonCrucibleStatViewerLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCrucibleStatViewerLoad;
        private Button buttonInventoryManagerLoad;
        private Button buttonDestinyManifestLoad;
        private Button buttonBungieAuth;
        private Button buttonLoadApiKey;
        private Label labelOrbitMultitool;
    }
}