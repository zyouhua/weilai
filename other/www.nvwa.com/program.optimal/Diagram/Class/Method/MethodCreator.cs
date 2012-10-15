using System.Windows.Forms;

using window.include;
using platform.include;

namespace program.optimal
{
    public class MethodCreator : LabelCreater
    {
        public override ILabel _exeCreate()
        {
            string methodCreatorDialogUrl_ = "rid://program.optimal.methodShapeDialogUrl";
            WindowSingleton windowSingleton_ = __singleton<WindowSingleton>._instance();
            IForm form_ = windowSingleton_._loadForm(methodCreatorDialogUrl_);
            form_._setTag(this);
            form_._showDialog();
            return mMethodShape;
        }

        public void _createMethodShape(string nNamespace, string nName)
        {
            ProjectCanvas projectCanvas_ = this._getObject() as ProjectCanvas;
            if (null != nNamespace)
            {
                mClassShape = new ClassShape();
                mClassShape._setNameSpace(nNamespace);
                mClassShape._setName(nName);
                projectCanvas_._addClassShape(mClassShape);
                return;
            }
            if (projectCanvas_._haveClass(nName))
            {
                mClassShape = new ClassShape();
                mClassShape._setName(nName);
                projectCanvas_._addClassShape(mClassShape);
                return;
            }
            DialogResult dialogResult_ = MessageBox.Show(@"这个类名不存在，是否创建此类?", "创建类", MessageBoxButtons.YesNo);
            if (dialogResult_ == DialogResult.No)
            {
                return;
            }
            projectCanvas_._createClass(nName);
            mClassShape = new ClassShape();
            mClassShape._setName(nName);
            projectCanvas_._addClassShape(mClassShape);
        }

        public MethodCreator()
        {
            mMethodShape = null;
        }
        MethodShape mMethodShape;
    }
}
