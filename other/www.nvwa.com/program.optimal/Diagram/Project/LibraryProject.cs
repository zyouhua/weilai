using program.include;

namespace program.optimal
{
    public class LibraryProject : Project
    {
        public override void _runInit()
        {
            base._setApplicationType(ApplicationType_.mLibrary_);
            base._runInit();
        }
    }
}
