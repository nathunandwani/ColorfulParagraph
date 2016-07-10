using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;

namespace ColorfulParagraphControl
{
    public class ColorfulParagraph : RichTextBox 
    {
        [DllImport("user32.dll")]
        private static extern int HideCaret(IntPtr hwnd);

        List<KeyValuePair<string, Color>> rtbText = new List<KeyValuePair<string, Color>>();

        public ColorfulParagraph() : this(SystemColors.Control, new Font("Microsoft Sans Serif", 12f, FontStyle.Regular)) { }

        public ColorfulParagraph(Color bgcolor) : this(bgcolor, new Font("Microsoft Sans Serif", 12f, FontStyle.Regular)) { }

        public ColorfulParagraph(Font font) : this(System.Drawing.SystemColors.Window, font) { }

        public ColorfulParagraph(Color bgcolor, Font font) 
        {
            base.Text = "";
            base.BackColor = bgcolor;
            base.Font = font;
            base.BorderStyle = BorderStyle.None;
            base.ReadOnly = true;
            base.TabStop = false;

            base.Resize += new System.EventHandler(this.ReadOnlyRichTextBox_Resize);
            base.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReadOnlyRichTextBox_Mouse);
            base.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReadOnlyRichTextBox_Mouse);
            HideCaret(base.Handle);
        }

        private void ReadOnlyRichTextBox_Mouse(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            HideCaret(this.Handle);
        }

        private void ReadOnlyRichTextBox_Resize(object sender, System.EventArgs e)
        {
            HideCaret(this.Handle);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            HideCaret(this.Handle);
        }

        protected override void OnEnter(EventArgs e)
        {
            HideCaret(this.Handle);
        }

        public new void AppendText(string text) 
        {
            this.AppendText(text, base.BackColor);
        }

        public void AppendText(string text, Color color) 
        {
            if (text == "") return;
            base.SelectionBackColor = color;
            base.AppendText(text);
            base.SelectionBackColor = base.BackColor;

            rtbText.Add(new KeyValuePair<string, Color>(text, color));
        }

        public KeyValuePair<string, Color> GetTextByIndex(int index) 
        {
            if (rtbText.Count > index)
            {
                return rtbText[index];
            }
            return new KeyValuePair<string,Color>();
        }

        public void AddSpace() 
        {
            base.SelectionBackColor = base.BackColor;
            base.AppendText(" ");
        }

        public List<KeyValuePair<string, int>> Summary() 
        {
            return rtbText.GroupBy(x => x.Value).ToDictionary(x => x.Key.Name, x => x.Count()).ToList();
        }
    }
}
