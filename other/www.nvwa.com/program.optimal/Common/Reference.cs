using System.Collections.Generic;

using window.include;
using platform.include;

namespace program.optimal
{
    public class Reference : TreeNodeStream
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mProjectReferences, "projectReferences");
        }

        public override string _getTreeNodeName()
        {
            return "reference";
        }

        static readonly string mReferenceClose = @"rid://program.optimal.referenceCloseImageUrl";
        public override string _getTreeNodeImage()
        {
            return mReferenceClose;
        }

        public Reference()
        {
            mProjectReferences = new List<ProjectReference>();
        }

        List<ProjectReference> mProjectReferences;
    }
}
