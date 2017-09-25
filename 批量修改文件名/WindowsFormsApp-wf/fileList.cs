using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp_wf
{
    //维护选中的文件
    internal class fileListClass
    {
        private static List<FileInfo> fileInfoList = new List<FileInfo>();

        private Action<string, string> DisplayStatus;

        private string newName;
        private string oldName;


        public fileListClass(Action<string,string> action)
        {
            DisplayStatus += action;
        }

        public FileInfo this[int index]
        {
            get
            { return fileInfoList[index]; }
            set
            { fileInfoList[index] = value; }
        }


        public string wantChangeType { get; set; }

        public void Add(FileInfo file)
        {
            fileInfoList.Add(file);
        }

        public void Clear()
        {
            fileInfoList.Clear();
        }

        public void doChanfe(string changeString)
        {
            if (wantChangeType == "后缀")
                changeByExtended(changeString);
            else if (wantChangeType == "文件名")
                changeByName(changeString);
            else if (wantChangeType == "文件名及后缀")
                changeAll(changeString);
            else
                MessageBox.Show("erro!");
        }

        

        private void changeByName(string ChangeString)
        {
            for (int i = 0; i < fileInfoList.Count; i++)
            {
                string[] fileNameSplit = fileInfoList[i].Name.Split('.');
                oldName = fileInfoList[i].Name;
                newName = fileInfoList[i].DirectoryName + "\\" + '(' + i + ')' + ChangeString + '.' + fileNameSplit[fileNameSplit.Length - 1];
                fileInfoList[i].MoveTo(newName);
                DisplayStatus(oldName, newName);
            }
        }

        private void changeByExtended(string ChangeString)
        {
            for (int i = 0; i < fileInfoList.Count; i++)
            {
                oldName = fileInfoList[i].Name;
                string[] nameSplit = fileInfoList[i].Name.Split('.');
                nameSplit[nameSplit.Length - 1] = ChangeString;
                newName = fileInfoList[i].DirectoryName + "\\" + string.Join(".", nameSplit);
                fileInfoList[i].MoveTo(newName);
                DisplayStatus(oldName, newName);

            }
        }

        private void changeAll(string ChangeString)
        {
            for (int i = 0; i < fileInfoList.Count; i++)
            {
                oldName = fileInfoList[i].Name;
                newName = fileInfoList[i].DirectoryName + "\\" + '(' + i + ')' + ChangeString;
                fileInfoList[i].MoveTo(newName);
                DisplayStatus(oldName, newName);

            }
        }
    }
}
