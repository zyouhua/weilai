using window.include;
using platform.include;

namespace program.optimal
{
    public class ProjectReference : TreeNodeStream
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mProjectName, @"projectName");
            nSerialize._serialize(ref mProjectUrl, "projectUrl");
        }

        public override string _getTreeNodeName()
        {
            return @"reference";
        }

        static readonly string mReferenceImage = @"rid://program.optimal.referenceImageUrl";
        public override string _getTreeNodeImage()
        {
            return mReferenceImage;
        }

        public ProjectReference()
        {
            mProjectName = null;
            mProjectUrl = null;
        }

        string mProjectName;
        string mProjectUrl;
    }
}
