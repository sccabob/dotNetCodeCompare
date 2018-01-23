namespace CSharp_sqlServer_Connection
{
    partial class frmGetCSharpData
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
            this.cmdPress = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.cmdShowCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdPress
            // 
            this.cmdPress.Location = new System.Drawing.Point(449, 399);
            this.cmdPress.Name = "cmdPress";
            this.cmdPress.Size = new System.Drawing.Size(102, 23);
            this.cmdPress.TabIndex = 0;
            this.cmdPress.Text = "Get Data";
            this.cmdPress.UseVisualStyleBackColor = true;
            this.cmdPress.Click += new System.EventHandler(this.cmdPress_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(539, 381);
            this.txtDisplay.TabIndex = 1;
            // 
            // cmdShowCode
            // 
            this.cmdShowCode.Location = new System.Drawing.Point(449, 428);
            this.cmdShowCode.Name = "cmdShowCode";
            this.cmdShowCode.Size = new System.Drawing.Size(102, 23);
            this.cmdShowCode.TabIndex = 5;
            this.cmdShowCode.Text = "Show Code";
            this.cmdShowCode.UseVisualStyleBackColor = true;
            this.cmdShowCode.Click += new System.EventHandler(this.cmdShowCode_Click);
            // 
            // frmGetCSharpData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 459);
            this.Controls.Add(this.cmdShowCode);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.cmdPress);
            this.Name = "frmGetCSharpData";
            this.Text = "C#.net Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPress;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button cmdShowCode;
    }
}

