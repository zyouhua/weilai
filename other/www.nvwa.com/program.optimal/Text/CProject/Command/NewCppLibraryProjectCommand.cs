using window.include;
using notepad.include;
using program.include;
using platform.include;

namespace program.optimal
{
    public class NewCppLibraryProjectCommand : AbstractCommand
    {
        public override void _runCommand()
        {
            NewProjectArg newProjectArg_ = this._getOwner() as NewProjectArg;
            CLibraryProject cLibraryProject_ = new CLibraryProject();
            cLibraryProject_._firstInit();

            string textName_ = "Main.cpp";
            TextClass textClass_ = new TextClass();
            textClass_._firstInit();
            textClass_._setBuildAction(BuildAction_.mCompile_);
            textClass_._setFileName(textName_);
            cLibraryProject_._addTextClass(textClass_);

            cLibraryProject_._runInit();
            cLibraryProject_._initControl();

            string projectUrl_ = newProjectArg_._getProjectUrl();
            string projectName_ = newProjectArg_._getProjectName();
            cLibraryProject_._createUrl(projectUrl_, projectName_);
            string projectAllUrl_ = cLibraryProject_._getUrl();
            textClass_._createUrl(projectAllUrl_, textName_);

            WorkbenchSingleton workbenchSingleton_ = __singleton<WorkbenchSingleton>._instance();
            workbenchSingleton_._showContent(textClass_);
        }
    }
}
