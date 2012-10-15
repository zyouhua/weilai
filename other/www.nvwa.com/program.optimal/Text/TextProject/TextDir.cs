using System.Collections.Generic;

using window.include;
using platform.include;

namespace program.optimal
{
    public class TextDir : TreeNodeStream, ITextDir
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mTextClasses, "files");
            nSerialize._serialize(ref mName, "name");
        }

        public void _setDirUrl(string nDirUrl)
        {
            mUrl = nDirUrl;
        }

        public string _getDirUrl()
        {
            return mUrl;
        }

        public void _setDirName(string nName)
        {
            mName = nName;
        }

        public string _getDirName()
        {
            return mName;
        }

        public void _newTextDir()
        {
            string name_ = this._newTextDirName();
            TextDir textDir_ = new TextDir();
            textDir_._setDirName(name_);
            mTextDirs.Add(textDir_);
        }

        string _newTextDirName()
        {
            string dirName_ = "newFolder";
            if (this._containDir(dirName_))
            {
                int index_ = 1;
                while (this._containDir(dirName_ + index_))
                {
                    index_++;
                }
                return dirName_ + index_;
            }
            return dirName_;
        }

        bool _containDir(string nName)
        {
            foreach (TextDir i in mTextDirs)
            {
                string dirName_ = i._getDirName();
                if (dirName_ == nName)
                {
                    return true;
                }
            }
            return false;
        }

        public void _addTextClass(TextClass nTextClass)
        {
            mTextClasses.Add(nTextClass);
        }

        public override string _getTreeNodeName()
        {
            return mName;
        }

        static readonly string mTextDirImageUrl = "rid://program.optimal.closeFolderImageUrl";
        public override string _getTreeNodeImage()
        {
            return mTextDirImageUrl;
        }

        public TextDir()
        {
            mTextClasses = new List<TextClass>();
            mTextDirs = new List<TextDir>();
            mName = null;
        }

        List<TextClass> mTextClasses;
        List<TextDir> mTextDirs;
        string mName;
        string mUrl;
    }
}
