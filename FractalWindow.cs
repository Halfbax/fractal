using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FA_Fraktale
{
    public partial class FractalWindow : Form
    {
        Thread renderThread = null;
        FractalHandler fractalHandler = null;

        double xmin, ymin, xmax, ymax;

        Point pStart = Point.Empty;
        Point pFinish = Point.Empty;

        private void createMandel()
        {
            fractalHandler = new FractalHandler(imagePanel.Height, imagePanel.Width, xmin, xmax, ymin, ymax);
            fractalHandler.init();

            renderThread = new Thread(new ThreadStart(this.fractalHandler.render));
            renderThread.Start();

            while (renderThread.IsAlive) { }

            Logger.Log(SecruityLevel.INFO, "Lade das Image-Objekt");

            imagePanel.BackgroundImage = fractalHandler.getDataSource();
        }

        private void imagePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                xmin = Double.Parse(tbXMin.Text);
                ymin = Double.Parse(tbYMin.Text);
                xmax = Double.Parse(tbXMax.Text);
                ymax = Double.Parse(tbYMax.Text);

                Logger.Log(SecruityLevel.WARN, "Setze den Sichtbereich zurück.");

                createMandel();
            }
            else if (e.Button == MouseButtons.Left)
                pStart = new Point(e.X, e.Y);
        }

        private void imagePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                renderThread.Abort();
                renderThread = null;
                renderThread = new Thread(delegate () {
                    fractalHandler.RenderMouseEvent(new Point(e.X, e.Y), pStart);
                });

                renderThread.Start();

                imagePanel.BackgroundImage = (Image) fractalHandler.getDataSource();
            }
        }

        private void imagePanel_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                pFinish = new Point(e.X, pStart.Y + ((int)(((this.Height - 28) / (this.Width * 1.0)) * (e.X - pStart.X))));

                double distX = xmax - xmin;
                double distY = ymax - ymin;
                double oSx = xmin;
                double oSy = ymin;

                xmin = (pStart.X / (this.Width * 1.0)) * distX;
                xmax = (pFinish.X / (this.Width * 1.0)) * distX;
                ymin = (pStart.Y / (this.Height * 1.0)) * distY;
                ymax = (pFinish.Y / (this.Height * 1.0)) * distY;

                xmin += oSx;
                xmax += oSx;
                ymax += oSy;
                ymin += oSy;

                Logger.Log(SecruityLevel.WARN, "Vergrößere den Sichtbereich.");

                createMandel();
            }
        }

        public FractalWindow()
        {
            InitializeComponent();
        }

        private void btnSetParams_Click(object sender, EventArgs e)
        {
            Logger.Log(SecruityLevel.INFO, "Setze xMin...");
            Logger.Log(SecruityLevel.INFO, "Setze yMin...");
            Logger.Log(SecruityLevel.INFO, "Setze xMax...");
            Logger.Log(SecruityLevel.INFO, "Setze yMax...");
            xmin = Double.Parse(tbXMin.Text);
            ymin = Double.Parse(tbYMin.Text);
            xmax = Double.Parse(tbXMax.Text);
            ymax = Double.Parse(tbYMax.Text);

            createMandel();
        }
    }
}
