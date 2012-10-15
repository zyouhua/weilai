using System.Collections.Generic;

using notepad.include;
using platform.include;

namespace program.optimal
{
    public class MethodCanvas : CanvasDockWidget
    {
        public override void _serialize(ISerialize nSerialize)
        {
        }

        public MethodCanvas(Method nMethod)
        {
            mMethod = nMethod;
        }

        Method mMethod;
    }
}
