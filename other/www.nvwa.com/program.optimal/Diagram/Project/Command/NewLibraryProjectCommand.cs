using window.include;
using notepad.include;
using program.include;
using platform.include;

namespace program.optimal
{
    public class NewLibraryProjectCommand : AbstractCommand
    {
        public override void _runCommand()
        {
            NewProjectArg newProjectArg_ = this._getOwner() as NewProjectArg;
            LibraryProject libraryProject_ = new LibraryProject();
            libraryProject_._firstInit();

            libraryProject_._runInit();
            libraryProject_._initControl();

            string projectUrl_ = newProjectArg_._getProjectUrl();
            string projectName_ = newProjectArg_._getProjectName();
            libraryProject_._createUrl(projectUrl_, projectName_);

            WorkbenchSingleton workbenchSingleton_ = __singleton<WorkbenchSingleton>._instance();
            workbenchSingleton_._showContent(libraryProject_);
        }
    }
}
