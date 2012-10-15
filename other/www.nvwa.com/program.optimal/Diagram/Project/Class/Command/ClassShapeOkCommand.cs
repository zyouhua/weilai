using System.Windows.Forms;

using window.include;
using platform.include;

namespace program.optimal
{
    public class ClassShapeOkCommand : AbstractCommand
    {
        public override void _runCommand()
        {
            IForm form_ = this._getOwner() as IForm;
            ITextBox textBox_ = form_._childControl(@"className") as ITextBox;
            string text_ = textBox_._getText();
            string name_ = StringFormat._className(text_);
            if (null == name_)
            {
                MessageBox.Show(@"类名不合法!");
                return;
            }
            string namespace_ = null;
            IComboBox comboBox_ = form_._childControl(@"comboBox1") as IComboBox;
            if (comboBox_._isEnable())
            {
                namespace_ = comboBox_._getSelectText();
            }
            ClassCreator classCreator_ = form_._getTag() as ClassCreator;
            classCreator_._createClassShape(namespace_, name_);
            form_._runClose();
        }
    }
}
