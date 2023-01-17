using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics myGraphic;
            myGraphic = this.CreateGraphics();


            Pen myPen1 = new Pen(System.Drawing.Color.Black, 8);
            Pen myPen2 = new Pen(System.Drawing.Color.Brown, 5);
            Pen myPen3 = new Pen(System.Drawing.Color.Green, 6);
            Pen myPen4 = new Pen(System.Drawing.Color.Red, 5);
            Pen myPen5 = new Pen(System.Drawing.Color.Yellow, 10);
            Pen myPen6 = new Pen(System.Drawing.Color.Orange, 10);
            Pen myPen7 = new Pen(System.Drawing.Color.Pink, 10);
            Pen myPen8 = new Pen(System.Drawing.Color.BlueViolet, 10);

            Pen myPen9 = new Pen(System.Drawing.Color.Orange, 11);
            //myGraphic.DrawLine(myPen1, 300, 200, 300, 200); //จุดเริ่ม จุดสิ้นสุด 
            //myGraphic.DrawRectangle(myPen1, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของสี่เหลี่ยม
            //myGraphic.DrawEllipse(myPen2, 15, 35, 170, 140); //จุดมุมบนซ้าย ความกว้าง ความสูงของกรอบสี่เหลี่ยม
            //myGraphic.DrawArc(myPen1, 100, 100, 450, 450, 0, 45); //จุดมุมบนซ้าย ความกว้าง ความสูง องศาเริ่ม องศาสิ้นสุด ตามเข็ม

            //snowman
            myGraphic.DrawEllipse(myPen1, 310, 110, 100, 100);
            myGraphic.DrawEllipse(myPen1, 290, 210, 150, 150);
            myGraphic.DrawLine(myPen1, 350, 200, 375, 200);
            //จมูก
            myGraphic.DrawLine(myPen6, 298, 190, 360, 190);
            myGraphic.DrawLine(myPen6, 360, 190, 360, 160);
            myGraphic.DrawLine(myPen6, 296, 195, 360, 160);
            //กระดุม
            myGraphic.DrawEllipse(myPen4, 356, 250, 20, 20);
            myGraphic.DrawEllipse(myPen4, 356, 300, 20, 20);
            //ตา
            myGraphic.DrawEllipse(myPen1, 330, 130, 20, 20); 
            myGraphic.DrawEllipse(myPen1, 370, 130, 20, 20); 

            //2023
            myGraphic.DrawLine(myPen5, 270, 50, 310, 50);
            myGraphic.DrawLine(myPen5, 270, 82, 310, 82);
            myGraphic.DrawLine(myPen5, 270, 105, 310, 105);
            myGraphic.DrawLine(myPen5, 310, 50, 310, 82);
            myGraphic.DrawLine(myPen5, 270, 82, 270, 105);
            myGraphic.DrawRectangle(myPen6, 337, 50, 48, 48);
            myGraphic.DrawLine(myPen7, 412, 50, 460, 50);
            myGraphic.DrawLine(myPen7, 412, 82, 460, 82);
            myGraphic.DrawLine(myPen7, 412, 105, 460, 105);
            myGraphic.DrawLine(myPen7, 457, 50, 457, 82);
            myGraphic.DrawLine(myPen7, 414, 82, 414, 105);
            myGraphic.DrawLine(myPen8, 485, 50, 535, 50);
            myGraphic.DrawLine(myPen8, 485, 82, 535, 82);
            myGraphic.DrawLine(myPen8, 485, 105, 535, 105);
            myGraphic.DrawLine(myPen8, 532, 50, 532, 105);

            //ต้นไม้
            myGraphic.DrawRectangle(myPen2, 40, 270, 80, 80);
            myGraphic.DrawLine(myPen3, 5, 165, 90, 80);
            myGraphic.DrawLine(myPen3, 90, 80, 170,170);
            myGraphic.DrawLine(myPen3,  5, 170, 170, 170);
            myGraphic.DrawLine(myPen3, 5, 265, 90, 175);
            myGraphic.DrawLine(myPen3, 160, 270, 90, 170);
            myGraphic.DrawLine(myPen3, 5, 270, 160, 270);

        }
    }
}
