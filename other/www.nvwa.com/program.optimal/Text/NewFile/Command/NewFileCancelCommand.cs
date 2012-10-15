using window.include;
using platform.include;

namespace program.optimal
{
    public class NewFileCancelCommand : AbstractCommand
    {
        public override void _runCommand()
        {
            IContain contain_ = this._getOwner() as IContain;
            IForm form_ = contain_._contain() as IForm;
            form_._runClose();
        }
    }
}
