using System;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp_wf
{
    public partial class myForm : Form
    {
        readonly string newline = Environment.NewLine;
        public myForm()
        {
            InitializeComponent();
            fileList = new fileListClass(this.DisplayStatus);
        }

        public void DisplayStatus(string oldName,string newName)
        {
            textBox1.Text += "文件:   " + oldName+newline+ "已改为:  " + newName+newline+newline;
        }


        private fileListClass fileList;

        private void chooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)               
            {
                //将选中文件添加到list并在textbox中显示
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    string filePass = openFileDialog1.FileNames[i];
                    FileInfo file = new FileInfo(filePass);
                    fileList.Add(file);
                    textBox1.Text += filePass + newline;
                }
                chooseFile.Enabled = false;
                reset.Enabled = true;
                confirm.Enabled = true;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            fileList.Clear();
            chooseFile.Enabled = true;
            reset.Enabled = false;
            confirm.Enabled = false;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (changeTypeOption.Text == "选择修改方式")
            {
                MessageBox.Show("选择修改方式");
                return;
            }
            string changeString = changeStringTextbox.Text;
            textBox1.Text += newline + newline + "开始！"+ newline + newline;
            fileList.doChanfe(changeString);
            textBox1.Text += newline + newline + "成功！";
            //滚动条移到最后一行
            textBox1.Select(textBox1.TextLength, 0);
            textBox1.ScrollToCaret();
            //打开资源管理器
            System.Diagnostics.Process.Start("explorer", fileList[0].DirectoryName);
            confirm.Enabled = false;
        }

        private void changeTypeOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileList.wantChangeType = Convert.ToString(changeTypeOption.SelectedItem);
        }

        private void myForm_Load(object sender, EventArgs e)
        {

        }
    }
}
