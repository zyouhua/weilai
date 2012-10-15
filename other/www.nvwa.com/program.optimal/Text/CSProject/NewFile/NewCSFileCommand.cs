using window.include;
using notepad.include;
using program.include;
using platform.include;

namespace program.optimal
{
    public class NewCSFileCommand : AbstractCommand
    {
        public override void _runCommand()
        {
            NewFileArg newFileArg_ = this._getOwner() as NewFileArg;
            ITextDir textDir_ = newFileArg_._getParent() as ITextDir;
            string fileName_ = newFileArg_._getFileName();
            if (!fileName_.EndsWith(".cs"))
            {
                fileName_ += ".cs";
            }
            TextClass textClass_ = new TextClass();
            textClass_._firstInit();
            textClass_._setBuildAction(BuildAction_.mCompile_);
            textClass_._setFileName(fileName_);
            textDir_._addTextClass(textClass_);
            textClass_._runInit();
            textClass_._initControl();

            string projectUrl_ = textDir_._getDirUrl();
            textClass_._createUrl(projectUrl_, fileName_);

            WorkbenchSingleton workbenchSingleton_ = __singleton<WorkbenchSingleton>._instance();
            workbenchSingleton_._showContent(textClass_);
        }
    }
}
