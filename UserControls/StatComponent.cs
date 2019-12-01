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
    public partial class StatsComponent : UserControl
    {
        public Graphics g;
        public Pen pen;
        private List<System.Drawing.PointF> PointList;
        private List<System.Drawing.PointF> SubpointList;
        private System.Drawing.PointF CentralPoint;
        //private List<double> ScorePercentage; //To Column Score
        private List<Label> LabelList;
        TTDStatsData ScoresData;
        double Max;
        DataTable Scores;
        public List<PointF> pointList { get => PointList; set => PointList = value; }
        public List<PointF> subpointList { get => SubpointList; set => SubpointList = value; }
        public PointF centralPoint { get => CentralPoint; set => CentralPoint = value; }
        //public List<double> scorePercentage { get => ScorePercentage; set => ScorePercentage = value; }
        public List<Label> labelList { get => LabelList; set => LabelList = value; }
        public StatsComponent(String TTDID,double Max)
        {
            ScoresData = new TTDStatsData();
            Scores = ScoresData.ReadScoreForTTD(TTDID);
            if (Scores.Rows.Count == 0)
            {
                MessageBox.Show("Data Invalid. Please insert data", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Max = Max;
            InitializeComponent();
            pen = new Pen(Color.Black);
            InitializePoint();
            panelPaint.Paint += PanelPaint_Paint;
        }
        private StatsComponent()
        {

            InitializeComponent();
            pen = new Pen(Color.FromArgb(30,Color.DarkGray));
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
            Brush x = new SolidBrush(Color.FromArgb(100, Color.Red)) ;
            e.Graphics.FillPolygon(x, subpointList.ToArray(), System.Drawing.Drawing2D.FillMode.Winding);
            x.Dispose();
        }

        private void InitializePoint()
        {
            pointList = new List<PointF>();
            subpointList = new List<PointF>();
            centralPoint = new PointF((panelPaint.Size.Width / 2), panelPaint.Size.Height / 2);
            //PointF SubPoint = new PointF();
            labelList = new List<Label>();
            //SubPoint = ConvertPoint(centralPoint);
            StackPoint(Scores.Rows.Count);
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
                int LblX = (int)NewPoint.X;
                int LblY = (int)NewPoint.Y;
                Label NewLabel = new Label();
                //NewLabel.Size
                NewLabel.Text = Scores.Rows[i].Field<String>("N");
                NewLabel.Margin = new Padding(0, 0, 0, 0);
                NewLabel.AutoSize = true;                
                int WLbl = NewLabel.PreferredSize.Width;
                int HLbl = NewLabel.PreferredSize.Height;
                float CenX = CentralPoint.X;
                float CenY = CentralPoint.Y;
                
                if (LblX <= CenX && LblX >= (LblX - Default.Distance))
                {
                    if (LblY == (CenY - Default.Distance))
                    {
                        //NewLabel.Anchor = AnchorStyles.Top;
                        NewLabel.Location = new System.Drawing.Point((int)(NewPoint.X) - WLbl / 2, (int)(NewPoint.Y)-HLbl);
                        
                    }
                    else if (LblY == CenY + Default.Distance)
                    {
                        //NewLabel.Anchor = AnchorStyles.Bottom;
                        NewLabel.Location = new System.Drawing.Point((int)(NewPoint.X) - WLbl / 2, (int)(NewPoint.Y));
                        
                    }
                    else
                    {
                        //NewLabel.Anchor = AnchorStyles.Left;
                        NewLabel.Location = new System.Drawing.Point((int)(NewPoint.X)-WLbl, (int)(NewPoint.Y)-HLbl);
                        
                    }
                }
                else
                {
                    //NewLabel.Anchor = AnchorStyles.Right;
                    NewLabel.Location = new System.Drawing.Point((int)(NewPoint.X), (int)(NewPoint.Y));
                    
                }
                //NewLabel.Location = new System.Drawing.Point((int)(NewPoint.X), (int)(NewPoint.Y));
                labelList.Add(NewLabel);
                panelPaint.Controls.Add(NewLabel);


                PointF SubPoint = new PointF();
                object T = Scores.Rows[i].Field<object>("Score");
                double NewNum;
                if (T!= null)
                {
                    NewNum = (Convert.ToDouble(T.ToString()) / Max)+0.05;
                }
                else
                {
                    NewNum = 0.05;
                }
                
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
