using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Format_Statistic
{
    public partial class BaseForm : Form
    {
        private int index;
        private string FileName;
        private string FIleNameWithoutExtension;
        private string DirectoryName;
        private string FormattedName;
        private string line;
        private string[] Words;
        private Dictionary<string, int> WordsDict;
        private int wordsCount;
        private int lineCount;
        private StreamReader streamReader;
        private StreamWriter streamWriter;
        public BaseForm()
        {
            WordsDict = new Dictionary<string, int>();
            InitializeComponent();
        }

        private void FileOpenbutton_Click(object sender, EventArgs e)
        {
            //没必要设置初始文件夹
            //SourceCodeopenFileDialog.InitialDirectory=
            //只需要考虑.cs文件而非其他文件
            //SourceCodeopenFileDialog.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            SourceCodeopenFileDialog.Filter = "C#文件|*.cs";
            SourceCodeopenFileDialog.RestoreDirectory = true;
            SourceCodeopenFileDialog.FilterIndex = 1;
            if(SourceCodeopenFileDialog.ShowDialog()==DialogResult.OK)
            {
                FileName = SourceCodeopenFileDialog.FileName;
                FIleNameWithoutExtension= FileName.Split(new char[] { '\\', '.' }).Where(s=>!string.IsNullOrEmpty(s)).Where(s=>s!="cs").Last();
                DirectoryName = Path.GetDirectoryName(FileName);
                this.OriginPathLabel.Text = FileName;
                using (streamReader = new StreamReader(FileName,System.Text.Encoding.UTF8))
                {
                    while((line=streamReader.ReadLine())!=null)
                    {
                        line = line.Trim();
                        if(line.Trim()==string.Empty)
                        {

                        }
                        else
                        {
                            this.lineCount += 1;
                            Words=line.Split(new char[] { ' ', ',','，', ';', '.', '、','=','>','<',')','(',':','-','+','"' });
                            Words = Words.Where(s => !string.IsNullOrEmpty(s)).Where(s=>s!="}").Where(s=>s!="{").ToArray();
                            wordsCount += Words.Length;
                        }
                    }
                }
                this.OriginLineCountlabel.Text = lineCount.ToString();
                lineCount = 0;
                this.WordCountlabel.Text = wordsCount.ToString();
                wordsCount = 0;
            }
        }

        private void Formatbutton_Click(object sender, EventArgs e)
        {
            
            try
            {
                FormattedName = Path.Combine(DirectoryName, FIleNameWithoutExtension + "-1.cs");
                this.FormatedPathLabel.Text = FormattedName;
                FileStream fs = new FileStream(FormattedName, FileMode.Create, FileAccess.ReadWrite);

                
                using (streamReader = new StreamReader(FileName,System.Text.Encoding.UTF8))
                {
                    using(streamWriter = new StreamWriter(fs, System.Text.Encoding.UTF8))
                    {
                        while((line=streamReader.ReadLine())!=null)
                        {
                            if(line.Trim().StartsWith("//")||line.Trim()==string.Empty)
                            {
                                //说明为空行或者注释
                            }
                            else
                            {
                                index = line.LastIndexOf("//");
                                if (index>0)
                                {
                                    if(line[index-1]==';')
                                    {
                                        line = line.Substring(0, index - 1);
                                    }
                                }
                                streamWriter.WriteLine(line);
                                Words = line.Split(new char[] { ' ', ',', '，', ';', '.', '、', '=', '>', '<', ')', '(', ':','"', '-', '+' });
                                Words = Words.Where(s => !string.IsNullOrEmpty(s)).Where(s => s != "}").Where(s => s != "{").ToArray();
                                wordsCount += Words.Length;
                                foreach(string word in Words)
                                {
                                   
                                    if(WordsDict.Keys.Contains(word))
                                    {
                                        WordsDict[word] += 1;
                                    }
                                    else
                                    {
                                        WordsDict.Add(word, 1);
                                    }

                                }
                               

                            }
                        }
                        var WordsSort = from keyPair in WordsDict orderby keyPair.Value descending select keyPair;
                        //foreach(var dicItem in WordsSort)
                        //{
                        //    ListViewItem lvi = new ListViewItem();
                        //    lvi.Text = dicItem.Key;
                        //    lvi.SubItems.Add(dicItem.Value.ToString());
                        //    this.WordslistView.Items.Add(lvi);
                        //}
                        foreach (KeyValuePair<string, int> dicItem in WordsSort)
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = dicItem.Key;
                            lvi.SubItems.Add(dicItem.Value.ToString());
                            this.WordslistView.Items.Add(lvi);
                        }
                        //this.WordslistView.EndUpdate();
                    }
                }
                
               
            }
            catch(FileNotFoundException exception)
            {
                MessageBox.Show("你之前未选定相关.cs源文件\n"+exception.Message);
            }
           
        }
    }
}
