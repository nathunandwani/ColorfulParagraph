using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorfulParagraphControl
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorfulParagraph1.BackColor = this.BackColor;
            colorfulParagraph1.Font = new Font("Consolas", 30f, FontStyle.Bold);
            colorfulParagraph1.AppendText("C#", Color.Teal);
            colorfulParagraph1.AddSpace();
            colorfulParagraph1.AppendText("is", Color.Yellow);
            colorfulParagraph1.AddSpace();
            colorfulParagraph1.AppendText("colorful", Color.Tomato);

            KeyValuePair<string, Color> pair = colorfulParagraph1.GetTextByIndex(0);
            if (pair.Key != "") 
            {
                label1.Text = "Index 0: " + pair.Key + " (Color: " + pair.Value.Name + ")";
            }

            List<KeyValuePair<string, int>> summary = colorfulParagraph1.Summary();
            for (int i = 0; i < summary.Count; i++) 
            {
                label2.Text += summary[i].Key + ":" + summary[i].Value.ToString();
                if (i + 1 < summary.Count) label2.Text += ", ";
            }
        }
    }
}
