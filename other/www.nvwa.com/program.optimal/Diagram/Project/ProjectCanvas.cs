using System.Collections.Generic;

using notepad.include;
using platform.include;

namespace program.optimal
{
    public class ProjectCanvas : CanvasDockWidget
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mClassShapes, @"classShapes");
            nSerialize._serialize(ref mDeriveShapes, @"deriveShapes");
        }

        public void _createClass(string nName)
        {
            mProject._createClass(nName);
        }

        public bool _haveClass(string nName)
        {
            return mProject._haveClass(nName);
        }

        public void _addDeriveShape(DeriveShape nDeriveShape)
        {
            mDeriveShapes.Add(nDeriveShape);
            base._runStreamDirty();
        }

        public void _addClassShape(ClassShape nClassShape)
        {
            mClassShapes.Add(nClassShape);
            base._runStreamDirty();
        }

        public override void _runInit()
        {
            foreach (ClassShape i in mClassShapes)
            {
                base._regLabel(i);
            }
            foreach (DeriveShape i in mDeriveShapes)
            {
                base._regLine(i);
            }
            base._runInit();
        }

        public ProjectCanvas(Project nProject)
        {
            mDeriveShapes = new List<DeriveShape>();
            mClassShapes = new List<ClassShape>();
            mProject = nProject;
        }

        List<DeriveShape> mDeriveShapes;
        List<ClassShape> mClassShapes;
        Project mProject;
    }
}
