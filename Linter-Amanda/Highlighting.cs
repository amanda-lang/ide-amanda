using System.Drawing;
using System.Text.RegularExpressions;
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
