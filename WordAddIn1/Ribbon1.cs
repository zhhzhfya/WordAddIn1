using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace WordAddIn1
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            // 改为竖行排版
            Globals.ThisAddIn.Application.Selection.Orientation = Microsoft.Office.Interop.Word.WdTextOrientation.wdTextOrientationVerticalFarEast;  
        }

        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            // 所选的字体变大
            Microsoft.Office.Interop.Word.Document Doc = Globals.ThisAddIn.Application.ActiveDocument;
            Microsoft.Office.Interop.Word.Range rng = Globals.ThisAddIn.Application.Selection.Range;
            rng.Font.Size++;  
        }

        private void button4_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
