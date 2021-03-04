using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linter_Amanda
{
    public class Highlighting
    {
        public void Highlighter(MatchCollection matchCollection, Color color, RichTextBox richTextBox )
        {
            foreach (Match item in matchCollection)
            {
                richTextBox.SelectionStart = item.Index;
                richTextBox.SelectionLength = item.Length;
                richTextBox.SelectionColor = color;
            }
        }
    }
}
