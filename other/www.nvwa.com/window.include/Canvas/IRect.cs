using platform.include;

namespace window.include
{
    public interface IRect : IStyle
    {
        event _SetPoint2ISlot m_tMovePoint2I;

        void _offset(Point2I nPoint);

        event _RunSlot m_tAdjustPoint;

        void _adjustPoint();

        event _GetBoolSlot m_tInMoving;

        bool _inMoving();

        event _PointJoinSlot m_tAdjustJoinPoint;

        Point2I _adjustJoinPoint(Point2I nBeg, Point2I nEnd);

        event _GetRect2ISlot m_tGetRect2I;

        Rect2I _getRect2I();

        void _setName(string nName);

        string _getName();
    }
}
