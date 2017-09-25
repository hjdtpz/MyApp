namespace WindowsFormsApp_wf
{
    partial class myForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myForm));
            this.chooseFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.changeTypeOption = new System.Windows.Forms.ComboBox();
            this.changeStringTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseFile
            // 
            this.chooseFile.Location = new System.Drawing.Point(352, 108);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(108, 23);
            this.chooseFile.TabIndex = 0;
            this.chooseFile.Text = "选择文件";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 110);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(321, 265);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(352, 152);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(108, 23);
            this.reset.TabIndex = 2;
            this.reset.Text = "重新选择";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // changeTypeOption
            // 
            this.changeTypeOption.FormattingEnabled = true;
            this.changeTypeOption.Items.AddRange(new object[] {
            "文件名及后缀",
            "后缀",
            "文件名"});
            this.changeTypeOption.Location = new System.Drawing.Point(352, 190);
            this.changeTypeOption.Name = "changeTypeOption";
            this.changeTypeOption.Size = new System.Drawing.Size(108, 20);
            this.changeTypeOption.TabIndex = 3;
            this.changeTypeOption.Text = "选择修改方式";
            this.changeTypeOption.SelectedIndexChanged += new System.EventHandler(this.changeTypeOption_SelectedIndexChanged);
            // 
            // changeStringTextbox
            // 
            this.changeStringTextbox.Location = new System.Drawing.Point(352, 253);
            this.changeStringTextbox.Name = "changeStringTextbox";
            this.changeStringTextbox.Size = new System.Drawing.Size(108, 21);
            this.changeStringTextbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "修改为";
            // 
            // confirm
            // 
            this.confirm.Enabled = false;
            this.confirm.Location = new System.Drawing.Point(371, 313);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 504);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeStringTextbox);
            this.Controls.Add(this.changeTypeOption);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chooseFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "myForm";
            this.Text = "批量修改文件名";
            this.Load += new System.EventHandler(this.myForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ComboBox changeTypeOption;
        private System.Windows.Forms.TextBox changeStringTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm;
    }
}

