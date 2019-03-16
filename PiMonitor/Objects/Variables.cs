using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiMonitor.Objects
{
    public class Variables
    {
        private string _name;
        private readonly List<string> _contents;

        public Variables(string name)
        {
            _name = name;
            _contents = new List<string>();
            _contents.Add("var " + Name + ";");
            _contents.Add(Name + " = \"CODE:\";");
        }

        public Variables()
        {
            _name = "";
            _contents = new List<string>();
            initContent();
        }

        private void initContent()
        {
            if (Contents.Count != 0)
            {
                _contents.RemoveAt(0);
                _contents.RemoveAt(0);
                _contents.Insert(0, Name + " = \"CODE:\";");
                _contents.Insert(0, "var " + Name + ";");
            }
            else
            {
                _contents.Add("var " + Name + ";");
                _contents.Add(Name + " = \"CODE:\";");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                initContent();
                for (int i = 2; i < _contents.Count; i++)
                {
                    string[] lineSplit = _contents[i].Split(new string[] { "+=" }, StringSplitOptions.None);
                    _contents[i] = _name + " +=" + lineSplit[1];
                }
            }
        }

        public List<string> Contents => _contents;

        public void Remove(int index)
        {
            _contents.RemoveAt(index);
        }

        public override string ToString()
        {
            return Name;
        }

        public void ContentSwap(int index, int upDown)
        {
            string temps;
            switch (upDown)
            {
                case 0:
                    if (index != 0)
                    {
                        temps = Contents[index];
                        Contents[index] = Contents[index - 1];
                        Contents[index - 1] = temps;
                    }
                    break;
                case 1:
                    if (index != Contents.Count - 1)
                    {
                        temps = Contents[index];
                        Contents[index] = Contents[index + 1];
                        Contents[index + 1] = temps;
                    }
                    break;
            }
        }
    }
}
