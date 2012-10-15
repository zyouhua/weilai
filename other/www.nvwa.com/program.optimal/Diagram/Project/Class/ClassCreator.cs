using System.Windows.Forms;

using window.include;
using platform.include;

namespace program.optimal
{
    public class ClassCreator : LabelCreater
    {
        public override ILabel _exeCreate()
        {
            string ClassCreatorDialogUrl_ = "rid://program.optimal.classShapeDialogUrl";
            WindowSingleton windowSingleton_ = __singleton<WindowSingleton>._instance();
            IForm form_ = windowSingleton_._loadForm(ClassCreatorDialogUrl_);
            form_._setTag(this);
            form_._showDialog();
            return mClassShape;
        }

        public void _createClassShape(string nNamespace, string nName)
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

        public ClassCreator()
        {
            mClassShape = null;
        }
        ClassShape mClassShape;
    }
}
