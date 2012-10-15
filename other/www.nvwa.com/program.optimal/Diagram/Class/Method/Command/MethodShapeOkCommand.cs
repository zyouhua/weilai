using System.Windows.Forms;

using window.include;
using platform.include;

namespace program.optimal
{
    public class MethodShapeOkCommand : AbstractCommand
    {
        public override void _runCommand()
        {
            IForm form_ = this._getOwner() as IForm;
            ITextBox textBox_ = form_._childControl(@"className") as ITextBox;
            string text_ = textBox_._getText();
            string name_ = StringFormat._methodName(text_);
            if (null == name_)
            {
                MessageBox.Show(@"方法名不合法!");
                return;
            }
            MethodCreator methodCreator_ = form_._getTag() as MethodCreator;
            methodCreator_._createMethodShape(namespace_, name_);
            form_._runClose();
        }
    }
}
