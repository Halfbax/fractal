using System;
using System.Drawing;
using Leonsporsde.Utilities;
using System.Threading;

namespace Leonsporsde.Fractal
{
    class FractalHandler
    {
        Loader loader;
        Bitmap fractalClear;
        Bitmap fractalRect;

        int panelWidth, panelHeight;
        double xMin, yMin, xMax, yMax = 0.0;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="height">this.getHeight()</param>
        /// <param name="width">this.getWidth()</param>
        /// <param name="sx"></param>
        /// <param name="fx"></param>
        /// <param name="sy"></param>
        /// <param name="fy"></param>
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

        /// <summary>
        /// Intialize
        /// </summary>
        public void init()
        {
            fractalClear = null;
            fractalRect = null;
            loader = new Loader("RedEdge.ColorMap");
        }

        /// <summary>
        /// Generates the Mandelbrot fractal
        /// </summary>
        public void render()
        {
            Color[] colorCollection = loader.GetColorCollection();

            fractalClear = Fractal.generateMandel(colorCollection, panelWidth, panelHeight, xMin, xMax, yMin, yMax);
            fractalRect = fractalClear;
        }

        /// <summary>
        /// MouseEvent
        /// </summary>
        /// <param name="e"></param>
        /// <param name="pStart"></param>
        public void onMouseLeftClickReleaseEvent(Point e, Point pStart)
        {

            if (fractalClear != null)
            {
                fractalRect = Fractal.generateRectangleOnBitmap(fractalClear, panelWidth, panelHeight, e, pStart);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Bitmap getDataSource()
        {
            return fractalRect;
        }
    }
}
