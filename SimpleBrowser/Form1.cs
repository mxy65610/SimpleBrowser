using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.CanGoBackChanged += WB1_CanGoBackChanged;
            webBrowser1.CanGoForwardChanged += WB1_CanGoForwardChanged;
            this.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar==(char)13)
            {
                webBrowser1.Navigate(textBox1.Text);
                
                this.Text = webBrowser1.DocumentTitle.ToString();
            }
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            webBrowser1.Navigate(webBrowser1.StatusText.ToString());
            textBox1.Text = webBrowser1.StatusText.ToString();
            this.Text = webBrowser1.DocumentTitle.ToString();
        }

        private void WB1_CanGoBackChanged(object sender,EventArgs e)
        {
            if (webBrowser1.CanGoBack == true)
                Back.Enabled = true;
            else
                Back.Enabled = false;
        }

        private void WB1_CanGoForwardChanged(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward == true)
                Forward.Enabled = true;
            else
                Forward.Enabled = false;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"www.hao123.com");

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			textBox1.Text = webBrowser1.Url.ToString();
		}
	}
}
