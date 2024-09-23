using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace kursovaya.Components
{
    public class Test_Button : Control
    {


        private StringFormat SF = new StringFormat();

        private bool MouseEntered = false;
        private bool MousePressed = false;

        private bool roundingEnable = false;
        public bool RoundingEnable
        {
            get => roundingEnable;
            set
            {
                roundingEnable = value;
                Refresh();
            }
        }

        private int roundingPercent = 100;
        [DisplayName("Rounding [%]")]
        [DefaultValue(100)]
        [Description("Указывает радиус закругления объекта в процентном соотношении")]
        public int Rounding
        {
            get => roundingPercent;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    roundingPercent = value;

                    Refresh();
                }
            }
        }

        public Test_Button()
        {


            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered= true;

            Size = new Size(100, 30);

            BackColor = Color.Tomato;
            ForeColor = Color.White;
            

            SF.Alignment = StringAlignment.Center; 
            SF.LineAlignment = StringAlignment.Center; 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;


            

            

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectBorderA = new Rectangle(0, 0, Width - 2, Height - 2);

           


            float roundingValue = 0.1F;
            if (RoundingEnable && roundingPercent > 0)
            {
                roundingValue = Height / 100F * roundingPercent;
            }
            GraphicsPath rectPath = Drawer.RoundedRectangle(rect, roundingValue);
            GraphicsPath rectBorder = Drawer.RoundedRectangle(rectBorderA, roundingValue);


            graph.DrawPath(new Pen(Color.DarkGray), rectPath);
            graph.FillPath(new SolidBrush(Color.White), rectPath);

            graph.SetClip(rectPath);

            if (MouseEntered)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(60, Color.Gray)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(60, Color.Gray)), rect);
            }

            if(MousePressed)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(30, Color.Black)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), rect);
            }    


            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);

            graph.DrawPath(new Pen(Color.Black), rectBorder);


        }


        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;

            Invalidate();
        }


        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = false;

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseEnter(e);
            MousePressed = true;

        Invalidate();
        }


        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseEnter(e);
            MousePressed = false;


            Invalidate();
        }


    }
}
