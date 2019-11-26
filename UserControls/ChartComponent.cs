using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An.UserControls
{
    public partial class ChartComponent : UserControl
    {
        Random random = new Random();
        public Graphics g;
        public Pen pen;
        private List<System.Drawing.PointF> PointList;
        private List<System.Drawing.PointF> SubpointList;
        private System.Drawing.PointF CentralPoint;
        private List<double> ScorePercentage;
        private List<Label> LabelList;
        public List<PointF> pointList { get => PointList; set => PointList = value; }
        public List<PointF> subpointList { get => SubpointList; set => SubpointList = value; }
        public PointF centralPoint { get => CentralPoint; set => CentralPoint = value; }
        public List<double> scorePercentage { get => ScorePercentage; set => ScorePercentage = value; }
        public List<Label> labelList { get => LabelList; set => LabelList = value; }
        public ChartComponent()
        {
            InitializeComponent();
            pen = new Pen(Color.Black);
            InitializePoint();
            panelPaint.Paint += PanelPaint_Paint;
        }
        #region Chart
        private void PanelPaint_Paint(object sender, PaintEventArgs e)
        {
            foreach (PointF point in pointList)
            {

                e.Graphics.DrawLine(pen, centralPoint.X, centralPoint.Y, point.X, point.Y);
            }

            e.Graphics.FillPolygon(new SolidBrush(Color.Orange), subpointList.ToArray(), System.Drawing.Drawing2D.FillMode.Winding);
        }

        private void InitializePoint()
        {
            RandomScore();
            pointList = new List<PointF>();
            subpointList = new List<PointF>();
            centralPoint = new PointF((panelPaint.Size.Width / 2), panelPaint.Size.Height / 2);
            PointF SubPoint = new PointF();
            labelList = new List<Label>();
            SubPoint = ConvertPoint(centralPoint);
            StackPoint(Default.Number);
        }

        private void RandomScore()
        {
            scorePercentage = new List<double>();
            int Number = (int)(Default.Number);
            for (int i = 0; i < Number; i++)
            {
                double NewNum = random.NextDouble();
                scorePercentage.Add(NewNum);
            }
        }

        private void StackPoint(double num)
        {
            double Step = 2 * Math.PI / num;
            double Angle = 0;
            for (int i = 0; i < num; i++)
            {
                PointF NewPoint = new PointF();
                NewPoint.X = (float)(centralPoint.X + Default.Distance * Math.Sin(Angle));
                NewPoint.Y = (float)(centralPoint.Y - Default.Distance * Math.Cos(Angle));
                pointList.Add(NewPoint);

                Label NewLabel = new Label();
                NewLabel.Location = new System.Drawing.Point((int)(NewPoint.X), (int)(NewPoint.Y));
                NewLabel.Text = Default.TextList[i];
                int LblX = NewLabel.Location.X;
                int LblY = NewLabel.Location.Y;
                float CenX = CentralPoint.X;
                float CenY = CentralPoint.Y;
                if (LblX <= CenX && LblX >= (LblX - Default.Distance))
                {
                    if (LblY == (CenY - Default.Distance))
                    {
                        NewLabel.Location = new System.Drawing.Point(LblX, LblY - 10);
                        NewLabel.Anchor = AnchorStyles.Top;
                    }
                    else if (LblY == CenY + Default.Distance)
                    {
                        NewLabel.Location = new System.Drawing.Point(LblX, LblY + 10);
                        NewLabel.Anchor = AnchorStyles.Bottom;
                    }
                    else
                    {
                        NewLabel.Location = new System.Drawing.Point(LblX - 60, LblY);
                        NewLabel.Anchor = AnchorStyles.Left;
                    }
                }
                else
                {
                    NewLabel.Location = new System.Drawing.Point(LblX + 10, LblY);
                    NewLabel.Anchor = AnchorStyles.Right;
                }
                NewLabel.Margin = new Padding(0, 0, 0, 0);
                NewLabel.AutoSize = true;
                labelList.Add(NewLabel);
                panelPaint.Controls.Add(NewLabel);


                PointF SubPoint = new PointF();
                double NewNum = scorePercentage[i];
                SubPoint.X = (float)(centralPoint.X + Default.Distance * NewNum * Math.Sin(Angle));
                SubPoint.Y = (float)(centralPoint.Y - Default.Distance * NewNum * Math.Cos(Angle));
                subpointList.Add(SubPoint);

                Angle += Step;
            }
        }
        private System.Drawing.PointF ConvertPoint(System.Drawing.PointF point)
        {
            System.Drawing.PointF NewPoint = new System.Drawing.PointF((float)(point.X - Default.Distance), (float)(point.Y - Default.Distance));
            return NewPoint;
        }
    }
    #endregion
}
