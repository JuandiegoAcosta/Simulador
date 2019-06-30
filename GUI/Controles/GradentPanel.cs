﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Controles
{
   public class GradentPanel : Panel
   {
      public Color ColorTop { get; set; }
      public Color ColorBottom { get; set; }
      protected override void OnPaint(PaintEventArgs e)
      {
         LinearGradientBrush _lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
         Graphics _g = e.Graphics;
         _g.FillRectangle(_lgb, this.ClientRectangle);
         base.OnPaint(e);
      }
   }
}
