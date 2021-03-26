// Fig 14.38: PainterForm.cs
// Using the mouse to draw on a Form.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Painter
{
   // creates a Form that is a drawing surface
   public partial class PainterForm : Form
   {
      bool shouldPaint = false; // determines whether to paint

      // default constructor
      public PainterForm()
      {
         InitializeComponent();
      } // end constructor

      // should paint when mouse button is pressed down
      private void PainterForm_MouseDown( 
         object sender, MouseEventArgs e )
      {
         // indicate that user is dragging the mouse
         shouldPaint = true;
      } // end method Painter_MouseDown

      // stop painting when mouse button is released
      private void PainterForm_MouseUp( object sender, MouseEventArgs e )
      {
         // indicate that user released the mouse button
         shouldPaint = false;
      } // end method Painter_MouseUp

      // draw circle whenever mouse moves with its button held down        
      private void PainterForm_MouseMove( 
         object sender, MouseEventArgs e )
      {
         if ( shouldPaint ) // check if mouse button is being pressed
         {
            // draw a circle where the mouse pointer is present
            using ( Graphics graphics = CreateGraphics() )
            {
               graphics.FillEllipse(
                  new SolidBrush( Color.BlueViolet ), e.X, e.Y, 4, 4 );
            } // end using; calls graphics.Dispose()
         } // end if
      }

      private void PainterForm_Load(object sender, EventArgs e)
      {

      } // end method Painter_MouseMove
   } // end class PainterForm
} // end namespace Painter

