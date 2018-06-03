using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace treeLook
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private static List<string> _tempDagitik = new List<string>();

        private void BtDonus_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            _tempDagitik = FindDelimiter(logText.Text, false, true);
            treeView1.Nodes.Add("Logs");
            for (var i = 0; i < _tempDagitik.Count; i++)
            {
                var indie = _tempDagitik[i];
                var start = indie.IndexOf("{", 0, StringComparison.Ordinal);
                var substring1 = indie.Substring(start, indie.Length - start);
                var substring2 = indie.Substring(0, start);
                treeView1.Nodes[0].Nodes.Add(substring2);
                treeView1.Nodes[0].Nodes[i].Nodes.Add(substring1);
            }
            treeView1.ExpandAll();
            treeView1.Nodes[0].EnsureVisible();
        }

        private static List<string> FindDelimiter(string strSource, bool skipFirst, bool indexCalc)
        {
            var firstDelimiter = 0;
            var firstIndex = 0;
            var secondDelimiter = 0;
            var secondIndex = 0;
            var dagitik = new List<string>();

            if (!strSource.Contains("{") || !strSource.Contains("}")) return dagitik;

            int counter;

            for (counter = 0; counter < strSource.Length; counter++)
            {
                switch (strSource[counter])
                {
                    case '{':
                        if (!skipFirst)
                        {
                            firstDelimiter++;
                        }

                        if (!indexCalc && firstDelimiter == 1)
                        {
                            firstIndex = counter + 1;
                            indexCalc = true;
                        }

                        skipFirst = false;
                        break;
                    case '}':
                        secondDelimiter++;
                        secondIndex = counter - firstIndex;
                        break;
                }

                if (firstDelimiter == 0 || firstDelimiter-secondDelimiter != 0) continue;
                dagitik.Add(strSource.Substring(firstIndex, secondIndex + 1));
                firstIndex = counter + 1;
                firstDelimiter = 0;
                secondDelimiter = 0;
            }

            return dagitik;
        }
    }
}
