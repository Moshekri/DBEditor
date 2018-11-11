namespace DBEditor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.namesDGV = new System.Windows.Forms.DataGridView();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openDbDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.namesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search :";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(113, 16);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(338, 22);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // namesDGV
            // 
            this.namesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.namesDGV.Location = new System.Drawing.Point(32, 64);
            this.namesDGV.Name = "namesDGV";
            this.namesDGV.RowTemplate.Height = 24;
            this.namesDGV.Size = new System.Drawing.Size(419, 347);
            this.namesDGV.TabIndex = 2;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(32, 432);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(117, 34);
            this.btnLoadFile.TabIndex = 3;
            this.btnLoadFile.Text = "Load DB File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(182, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel Changes";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(334, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 34);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(335, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openDbDialog
            // 
            this.openDbDialog.FileName = "openDbDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 571);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.namesDGV);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.namesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView namesDGV;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openDbDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

