using window.include;
using platform.include;

namespace program.optimal
{
    public class NewCppCommand : AbstractCommand
    {
        public override void _runCommand()
        {
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            string formUrl_ = @"uid://program.optimal.window:window.optimal.Form";
            string newFileUrl_ = @"rid://program.optimal.newCppFormUrl";
            IForm fileForm_ = platformSingleton_._loadHeadstream<IForm>(formUrl_, newFileUrl_);
            fileForm_._setTag(this._getOwner());
            fileForm_._runInit();
            fileForm_._showDialog();
        }
    }
}
