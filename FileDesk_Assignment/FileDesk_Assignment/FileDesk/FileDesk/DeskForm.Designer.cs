namespace FileDesk
{
    partial class DeskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDeskLeft = new System.Windows.Forms.Panel();
            this.grpDeskCreate = new System.Windows.Forms.GroupBox();
            this.btnDeskCreate = new System.Windows.Forms.Button();
            this.btnDeskFolder = new System.Windows.Forms.Button();
            this.btnDeskNewName = new System.Windows.Forms.Button();
            this.grpDeskWrite = new System.Windows.Forms.GroupBox();
            this.btnDeskWrite = new System.Windows.Forms.Button();
            this.btnDeskAppend = new System.Windows.Forms.Button();
            this.grpDeskManage = new System.Windows.Forms.GroupBox();
            this.btnDeskDelete = new System.Windows.Forms.Button();
            this.btnDeskClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeskName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeskInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeskOutput = new System.Windows.Forms.TextBox();
            this.pnlDeskRight = new System.Windows.Forms.Panel();
            this.grpDeskRead = new System.Windows.Forms.GroupBox();
            this.btnDeskRead = new System.Windows.Forms.Button();
            this.btnDeskReadLine = new System.Windows.Forms.Button();
            this.btnDeskReadAll = new System.Windows.Forms.Button();
            this.btnDeskReadChar = new System.Windows.Forms.Button();
            this.pnlDeskLeft.SuspendLayout();
            this.grpDeskCreate.SuspendLayout();
            this.grpDeskWrite.SuspendLayout();
            this.grpDeskManage.SuspendLayout();
            this.pnlDeskRight.SuspendLayout();
            this.grpDeskRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDeskLeft
            // 
            this.pnlDeskLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDeskLeft.Controls.Add(this.grpDeskCreate);
            this.pnlDeskLeft.Controls.Add(this.grpDeskWrite);
            this.pnlDeskLeft.Controls.Add(this.grpDeskManage);
            this.pnlDeskLeft.Location = new System.Drawing.Point(22, 115);
            this.pnlDeskLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDeskLeft.Name = "pnlDeskLeft";
            this.pnlDeskLeft.Size = new System.Drawing.Size(345, 846);
            this.pnlDeskLeft.TabIndex = 1;
            // 
            // grpDeskCreate
            // 
            this.grpDeskCreate.Controls.Add(this.btnDeskCreate);
            this.grpDeskCreate.Controls.Add(this.btnDeskFolder);
            this.grpDeskCreate.Controls.Add(this.btnDeskNewName);
            this.grpDeskCreate.Location = new System.Drawing.Point(15, 15);
            this.grpDeskCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDeskCreate.Name = "grpDeskCreate";
            this.grpDeskCreate.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDeskCreate.Size = new System.Drawing.Size(315, 231);
            this.grpDeskCreate.TabIndex = 0;
            this.grpDeskCreate.TabStop = false;
            this.grpDeskCreate.Text = "Create";
            // 
            // btnDeskCreate
            // 
            this.btnDeskCreate.Location = new System.Drawing.Point(15, 43);
            this.btnDeskCreate.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDeskCreate.Name = "btnDeskCreate";
            this.btnDeskCreate.Size = new System.Drawing.Size(285, 49);
            this.btnDeskCreate.TabIndex = 1;
            this.btnDeskCreate.Text = "Create File";
            this.btnDeskCreate.UseVisualStyleBackColor = true;
            this.btnDeskCreate.Click += new System.EventHandler(this.btnDeskCreate_Click);
            // 
            // btnDeskFolder
            // 
            this.btnDeskFolder.Location = new System.Drawing.Point(15, 105);
            this.btnDeskFolder.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDeskFolder.Name = "btnDeskFolder";
            this.btnDeskFolder.Size = new System.Drawing.Size(285, 49);
            this.btnDeskFolder.TabIndex = 2;
            this.btnDeskFolder.Text = "Create New File Path";
            this.btnDeskFolder.UseVisualStyleBackColor = true;
            this.btnDeskFolder.Click += new System.EventHandler(this.btnDeskFolder_Click);
            // 
            // btnDeskNewName
            // 
            this.btnDeskNewName.Location = new System.Drawing.Point(15, 166);
            this.btnDeskNewName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDeskNewName.Name = "btnDeskNewName";
            this.btnDeskNewName.Size = new System.Drawing.Size(285, 49);
            this.btnDeskNewName.TabIndex = 3;
            this.btnDeskNewName.Text = "Create New File Name";
            this.btnDeskNewName.UseVisualStyleBackColor = true;
            this.btnDeskNewName.Click += new System.EventHandler(this.btnDeskNewName_Click);
            // 
            // grpDeskWrite
            // 
            this.grpDeskWrite.Controls.Add(this.btnDeskWrite);
            this.grpDeskWrite.Controls.Add(this.btnDeskAppend);
            this.grpDeskWrite.Location = new System.Drawing.Point(15, 269);
            this.grpDeskWrite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDeskWrite.Name = "grpDeskWrite";
            this.grpDeskWrite.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDeskWrite.Size = new System.Drawing.Size(315, 169);
            this.grpDeskWrite.TabIndex = 1;
            this.grpDeskWrite.TabStop = false;
            this.grpDeskWrite.Text = "Write";
            // 
            // btnDeskWrite
            // 
            this.btnDeskWrite.Location = new System.Drawing.Point(15, 43);
            this.btnDeskWrite.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDeskWrite.Name = "btnDeskWrite";
            this.btnDeskWrite.Size = new System.Drawing.Size(285, 49);
            this.btnDeskWrite.TabIndex = 4;
            this.btnDeskWrite.Text = "Write File";
            this.btnDeskWrite.UseVisualStyleBackColor = true;
            this.btnDeskWrite.Click += new System.EventHandler(this.btnDeskWrite_Click);
            // 
            // btnDeskAppend
            // 
            this.btnDeskAppend.Location = new System.Drawing.Point(15, 105);
            this.btnDeskAppend.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDeskAppend.Name = "btnDeskAppend";
            this.btnDeskAppend.Size = new System.Drawing.Size(285, 49);
            this.btnDeskAppend.TabIndex = 5;
            this.btnDeskAppend.Text = "Append File";
            this.btnDeskAppend.UseVisualStyleBackColor = true;
            this.btnDeskAppend.Click += new System.EventHandler(this.btnDeskAppend_Click);
            // 
            // grpDeskManage
            // 
            this.grpDeskManage.Controls.Add(this.btnDeskDelete);
            this.grpDeskManage.Controls.Add(this.btnDeskClear);
            this.grpDeskManage.Location = new System.Drawing.Point(15, 462);
            this.grpDeskManage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDeskManage.Name = "grpDeskManage";
            this.grpDeskManage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDeskManage.Size = new System.Drawing.Size(315, 169);
            this.grpDeskManage.TabIndex = 2;
            this.grpDeskManage.TabStop = false;
            this.grpDeskManage.Text = "Manage";
            // 
            // btnDeskDelete
            // 
            this.btnDeskDelete.Location = new System.Drawing.Point(15, 43);
            this.btnDeskDelete.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDeskDelete.Name = "btnDeskDelete";
            this.btnDeskDelete.Size = new System.Drawing.Size(285, 49);
            this.btnDeskDelete.TabIndex = 6;
            this.btnDeskDelete.Text = "Delete File";
            this.btnDeskDelete.UseVisualStyleBackColor = true;
            this.btnDeskDelete.Click += new System.EventHandler(this.btnDeskDelete_Click);
            // 
            // btnDeskClear
            // 
            this.btnDeskClear.Location = new System.Drawing.Point(15, 105);
            this.btnDeskClear.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDeskClear.Name = "btnDeskClear";
            this.btnDeskClear.Size = new System.Drawing.Size(285, 49);
            this.btnDeskClear.TabIndex = 7;
            this.btnDeskClear.Text = "Clear";
            this.btnDeskClear.UseVisualStyleBackColor = true;
            this.btnDeskClear.Click += new System.EventHandler(this.btnDeskClear_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(398, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(810, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "File Name";
            // 
            // txtDeskName
            // 
            this.txtDeskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeskName.Location = new System.Drawing.Point(398, 163);
            this.txtDeskName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeskName.Name = "txtDeskName";
            this.txtDeskName.Size = new System.Drawing.Size(808, 26);
            this.txtDeskName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(398, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(810, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Text";
            // 
            // txtDeskInput
            // 
            this.txtDeskInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeskInput.Location = new System.Drawing.Point(398, 271);
            this.txtDeskInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeskInput.Multiline = true;
            this.txtDeskInput.Name = "txtDeskInput";
            this.txtDeskInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeskInput.Size = new System.Drawing.Size(808, 229);
            this.txtDeskInput.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(398, 528);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(810, 40);
            this.label4.TabIndex = 12;
            this.label4.Text = "File Content / Result";
            // 
            // txtDeskOutput
            // 
            this.txtDeskOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeskOutput.Location = new System.Drawing.Point(398, 571);
            this.txtDeskOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeskOutput.Multiline = true;
            this.txtDeskOutput.Name = "txtDeskOutput";
            this.txtDeskOutput.ReadOnly = true;
            this.txtDeskOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDeskOutput.Size = new System.Drawing.Size(808, 389);
            this.txtDeskOutput.TabIndex = 13;
            // 
            // pnlDeskRight
            // 
            this.pnlDeskRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDeskRight.Controls.Add(this.grpDeskRead);
            this.pnlDeskRight.Location = new System.Drawing.Point(1238, 115);
            this.pnlDeskRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDeskRight.Name = "pnlDeskRight";
            this.pnlDeskRight.Size = new System.Drawing.Size(330, 846);
            this.pnlDeskRight.TabIndex = 14;
            // 
            // grpDeskRead
            // 
            this.grpDeskRead.Controls.Add(this.btnDeskRead);
            this.grpDeskRead.Controls.Add(this.btnDeskReadLine);
            this.grpDeskRead.Controls.Add(this.btnDeskReadAll);
            this.grpDeskRead.Controls.Add(this.btnDeskReadChar);
            this.grpDeskRead.Location = new System.Drawing.Point(15, 15);
            this.grpDeskRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDeskRead.Name = "grpDeskRead";
            this.grpDeskRead.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDeskRead.Size = new System.Drawing.Size(300, 369);
            this.grpDeskRead.TabIndex = 0;
            this.grpDeskRead.TabStop = false;
            this.grpDeskRead.Text = "Read";
            // 
            // btnDeskRead
            // 
            this.btnDeskRead.Location = new System.Drawing.Point(15, 43);
            this.btnDeskRead.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDeskRead.Name = "btnDeskRead";
            this.btnDeskRead.Size = new System.Drawing.Size(270, 62);
            this.btnDeskRead.TabIndex = 14;
            this.btnDeskRead.Text = "Read File";
            this.btnDeskRead.UseVisualStyleBackColor = true;
            this.btnDeskRead.Click += new System.EventHandler(this.btnDeskRead_Click);
            // 
            // btnDeskReadLine
            // 
            this.btnDeskReadLine.Location = new System.Drawing.Point(15, 120);
            this.btnDeskReadLine.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDeskReadLine.Name = "btnDeskReadLine";
            this.btnDeskReadLine.Size = new System.Drawing.Size(270, 62);
            this.btnDeskReadLine.TabIndex = 15;
            this.btnDeskReadLine.Text = "Read Using ReadLine()";
            this.btnDeskReadLine.UseVisualStyleBackColor = true;
            this.btnDeskReadLine.Click += new System.EventHandler(this.btnDeskReadLine_Click);
            // 
            // btnDeskReadAll
            // 
            this.btnDeskReadAll.Location = new System.Drawing.Point(15, 197);
            this.btnDeskReadAll.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDeskReadAll.Name = "btnDeskReadAll";
            this.btnDeskReadAll.Size = new System.Drawing.Size(270, 62);
            this.btnDeskReadAll.TabIndex = 16;
            this.btnDeskReadAll.Text = "Read Using ReadAllText()";
            this.btnDeskReadAll.UseVisualStyleBackColor = true;
            this.btnDeskReadAll.Click += new System.EventHandler(this.btnDeskReadAll_Click);
            // 
            // btnDeskReadChar
            // 
            this.btnDeskReadChar.Location = new System.Drawing.Point(15, 274);
            this.btnDeskReadChar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnDeskReadChar.Name = "btnDeskReadChar";
            this.btnDeskReadChar.Size = new System.Drawing.Size(270, 62);
            this.btnDeskReadChar.TabIndex = 17;
            this.btnDeskReadChar.Text = "Read() Function";
            this.btnDeskReadChar.UseVisualStyleBackColor = true;
            this.btnDeskReadChar.Click += new System.EventHandler(this.btnDeskReadChar_Click);
            // 
            // DeskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 1000);
            this.Controls.Add(this.pnlDeskLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeskName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeskInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeskOutput);
            this.Controls.Add(this.pnlDeskRight);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1459, 924);
            this.Name = "DeskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileDesk - Manage Your Text Files";
            this.pnlDeskLeft.ResumeLayout(false);
            this.grpDeskCreate.ResumeLayout(false);
            this.grpDeskWrite.ResumeLayout(false);
            this.grpDeskManage.ResumeLayout(false);
            this.pnlDeskRight.ResumeLayout(false);
            this.grpDeskRead.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDeskLeft;
        private System.Windows.Forms.GroupBox grpDeskCreate;
        private System.Windows.Forms.Button btnDeskCreate;
        private System.Windows.Forms.Button btnDeskFolder;
        private System.Windows.Forms.Button btnDeskNewName;
        private System.Windows.Forms.GroupBox grpDeskWrite;
        private System.Windows.Forms.Button btnDeskWrite;
        private System.Windows.Forms.Button btnDeskAppend;
        private System.Windows.Forms.GroupBox grpDeskManage;
        private System.Windows.Forms.Button btnDeskDelete;
        private System.Windows.Forms.Button btnDeskClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeskInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeskOutput;
        private System.Windows.Forms.Panel pnlDeskRight;
        private System.Windows.Forms.GroupBox grpDeskRead;
        private System.Windows.Forms.Button btnDeskRead;
        private System.Windows.Forms.Button btnDeskReadLine;
        private System.Windows.Forms.Button btnDeskReadAll;
        private System.Windows.Forms.Button btnDeskReadChar;
    }
}
