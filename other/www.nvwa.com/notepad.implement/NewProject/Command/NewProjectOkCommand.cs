using System.Collections.Generic;

using window.include;
using notepad.include;
using platform.include;

namespace notepad.implement
{
    public class NewProjectOkCommand : AbstractCommand
    {
        public override void _runCommand()
        {
            IContain contain_ = this._getOwner() as IContain;
            IForm form_ = contain_._contain() as IForm;

            ITextBox fileUrlTextBox_ = form_._childControl("panel1/fileUrl") as ITextBox;
            ITextBox fileNameTextBox_ = form_._childControl("panel1/fileName") as ITextBox;
            string fileUrl_ = fileUrlTextBox_._getText();
            string fileName_ = fileNameTextBox_._getText();
            if (null == fileUrl_ || "" == fileUrl_)
            {
                return;
            }
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

            NewProjectNodeCommand newProjectNodeCommand_ = listItems_[0] as NewProjectNodeCommand;
            string commandUrl_ = newProjectNodeCommand_._getCommandUrl();
            NewProjectArg newProjectArg_ = new NewProjectArg(fileUrl_, fileName_);
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            ICommand command_ = platformSingleton_._findInterface<ICommand>(commandUrl_);
            command_._setOwner(newProjectArg_);
            command_._runCommand();
            form_._runClose();
        }
    }
}
