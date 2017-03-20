using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FA_Fraktale
{
    class Loader
    {
        string colorMap;

        public Loader(string colorMap)
        {
            this.colorMap = colorMap;            
        }

        public Color[] GetColorCollection()
        {
            if(colorMap == null)
            {
                Logger.Log(SecruityLevel.ERROR, "ColorMap-Referenz ist nicht vorhanden.");
                return null;
            }

            try
            {
                Logger.Log(SecruityLevel.INFO, String.Concat("Lade ", colorMap));

                Color[] colorCollection = new Color[256];
                StreamReader reader = new StreamReader(Application.StartupPath + "\\" + colorMap);
                ArrayList lines = new ArrayList();
                string line = reader.ReadLine();

                while (line != null)
                {
                    lines.Add(line);
                    line = reader.ReadLine();
                }
                int i = 0;

                for (i = 0; i < Math.Min(256, lines.Count); i++)
                {
                    string curC = (string)lines[i];
                    colorCollection[i] = Color.FromArgb(int.Parse(curC.Split(' ')[0]), int.Parse(curC.Split(' ')[1]), int.Parse(curC.Split(' ')[2]));
                }
                for (int j = i; j < 256; j++)
                {
                    colorCollection[j] = Color.White;
                }
                return colorCollection;
            }
            catch (Exception ex)
            {
                Logger.Log(SecruityLevel.ERROR, ex.Message);
                return null;
            }
        }

    }
}
