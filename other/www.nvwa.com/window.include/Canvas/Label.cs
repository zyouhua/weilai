using System.Collections.Generic;

using window.include;
using platform.include;

namespace window.include
{
    public abstract class Label : Rect, ILabel
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mX, @"x");
            nSerialize._serialize(ref mY, @"y");
            nSerialize._serialize(ref mW, @"w");
            base._serialize(nSerialize);
        }

        public override void _offset(Point2I nPoint)
        {
            mX += nPoint._getX();
            mY += nPoint._getY();
            base._offset(nPoint);
        }

        public void _setX(int nX)
        {
            mX = nX;
        }

        public int _getX()
        {
            return mX;
        }

        public void _setY(int nY)
        {
            mY = nY;
        }

        public int _getY()
        {
            return mY;
        }

        public void _setW(int nW)
        {
            mW = nW;
        }

        public int _getW()
        {
            return mW;
        }

        public virtual List<IRect> _getRects()
        {
            return null;
        }

        public Label()
        {
            mX = 0;
            mY = 0;
            mW = 0;
        }

        int mX;
        int mY;
        int mW;
    }
}
