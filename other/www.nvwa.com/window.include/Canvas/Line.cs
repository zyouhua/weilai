using System.Collections.Generic;

using window.include;
using platform.include;

namespace window.include
{
    public abstract class Line : Stream, ILine
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mName, @"name");
            nSerialize._serialize(ref mBegPoint, "begPoint");
            nSerialize._serialize(ref mEndPoint, "endPoint");
        }

        public void _setName(string nName)
        {
            mName = nName;
        }

        public string _getName()
        {
            return mName;
        }

        public virtual void _setBeg(IRect nRect)
        {
            nRect.m_tMovePoint2I += this._begPointOffset;
            nRect.m_tAdjustPoint += this._adjustPoint;
        }

        public abstract IRect _getBeg();

        public virtual void _setEnd(IRect nRect)
        {
            nRect.m_tMovePoint2I += this._endPointOffset;
            nRect.m_tAdjustPoint += this._adjustPoint;
        }

        public abstract IRect _getEnd();

        void _begPointOffset(Point2I nPoint)
        {
            mBegPoint._offset(nPoint);
        }

        void _endPointOffset(Point2I nPoint)
        {
            mEndPoint._offset(nPoint);
        }

        void _adjustPoint()
        {
            IRect beg_ = this._getBeg();
            IRect end_ = this._getEnd();
            Rect2I begrect2i_ = beg_._getRect2I();
            Rect2I endrect2i_ = end_._getRect2I();
            Point2I begcenterpoint2i_ = begrect2i_._centerPoint();
            Point2I endcenterpoint2i_ = endrect2i_._centerPoint();
            Point2I point0_ = end_._adjustJoinPoint(endcenterpoint2i_, begcenterpoint2i_);
            this._setBegPoint(point0_);
            Point2I point1_ = beg_._adjustJoinPoint(begcenterpoint2i_, endcenterpoint2i_);
            this._setEndPoint(point1_);
        }

        public void _setBegPoint(Point2I nPoint)
        {
            mBegPoint._setPoint(nPoint);
        }

        public Point2I _getBegPoint()
        {
            return new Point2I(mBegPoint);
        }

        public void _setEndPoint(Point2I nPoint)
        {
            mEndPoint._setPoint(nPoint);
        }

        public Point2I _getEndPoint()
        {
            return new Point2I(mEndPoint);
        }

        public abstract string _styleName();

        public Line()
        {
            mBegPoint = new Point2I();
            mEndPoint = new Point2I();
            mName = null;
        }

        Point2I mBegPoint;
        Point2I mEndPoint;
        string mName;
    }
}
