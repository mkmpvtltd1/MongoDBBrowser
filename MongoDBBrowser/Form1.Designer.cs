namespace MongoDBBrowser
{
    partial class MongoDBBrowser
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
            this.Status = new System.Windows.Forms.StatusStrip();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(0, 363);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(690, 22);
            this.Status.TabIndex = 1;
            this.Status.Text = "statusStrip1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(139, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect Server";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // MongoDBBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 385);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.Status);
            this.Name = "MongoDBBrowser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.Button btnConnect;
    }
}

