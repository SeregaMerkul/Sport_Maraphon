 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Drawing.Text;

namespace kursovaya.Components
{
    public partial class FormDesign : Component
    {
        #region -- Свойства --

        
        public Form Form { get; set; }

        private fStyle formStyle = fStyle.None;
        public fStyle FormStyle
        {
            get => formStyle;
            set
            {
                formStyle = value;
                Sign();
            }
        }

        public enum fStyle
        {
            None,
            Test

        }
        #endregion


        #region -- Переменные --

        private int HeaderHeight = 33;
        private int titleHeight = 75;
        private int underHeight = 50;
        private Color HeaderColor = Color.DarkGray;

        private Size IconSize = new Size(18, 18);

        private StringFormat SF = new StringFormat();
        private Font Font = new Font("Arial", 8.75F, FontStyle.Regular);

        Pen WhitePen = new Pen(Color.White) { Width = 2 };

        bool MousePressed = false;
        Point clickPosition;
        Point moveStartPosition;

        Rectangle rectBtnClose = new Rectangle();

        bool btnCloseHovered = false;

       

        #endregion

        

        public FormDesign()
        {
            InitializeComponent();
        }

        public FormDesign(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        private void Sign()
        {
            if(Form != null)
            {
                Form.Load += Form_Load; 
            }
        }

        

        private void Apply()
        {

            SF.Alignment = StringAlignment.Near;
            SF.LineAlignment = StringAlignment.Center;

            Form.FormBorderStyle = FormBorderStyle.None;

            SetDoubleBuffered(Form);

            OffsetControls();

            Form.Paint += Form_Paint;
            Form.MouseDown += Form_MouseDown;
            Form.MouseUp += Form_MouseUp;
            Form.MouseMove += Form_MouseMove;
            Form.MouseLeave += Form_MouseLeave;
        }

        


        private void Form_Paint(object sender, PaintEventArgs e)
        {
            DrawStyle(e.Graphics);
        }


        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Location.Y <= HeaderHeight)
                MousePressed = true;
            clickPosition = Cursor.Position;
            moveStartPosition = Form.Location;
        }

        private void Form_MouseLeave(object sender, EventArgs e)
        {
            btnCloseHovered = false;
            Form.Invalidate();
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            MousePressed = false;

            if (e.Button == MouseButtons.Left)
            {
                if (rectBtnClose.Contains(e.Location))
                {
                    if (Form is Transactions || Form is AddResultsForm || Form is AddSponsorForm)
                    {
                        Form.Hide();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (MousePressed)
            {
                Size frmOffset = new Size(Point.Subtract(Cursor.Position, new Size(clickPosition)));
                Form.Location = Point.Add(moveStartPosition, frmOffset);
            }
            else
            {
                if (rectBtnClose.Contains(e.Location))
                {
                    if(btnCloseHovered == false)
                    {
                        btnCloseHovered = true;
                        Form.Invalidate();
                    }
                    else
                    {
                        btnCloseHovered = false;
                        Form.Invalidate();
                    }
                }
            }
        }


        private void OffsetControls()
        {
            Form.Height = Form.Height + HeaderHeight;

            foreach(Control ctrl in Form.Controls)
            {
                ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + HeaderHeight);
                ctrl.Refresh();
            }
        }

        #region -- Form Events --
        private void Form_Load(object sender, EventArgs e)
        {
            Apply();
        }
        #endregion


        private void DrawStyle(Graphics graph)
        {
            graph.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle rectHeader = new Rectangle(0, 0, Form.Width - 1, HeaderHeight);
            


            Rectangle rectTitle = new Rectangle(1, 0 + rectHeader.Height, Form.Width - 3, titleHeight);
            Rectangle rectUnder = new Rectangle(1, Form.Height - underHeight, Form.Width - 3, underHeight);

            Rectangle rectLeftBorder = new Rectangle(0, 0, 7, Form.Height - 1);
            Rectangle rectRightBorder = new Rectangle(Form.Width - 7, 0, 7, Form.Height - 1);
            Rectangle rectUnderBorder = new Rectangle(1, Form.Height - 7, Form.Width - 3, underHeight);



            Rectangle rectTitleText = new Rectangle(rectHeader.X + 28, rectHeader.Y, rectHeader.Width, rectHeader.Height);
            Rectangle rectIcon = new Rectangle(
                rectHeader.Height / 2 - IconSize.Width / 2,
                rectHeader.Height / 2 - IconSize.Height / 2,
                IconSize.Width, IconSize.Height);

            rectBtnClose = new Rectangle(rectHeader.Width - rectHeader.Height, rectHeader.Y - 1, rectHeader.Height, rectHeader.Height);
            Rectangle rectCrosshair = new Rectangle(
                rectBtnClose.X + rectBtnClose.Width / 2 - 5,
                rectBtnClose.Height / 2 - 5,
                10, 10);

            
     

            //shapka
            graph.DrawRectangle(new Pen(HeaderColor), rectHeader);
            graph.FillRectangle(new SolidBrush(HeaderColor), rectHeader);

            //Title text
            graph.DrawString(Form.Text, Font, new SolidBrush(Color.White), rectTitleText, SF);

            //Icon
            graph.DrawImage(Form.Icon.ToBitmap(), rectIcon);


            //Title
            graph.DrawRectangle(new Pen(Color.DimGray), rectTitle);
            graph.FillRectangle(new SolidBrush(Color.DimGray), rectTitle);

            //Under
            graph.DrawRectangle(new Pen(Color.DimGray), rectUnder);
            graph.FillRectangle(new SolidBrush(Color.DimGray), rectUnder);

            //obvodka
            graph.DrawRectangle(new Pen(HeaderColor), rectLeftBorder);
            graph.FillRectangle(new SolidBrush(HeaderColor), rectLeftBorder);
            graph.DrawRectangle(new Pen(HeaderColor), rectRightBorder);
            graph.FillRectangle(new SolidBrush(HeaderColor), rectRightBorder);
            graph.DrawRectangle(new Pen(HeaderColor), rectUnderBorder);
            graph.FillRectangle(new SolidBrush(HeaderColor), rectUnderBorder);

            //Close_Button
            graph.DrawRectangle(new Pen(btnCloseHovered ? Color.Red : HeaderColor), rectBtnClose);
            graph.FillRectangle(new SolidBrush(btnCloseHovered ? Color.Red : HeaderColor), rectBtnClose);
            DrawCrosshair(graph, rectCrosshair, WhitePen);

        }
        private void DrawCrosshair(Graphics graph, Rectangle rect, Pen pen)
        {
            graph.DrawLine(pen, rect.X, rect.Y, rect.X + rect.Width, rect.Y + rect.Height);
            graph.DrawLine(pen, rect.X + rect.Width, rect.Y, rect.X, rect.Y + rect.Height);
        }

        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo pDoubleBuffered =
                  typeof(Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            pDoubleBuffered.SetValue(c, true, null);
        }

    }
}
