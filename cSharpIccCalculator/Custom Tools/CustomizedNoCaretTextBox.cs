using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace cSharpIccCalculator
{
    class CustomizedNoCaretTextBox : TextBox
    {
        // Import the necessary Win32 API function
        [DllImport("user32.dll")]
        private static extern IntPtr CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

        [DllImport("user32.dll")]
        private static extern void SetCaretPos(int nX, int nY);

        [DllImport("user32.dll")]
        private static extern void ShowCaret(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern void HideCaret(IntPtr hWnd);

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            HideCaret(this.Handle); // Hide the caret when the TextBox gets focus
            this.SelectionStart = this.Text.Length;  // Set cursor at the end of the text
            this.SelectionLength = 0;  // Ensure no text is highlighted
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            ShowCaret(this.Handle); // Optional: Show caret again when focus is lost
        }
    }
}
