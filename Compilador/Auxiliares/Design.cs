using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador
{
    class Design
    {

        public static GraphicsPath RoundedRectPath(int posX, int posY, int totalW, int totalH, int arcW, int arcH)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            GraphicsPath graphicsPath2 = graphicsPath;
            graphicsPath2.StartFigure();
            // The following expression was wrapped in a checked-statement
            graphicsPath2.AddLine(posX + Convert.ToInt32(Convert.ToDecimal(arcW) / 2), posY, posX + totalW - Convert.ToInt32(Convert.ToDecimal(arcW) / 2), posY);
            graphicsPath2.AddArc(posX + totalW - arcW, posY, arcW, arcH, -90f, 90f);
            graphicsPath2.AddLine(posX + totalW, posY + Convert.ToInt32(Convert.ToDecimal(arcH) / 2), posX + totalW, posY + totalH - Convert.ToInt32(Convert.ToDecimal(arcH) / 2));
            graphicsPath2.AddArc(posX + totalW - arcW, posY + totalH - arcH, arcW, arcH, 0f, 90f);
            graphicsPath2.AddLine(posX + totalW - Convert.ToInt32(Convert.ToDecimal(arcW) / 2), posY + totalH, posX + Convert.ToInt32(Convert.ToDecimal(arcW) / 2), posY + totalH);
            graphicsPath2.AddArc(posX, posY + totalH - arcH, arcW, arcH, 90f, 90f);
            graphicsPath2.AddLine(posX, posY + totalH - Convert.ToInt32(Convert.ToDecimal(arcH) / 2), posX, posY + Convert.ToInt32(Convert.ToDecimal(arcH) / 2));
            graphicsPath2.AddArc(posX, posY, arcW, arcH, 180f, 90f);
            graphicsPath2.CloseFigure();
            return graphicsPath;
        }

    }
}
