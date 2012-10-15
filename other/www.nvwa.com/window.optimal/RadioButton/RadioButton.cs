using System;
using System.Drawing;

using window.include;
using platform.include;

namespace window.optimal
{
    public class RadioButton : Widget
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mPoint, "point");
            nSerialize._serialize(ref mSize, "size");
            nSerialize._serialize(ref mText, "text");
            base._serialize(nSerialize);
        }

        public override string _virstream()
        {
            return @"radioButton";
        }

        public override void _initControl()
        {
            if (null == mRadioButton || mRadioButton.IsDisposed)
            {
                mRadioButton = new System.Windows.Forms.RadioButton();
                if (null != mPoint)
                {
                    mRadioButton.Location = new Point(mPoint._getX(), mPoint._getY());
                }
                if (null != mSize)
                {
                    mRadioButton.Size = new Size(mSize._getWidth(), mSize._getHeight());
                }
                mRadioButton.Text = mText;
            }
        }

        public override IWidget _createControl()
        {
            return new RadioButton();
        }

        public override object _getControl()
        {
            return mRadioButton;
        }

        public override void _setContain(IContain nContain)
        {
            mContain = nContain;
        }

        public RadioButton()
        {
            mRadioButton = null;
            mPoint = new Point2I();
            mSize = new Size2I();
            mContain = null;
            mText = null;
        }

        System.Windows.Forms.RadioButton mRadioButton;
        IContain mContain;
        Point2I mPoint;
        Size2I mSize;
        string mText;
    }
}
