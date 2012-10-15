using System.Collections.Generic;

using platform.include;

namespace window.include
{
    public interface ILabel : IRect
    {
        void _setX(int nX);

        int _getX();

        void _setY(int nY);

        int _getY();

        void _setW(int nWidth);

        int _getW();

        List<IRect> _getRects();
    }
}
