using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiMonitor.Objects
{
    public class Script
    {
        private readonly List<Variables> _variables;
        private readonly List<string> _contents;
        private readonly List<Variables> _mainVariables;
        private Variables _login;
        private readonly List<Variables> _requireVar;

        public Script()
        {
            _variables = new List<Variables>();
            _contents = new List<string>();
            _mainVariables = new List<Variables>();
            _requireVar = new List<Variables>();
        }

        public void CreateScript()
        {
            _contents.Clear();
            foreach (var line in Login.Contents)
            {
                _contents.Add(line);
            }
            _contents.Add("");
            foreach (var VARIABLE in MainVariables)
            {
                foreach (var line in VARIABLE.Contents)
                {
                    _contents.Add(line);
                }
                _contents.Add("");
            }
            initRequireVar("/home/pi/iMacros/Log/pi02-suresnes_errorscreenlog", "pi02-suresnes", 20, 5, 6, 10);
            initlogicPart();
        }

        private void initlogicPart()
        {
            _contents.Add("var checkload;");
            _contents.Add("var count;");
            _contents.Add("var max=5;");
            _contents.Add("var n = 0;");
            _contents.Add("var tab = [];");
            foreach (var mainVar in MainVariables)
            {
                _contents.Add("tab.push("+mainVar.Name+");");
            }
            _contents.Add("");
            _contents.Add("iimPlay(login)");
            _contents.Add("");
            _contents.Add("while (true)	//Loop forever");
            _contents.Add("//set initial value and conditions and load first dashboard");
            _contents.Add("{");
            _contents.Add("\tif ( n == tab.length )");
            _contents.Add("\t{");
            _contents.Add("\t\tiimPlay(switchtabs);");
            _contents.Add("\t\tn=0;");
            _contents.Add("\t}");
            _contents.Add("\telse");
            _contents.Add("\t{");
            _contents.Add("\t\tcheckload=0;");
            _contents.Add("\t\tcount=0;");
            _contents.Add("\t\tif(n!==0) ");
            _contents.Add("\t\t{");
            _contents.Add("\t\t\tiimPlay(nexttab);");
            _contents.Add("\t\t}");
            _contents.Add("\t\twhile (checkload!==1 && count < max)");
            _contents.Add("\t\t{");
            _contents.Add("\t\t\tcheckload=iimPlay(tab[n]);");
            _contents.Add("\t\t\tcount++;");
            _contents.Add("\t\t}");
            _contents.Add("\t\t//if dashboard loading fail over max times, log out and log in again");
            _contents.Add("\t\tif (count==max)");
            _contents.Add("\t\t{");
            _contents.Add("\t\t\tiimPlay(login);");
            _contents.Add("\t\t\tn=0;");
            _contents.Add("\t\t}");
            _contents.Add("\t\telse");
            _contents.Add("\t\t{");
            _contents.Add("\t\t\tn++;");
            _contents.Add("\t\t}");
            _contents.Add("\t}");
            _contents.Add("}");
        }

        private void initRequireVar(string folder, string file,int waitTime, int tabcCount, int repeatTime,int waitBetweenTabs)
        {
            string pagedown = "\"" + @"\n" + "\";";
            _contents.Add("var screenshot;");
            _contents.Add("screenshot = \"CODE:\";");
            _contents.Add("screenshot += \"SCREENSHOT TYPE=Page FOLDER=" + folder + " FILE=" + file +
                          "_{{!NOW:dd-mm-yyyy<SP>hh-nn-ss}}.png" + "\" + " + pagedown);
            _contents.Add("");
            _contents.Add("var nexttab;");
            _contents.Add("nexttab = \"CODE:\";");
            _contents.Add("nexttab += \"TAB T=1" + "\" + " + pagedown);
            _contents.Add("nexttab += \"TAB T=2" + "\" + " + pagedown);
            _contents.Add("");
            _contents.Add("var wait;");
            _contents.Add("wait = \"CODE:\";");
            _contents.Add("wait += \"WAIT SECONDS=" + waitTime.ToString() + "\" + " + pagedown);
            _contents.Add("");
            _contents.Add("var switchtabs;");
            _contents.Add("switchtabs = \"CODE:\";");
            _contents.Add("switchtabs += \"TAB T=1" + "\" + " + pagedown);
            _contents.Add("for (i=0;i<" + repeatTime.ToString() + ";i++)");
            _contents.Add("{");
            for (int i = 0; i < tabcCount; i++)
            {
                _contents.Add("switchtabs += \"TAB T=" + (-tabcCount + 2 + i).ToString() + "\" + " + pagedown);
                _contents.Add("switchtabs += \"WAIT SECONDS=" + waitBetweenTabs.ToString() + "\" + " + pagedown);
            }
            _contents.Add("switchtabs += \"TAB T=" + (-tabcCount + 2).ToString() + "\" + " + pagedown);
            _contents.Add("}");
            _contents.Add("");
        }

        public List<Variables> Variables => _variables;

        public List<Variables> MainVariables => _mainVariables;

        public Variables Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public List<string> Contents => _contents;

        public void AddVariable(Variables v)
        {
            _variables.Add((v));
        }

        public void RemoveVariable(Variables v)
        {
            int index = _variables.IndexOf(v);
            if (index != -1)
            {
                _variables.RemoveAt(index);
            }
        }

        public void TestSave()
        {
            System.IO.File.WriteAllLines("test.js", Contents);
        }
    }
}
