using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon
{
    public class MyForm : Form
    {
        protected bool isMoveForm;
        protected Point pStart;

        protected void mouseDownForm(MouseEventArgs e, Form form)
        {
            isMoveForm = true;
            pStart = new Point(e.X, e.Y);
            form.Cursor = Cursors.Hand;
        }

        protected void mouseUpForm(Form form)
        {
            isMoveForm = false;
            pStart = Point.Empty;
            form.Cursor = Cursors.Default;
        }

        protected void mouseMoveForm(MouseEventArgs e, Form form)
        {
            if (isMoveForm)
            {
                form.Location = new Point(form.Left + e.X - pStart.X, form.Top + e.Y - pStart.Y);
                form.Cursor = Cursors.Hand;
            }
        }
    }
}
