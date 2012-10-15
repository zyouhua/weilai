using window.include;
using notepad.include;
using program.include;
using platform.include;

namespace program.optimal
{
    public class NewDirCommand : AbstractCommand
    {
        public override void _runCommand()
        {
            ITextDir baseDir_ = this._getOwner() as ITextDir;
            baseDir_._newTextDir();
        }
    }
}
