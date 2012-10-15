using System;
using System.Drawing;

using window.include;
using platform.include;

namespace window.optimal
{
    public class GroupBox : Control
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mPoint, @"point");
            nSerialize._serialize(ref mSize, @"size");
            nSerialize._serialize(ref mText, @"text");
            base._serialize(nSerialize);
        }

        public override string _virstream()
        {
            return "groupBox";
        }

        public override void _initControl()
        {
            if (null == mGroupBox || mGroupBox.IsDisposed)
            {
                mGroupBox = new System.Windows.Forms.GroupBox();
                mGroupBox.Text = mText;
                int x_ = mPoint._getX();
                int y_ = mPoint._getY();
                mGroupBox.Location = new Point(x_, y_);
                if (null != mSize)
                {
                    mGroupBox.Size = new Size(mSize._getWidth(), mSize._getHeight());
                }
            }
            base._initControl();
}

        public override IWidget _createControl()
        {
            return new GroupBox();
        }

        public override object _getControl()
        {
            return mGroupBox;
        }

        public override void _addControl(object nControl)
        {
            System.Windows.Forms.Control control_ = nControl as System.Windows.Forms.Control;
            mGroupBox.Controls.Add(control_);
        }

        public GroupBox()
        {
            mPoint = new Point2I();
            mSize = new Size2I();
            mGroupBox = null;
            mText = null;
        }

        System.Windows.Forms.GroupBox mGroupBox;
        Point2I mPoint;
        Size2I mSize;
        string mText;
    }
}
