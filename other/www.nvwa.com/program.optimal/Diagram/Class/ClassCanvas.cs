using System.Collections.Generic;

using notepad.include;
using platform.include;

namespace program.optimal
{
    public class ClassCanvas : CanvasDockWidget
    {
        public override void _serialize(ISerialize nSerialize)
        {
        }

        public ClassCanvas(Class nClass)
        {
            mClass = nClass;
        }

        Class mClass;
    }
}
