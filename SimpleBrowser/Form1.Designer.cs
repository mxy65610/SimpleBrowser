namespace SimpleBrowser
{
    partial class Form1
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
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Back = new System.Windows.Forms.Button();
			this.Forward = new System.Windows.Forms.Button();
			this.Home = new System.Windows.Forms.Button();
			this.Refresh = new System.Windows.Forms.Button();
			this.Go = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// webBrowser1
			// 
			this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.webBrowser1.Location = new System.Drawing.Point(10, 74);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(985, 704);
			this.webBrowser1.TabIndex = 0;
			this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(25, 45);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(667, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// Back
			// 
			this.Back.Location = new System.Drawing.Point(25, 4);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(75, 23);
			this.Back.TabIndex = 2;
			this.Back.Text = "后退";
			this.Back.UseVisualStyleBackColor = true;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// Forward
			// 
			this.Forward.Location = new System.Drawing.Point(133, 4);
			this.Forward.Name = "Forward";
			this.Forward.Size = new System.Drawing.Size(75, 23);
			this.Forward.TabIndex = 3;
			this.Forward.Text = "前进";
			this.Forward.UseVisualStyleBackColor = true;
			this.Forward.Click += new System.EventHandler(this.Forward_Click);
			// 
			// Home
			// 
			this.Home.Location = new System.Drawing.Point(244, 4);
			this.Home.Name = "Home";
			this.Home.Size = new System.Drawing.Size(75, 23);
			this.Home.TabIndex = 4;
			this.Home.Text = "主页";
			this.Home.UseVisualStyleBackColor = true;
			this.Home.Click += new System.EventHandler(this.Home_Click);
			// 
			// Refresh
			// 
			this.Refresh.Location = new System.Drawing.Point(355, 4);
			this.Refresh.Name = "Refresh";
			this.Refresh.Size = new System.Drawing.Size(75, 23);
			this.Refresh.TabIndex = 5;
			this.Refresh.Text = "刷新";
			this.Refresh.UseVisualStyleBackColor = true;
			this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
			// 
			// Go
			// 
			this.Go.Location = new System.Drawing.Point(749, 45);
			this.Go.Name = "Go";
			this.Go.Size = new System.Drawing.Size(75, 23);
			this.Go.TabIndex = 7;
			this.Go.Text = "前往";
			this.Go.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1007, 788);
			this.Controls.Add(this.Go);
			this.Controls.Add(this.Refresh);
			this.Controls.Add(this.Home);
			this.Controls.Add(this.Forward);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.webBrowser1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Go;
    }
}

