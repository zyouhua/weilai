using window.include;
using notepad.include;
using program.include;
using platform.include;

namespace program.optimal
{
    public class NewCSLibraryProjectCommand : AbstractCommand
    {
        public override void _runCommand()
        {
            NewProjectArg newProjectArg_ = this._getOwner() as NewProjectArg;
            CSLibraryProject cSLibraryProject_ = new CSLibraryProject();
            cSLibraryProject_._firstInit();

            string textName_ = "Class1.cs";
            TextClass textClass_ = new TextClass();
            textClass_._firstInit();
            textClass_._setBuildAction(BuildAction_.mCompile_);
            textClass_._setFileName(textName_);
            cSLibraryProject_._addTextClass(textClass_);

            cSLibraryProject_._runInit();
            cSLibraryProject_._initControl();

            string projectUrl_ = newProjectArg_._getProjectUrl();
            string projectName_ = newProjectArg_._getProjectName();
            cSLibraryProject_._createUrl(projectUrl_, projectName_);
            string projectAllUrl_ = cSLibraryProject_._getUrl();
            textClass_._createUrl(projectAllUrl_, textName_);

            WorkbenchSingleton workbenchSingleton_ = __singleton<WorkbenchSingleton>._instance();
            workbenchSingleton_._showContent(textClass_);
        }
    }
}
