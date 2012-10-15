using window.include;
using platform.include;

namespace program.optimal
{
    public class TreeViewInitCppCommand : AbstractCommand
    {
        public override void _runCommand()
        {
            IContain contain_ = this._getOwner() as IContain;
            ITreeView treeView_ = contain_._childControl("treeView1") as ITreeView;
            NewFileUrl newFileUrl_ = new NewFileUrl();
            string newUrl_ = @"rid://program.optimal.newCppFileUrl";
            newFileUrl_._runLoad(newUrl_);
            newFileUrl_._runInit();
            newFileUrl_._addTreeNode(treeView_);
        }
    }
}
