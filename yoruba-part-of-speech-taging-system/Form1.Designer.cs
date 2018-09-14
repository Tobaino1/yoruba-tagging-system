namespace yoruba_part_of_speech_taging_system
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
            this.taggingbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tokenbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JJR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JJS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // taggingbox
            // 
            this.taggingbox.Location = new System.Drawing.Point(12, 42);
            this.taggingbox.Multiline = true;
            this.taggingbox.Name = "taggingbox";
            this.taggingbox.Size = new System.Drawing.Size(1026, 321);
            this.taggingbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SENTENCE";
            // 
            // tokenbox
            // 
            this.tokenbox.Location = new System.Drawing.Point(384, 389);
            this.tokenbox.Name = "tokenbox";
            this.tokenbox.Size = new System.Drawing.Size(652, 20);
            this.tokenbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOKENS :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CC,
            this.NN,
            this.CD,
            this.DT,
            this.EX,
            this.FW,
            this.IN,
            this.JJ,
            this.JJR,
            this.JJS,
            this.LS,
            this.MD});
            this.dataGridView1.Location = new System.Drawing.Point(10, 428);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1026, 184);
            this.dataGridView1.TabIndex = 6;
            // 
            // CC
            // 
            this.CC.HeaderText = "CC";
            this.CC.Name = "CC";
            // 
            // NN
            // 
            this.NN.HeaderText = "NN";
            this.NN.Name = "NN";
            // 
            // CD
            // 
            this.CD.HeaderText = "CD";
            this.CD.Name = "CD";
            // 
            // DT
            // 
            this.DT.HeaderText = "DT";
            this.DT.Name = "DT";
            // 
            // EX
            // 
            this.EX.HeaderText = "EX";
            this.EX.Name = "EX";
            // 
            // FW
            // 
            this.FW.HeaderText = "FW";
            this.FW.Name = "FW";
            // 
            // IN
            // 
            this.IN.HeaderText = "IN";
            this.IN.Name = "IN";
            // 
            // JJ
            // 
            this.JJ.HeaderText = "JJ";
            this.JJ.Name = "JJ";
            // 
            // JJR
            // 
            this.JJR.HeaderText = "JJR";
            this.JJR.Name = "JJR";
            // 
            // JJS
            // 
            this.JJS.HeaderText = "JJS";
            this.JJS.Name = "JJS";
            // 
            // LS
            // 
            this.LS.HeaderText = "LS";
            this.LS.Name = "LS";
            // 
            // MD
            // 
            this.MD.HeaderText = "MD";
            this.MD.Name = "MD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "PROCESS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "ERASE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1085, 658);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tokenbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taggingbox);
            this.Name = "Form1";
            this.Text = "YORUBA PART OF SPEECH TAGING SYSTEM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taggingbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tokenbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EX;
        private System.Windows.Forms.DataGridViewTextBoxColumn FW;
        private System.Windows.Forms.DataGridViewTextBoxColumn IN;
        private System.Windows.Forms.DataGridViewTextBoxColumn JJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn JJR;
        private System.Windows.Forms.DataGridViewTextBoxColumn JJS;
        private System.Windows.Forms.DataGridViewTextBoxColumn LS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

