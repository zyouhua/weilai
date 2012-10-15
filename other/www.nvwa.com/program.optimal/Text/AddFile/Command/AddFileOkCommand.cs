using System.Collections.Generic;

using window.include;
using notepad.include;
using platform.include;

namespace program.optimal
{
    public class AddFileOkCommand : AbstractCommand
    {
        public override void _runCommand()
        {
            IContain contain_ = this._getOwner() as IContain;
            IForm form_ = contain_._contain() as IForm;
            ITextBox fileNameTextBox_ = form_._childControl("panel1/fileName") as ITextBox;
            string fileName_ = fileNameTextBox_._getText();
            if (null == fileName_ || "" == fileName_)
            {
                return;
            }
            IListView listView_ = form_._childControl("panel2/listView1") as IListView;
            IList<IListItem> listItems_ = listView_._selectedItems();
            if (listItems_.Count <= 0)
            {
                return;
            }
            NewFileNodeCommand newFileNodeCommand_ = listItems_[0] as NewFileNodeCommand;
            string commandUrl_ = newFileNodeCommand_._getCommandUrl();
            NewFileArg newFileArg_ = new NewFileArg(form_._getTag(), fileName_);

            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            ICommand command_ = platformSingleton_._findInterface<ICommand>(commandUrl_);
            command_._setOwner(newFileArg_);
            command_._runCommand();

            form_._runClose();
        }
    }
}
