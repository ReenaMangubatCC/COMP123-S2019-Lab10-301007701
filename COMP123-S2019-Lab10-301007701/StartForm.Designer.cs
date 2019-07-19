namespace COMP123_S2019_Lab10_301007701
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            this.StartLabel = new System.Windows.Forms.Label();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.StartLabel.Location = new System.Drawing.Point(225, 196);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(373, 39);
            this.StartLabel.TabIndex = 0;
            this.StartLabel.Text = "Welcome to Start Form!";
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.StartLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Timer SplashTimer;
    }
}