using System;
using System.Drawing.Drawing2D;

namespace ImageTransformations
{
    public class MatrixOperations
    {
        public void Transform(Matrix matrix, int x, int y)
        {
            matrix.Translate(x, y);
        }

        public void Stretch(Matrix matrix, float scaleX, float skewX, float skewY, float scaleY)
        {
            matrix.Scale(scaleX, scaleY);
            matrix.Shear(skewX, skewY);
        }

        public void Rotate(Matrix matrix, double angleRad, int rotateX, int rotateY)
        {
            matrix.RotateAt((float)(angleRad * 180.0 / Math.PI), new System.Drawing.PointF(rotateX, rotateY));
        }
    }
}