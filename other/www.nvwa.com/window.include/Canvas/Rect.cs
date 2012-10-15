using window.include;
using platform.include;

namespace window.include
{
    public abstract class Rect : Stream, IRect
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mName, "name");
        }

        public event _SetPoint2ISlot m_tMovePoint2I;

        public virtual void _offset(Point2I nPoint)
        {
            if (null != m_tMovePoint2I)
            {
                this.m_tMovePoint2I(nPoint);
            }
        }

        public event _RunSlot m_tAdjustPoint;

        public void _adjustPoint()
        {
            if (null != m_tAdjustPoint)
            {
                this.m_tAdjustPoint();
            }
        }

        public event _GetBoolSlot m_tInMoving;

        public bool _inMoving()
        {
            if (null != m_tInMoving)
            {
                return this.m_tInMoving();
            }
            return false;
        }

        public event _PointJoinSlot m_tAdjustJoinPoint;

        public Point2I _adjustJoinPoint(Point2I nBeg, Point2I nEnd)
        {
            if (null != m_tAdjustJoinPoint)
            {
                return this.m_tAdjustJoinPoint(nBeg, nEnd);
            }
            return null;
        }

        public event _GetRect2ISlot m_tGetRect2I;

        public Rect2I _getRect2I()
        {
            if (null != m_tGetRect2I)
            {
                return this.m_tGetRect2I();
            }
            return null;
        }

        public void _setName(string nName)
        {
            mName = nName;
        }

        public string _getName()
        {
            return mName;
        }

        public abstract string _styleName();

        public Rect()
        {
            m_tMovePoint2I = null;
            m_tAdjustPoint = null;
            m_tInMoving = null;
            m_tAdjustJoinPoint = null;
            m_tGetRect2I = null;
            mName = null;
        }

        string mName;
    }
}
