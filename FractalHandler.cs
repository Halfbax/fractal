using System;
using System.Drawing;
using System.Threading;

namespace FA_Fraktale
{
    class FractalHandler
    {
        Thread renderThread;
        Loader loader;
        Bitmap datasource;

        int panelWidth, panelHeight;
        double xMin, yMin, xMax, yMax = 0.0;

        public FractalHandler(int height, int width, double sx, double fx, double sy, double fy)
        {
            this.panelHeight = height;
            this.panelWidth = width;
            this.xMin = sx;
            this.yMin = sy;
            this.xMax = fx;
            this.yMax = fy;

            Logger.Log(SecruityLevel.INFO, String.Concat(sx + " | " + fx + " | " + sy + " | " + fy));
        }

        public void init()
        {
            datasource = null;
            loader = new Loader("RedEdge.ColorMap");
        }

        public void render()
        {
            Color[] colorCollection = loader.GetColorCollection();

            datasource = Fractal.generateMandel(colorCollection, panelWidth, panelHeight, xMin, xMax, yMin, yMax);
        }

        public void RenderMouseEvent(Point e, Point pStart)
        {
            //renderThread.Abort();
            /*renderThread = new Thread(delegate () {
                Fractal.generateRectangleOnBitmap(datasource, panelWidth, panelHeight, e, pStart);
            });
            renderThread.Start();
            renderThread.Join();
            */
            if (datasource != null)
            {
                datasource = Fractal.generateRectangleOnBitmap(datasource, panelWidth, panelHeight, e, pStart);
            }
        }

        public Bitmap getDataSource()
        {
            return datasource;
        }
    }
}
