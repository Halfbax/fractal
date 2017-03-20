using System;
using System.Drawing;

namespace FA_Fraktale
{
    public static class Fractal
    {
        public static Bitmap generateMandel(Color[] colorCollection, int panelWidth, int panelHeight, double xMin, double xMax, double yMin, double yMax)
        {
            DateTime startTime;

            Color[] colorSet = new Color[256];
            colorSet = colorCollection;
            Bitmap b = new Bitmap(panelWidth, panelHeight);
            double x, y, x1, y1, xx;
            int looper, s, z = 0;
            double intigralX, intigralY = 0.0;

            Logger.Log(SecruityLevel.INFO, "Beginne Berechnung...");
            startTime = DateTime.Now;

            intigralX = (xMax - xMin) / panelWidth;
            intigralY = (yMax - yMin) / panelHeight;

            x = xMin;

            for (s = 1; s < panelWidth; s++)
            {
                y = yMin;

                for (z = 1; z < panelHeight; z++)
                {
                    x1 = 0;
                    y1 = 0;
                    looper = 0;
                    while (looper < 100 && Math.Sqrt((x1 * x1) + (y1 * y1)) < 2)
                    {
                        looper++;
                        xx = (x1 * x1) - (y1 * y1) + x;
                        y1 = 2 * x1 * y1 + y;
                        x1 = xx;
                    }
                    double perc = looper / (100.0);
                    int val = ((int)(perc * 255));
                    b.SetPixel(s, z, colorSet[val]);
                    y += intigralY;
                }
                x += intigralX;
            }

            Logger.Log(SecruityLevel.INFO, String.Concat("Berechnungen in ", (DateTime.Now - startTime).Milliseconds, "ms beendet."));
            return b;
        }

        public static Bitmap generateRectangleOnBitmap(Bitmap datasource, int panelWidth, int panelHeight, Point e, Point pStart)
        {
            Point temp = new Point(e.X, pStart.Y + ((int)(((panelHeight - 28) / (panelHeight * 1.0)) * (e.X - pStart.X))));
            Rectangle rect = Rectangle.FromLTRB(pStart.X, pStart.Y, temp.X, temp.Y);
            Bitmap bitmap = new Bitmap(panelWidth, panelHeight);

            Graphics g = Graphics.FromImage((Image) bitmap);

            g.DrawImage((Image) datasource, 0, 0);
            g.DrawRectangle(new Pen(Brushes.Red, 3), rect);

            return bitmap;
        }
    }
}
