namespace Steganography
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPixelColorOriginal = new System.Windows.Forms.TextBox();
            this.tbPixelColorCoded = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSaveCodedPic = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBlueCodedPic = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGreenCodedPic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbRedCodedPic = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGetXYPixelCodedPic = new System.Windows.Forms.Button();
            this.tbYCodedPic = new System.Windows.Forms.TextBox();
            this.tbXCodedPic = new System.Windows.Forms.TextBox();
            this.pbCodedPic = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBlueOriginalPic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbGreenOriginalPic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRedOriginalPic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetXYPixelOriginalPic = new System.Windows.Forms.Button();
            this.tbYOriginalPic = new System.Windows.Forms.TextBox();
            this.tbXOriginalPic = new System.Windows.Forms.TextBox();
            this.btnWriteTextInPic = new System.Windows.Forms.Button();
            this.tbInputText = new System.Windows.Forms.TextBox();
            this.btnOpenOriginalPic = new System.Windows.Forms.Button();
            this.pbOriginalPic = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOpenCodedPic = new System.Windows.Forms.Button();
            this.btnReadTextFromPic = new System.Windows.Forms.Button();
            this.tbOutputText = new System.Windows.Forms.TextBox();
            this.pbOpenedCodedPic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodedPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalPic)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenedCodedPic)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPixelColorOriginal);
            this.groupBox1.Controls.Add(this.tbPixelColorCoded);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnSaveCodedPic);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbBlueCodedPic);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbGreenCodedPic);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbRedCodedPic);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnGetXYPixelCodedPic);
            this.groupBox1.Controls.Add(this.tbYCodedPic);
            this.groupBox1.Controls.Add(this.tbXCodedPic);
            this.groupBox1.Controls.Add(this.pbCodedPic);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbBlueOriginalPic);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbGreenOriginalPic);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbRedOriginalPic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGetXYPixelOriginalPic);
            this.groupBox1.Controls.Add(this.tbYOriginalPic);
            this.groupBox1.Controls.Add(this.tbXOriginalPic);
            this.groupBox1.Controls.Add(this.btnWriteTextInPic);
            this.groupBox1.Controls.Add(this.tbInputText);
            this.groupBox1.Controls.Add(this.btnOpenOriginalPic);
            this.groupBox1.Controls.Add(this.pbOriginalPic);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 565);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encoder";
            // 
            // tbPixelColorOriginal
            // 
            this.tbPixelColorOriginal.BackColor = System.Drawing.Color.White;
            this.tbPixelColorOriginal.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tbPixelColorOriginal.Location = new System.Drawing.Point(434, 230);
            this.tbPixelColorOriginal.Multiline = true;
            this.tbPixelColorOriginal.Name = "tbPixelColorOriginal";
            this.tbPixelColorOriginal.ReadOnly = true;
            this.tbPixelColorOriginal.Size = new System.Drawing.Size(32, 32);
            this.tbPixelColorOriginal.TabIndex = 29;
            // 
            // tbPixelColorCoded
            // 
            this.tbPixelColorCoded.BackColor = System.Drawing.Color.White;
            this.tbPixelColorCoded.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tbPixelColorCoded.Location = new System.Drawing.Point(434, 527);
            this.tbPixelColorCoded.Multiline = true;
            this.tbPixelColorCoded.Name = "tbPixelColorCoded";
            this.tbPixelColorCoded.ReadOnly = true;
            this.tbPixelColorCoded.Size = new System.Drawing.Size(32, 32);
            this.tbPixelColorCoded.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(128, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Enter Your Text Here:";
            // 
            // btnSaveCodedPic
            // 
            this.btnSaveCodedPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveCodedPic.Location = new System.Drawing.Point(151, 533);
            this.btnSaveCodedPic.Name = "btnSaveCodedPic";
            this.btnSaveCodedPic.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCodedPic.TabIndex = 27;
            this.btnSaveCodedPic.Text = "Save Image";
            this.btnSaveCodedPic.UseVisualStyleBackColor = true;
            this.btnSaveCodedPic.Click += new System.EventHandler(this.btnSaveCodedPic_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(371, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Blue";
            // 
            // tbBlueCodedPic
            // 
            this.tbBlueCodedPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbBlueCodedPic.Location = new System.Drawing.Point(405, 498);
            this.tbBlueCodedPic.Name = "tbBlueCodedPic";
            this.tbBlueCodedPic.Size = new System.Drawing.Size(92, 20);
            this.tbBlueCodedPic.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(363, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Green";
            // 
            // tbGreenCodedPic
            // 
            this.tbGreenCodedPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbGreenCodedPic.Location = new System.Drawing.Point(405, 470);
            this.tbGreenCodedPic.Name = "tbGreenCodedPic";
            this.tbGreenCodedPic.Size = new System.Drawing.Size(92, 20);
            this.tbGreenCodedPic.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(372, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Red";
            // 
            // tbRedCodedPic
            // 
            this.tbRedCodedPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbRedCodedPic.Location = new System.Drawing.Point(405, 444);
            this.tbRedCodedPic.Name = "tbRedCodedPic";
            this.tbRedCodedPic.Size = new System.Drawing.Size(92, 20);
            this.tbRedCodedPic.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "X";
            // 
            // btnGetXYPixelCodedPic
            // 
            this.btnGetXYPixelCodedPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGetXYPixelCodedPic.Location = new System.Drawing.Point(405, 398);
            this.btnGetXYPixelCodedPic.Name = "btnGetXYPixelCodedPic";
            this.btnGetXYPixelCodedPic.Size = new System.Drawing.Size(92, 23);
            this.btnGetXYPixelCodedPic.TabIndex = 18;
            this.btnGetXYPixelCodedPic.Text = "Get Pixel Info";
            this.btnGetXYPixelCodedPic.UseVisualStyleBackColor = true;
            this.btnGetXYPixelCodedPic.Click += new System.EventHandler(this.btnGetXYPixelCodedPic_Click);
            // 
            // tbYCodedPic
            // 
            this.tbYCodedPic.Location = new System.Drawing.Point(405, 372);
            this.tbYCodedPic.Name = "tbYCodedPic";
            this.tbYCodedPic.Size = new System.Drawing.Size(92, 20);
            this.tbYCodedPic.TabIndex = 17;
            // 
            // tbXCodedPic
            // 
            this.tbXCodedPic.Location = new System.Drawing.Point(405, 346);
            this.tbXCodedPic.Name = "tbXCodedPic";
            this.tbXCodedPic.Size = new System.Drawing.Size(92, 20);
            this.tbXCodedPic.TabIndex = 16;
            // 
            // pbCodedPic
            // 
            this.pbCodedPic.Location = new System.Drawing.Point(9, 346);
            this.pbCodedPic.Name = "pbCodedPic";
            this.pbCodedPic.Size = new System.Drawing.Size(344, 173);
            this.pbCodedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCodedPic.TabIndex = 15;
            this.pbCodedPic.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(371, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Blue";
            // 
            // tbBlueOriginalPic
            // 
            this.tbBlueOriginalPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbBlueOriginalPic.Location = new System.Drawing.Point(405, 202);
            this.tbBlueOriginalPic.Name = "tbBlueOriginalPic";
            this.tbBlueOriginalPic.Size = new System.Drawing.Size(92, 20);
            this.tbBlueOriginalPic.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(363, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Green";
            // 
            // tbGreenOriginalPic
            // 
            this.tbGreenOriginalPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbGreenOriginalPic.Location = new System.Drawing.Point(405, 174);
            this.tbGreenOriginalPic.Name = "tbGreenOriginalPic";
            this.tbGreenOriginalPic.Size = new System.Drawing.Size(92, 20);
            this.tbGreenOriginalPic.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(372, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Red";
            // 
            // tbRedOriginalPic
            // 
            this.tbRedOriginalPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbRedOriginalPic.Location = new System.Drawing.Point(405, 148);
            this.tbRedOriginalPic.Name = "tbRedOriginalPic";
            this.tbRedOriginalPic.Size = new System.Drawing.Size(92, 20);
            this.tbRedOriginalPic.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // btnGetXYPixelOriginalPic
            // 
            this.btnGetXYPixelOriginalPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGetXYPixelOriginalPic.Location = new System.Drawing.Point(405, 102);
            this.btnGetXYPixelOriginalPic.Name = "btnGetXYPixelOriginalPic";
            this.btnGetXYPixelOriginalPic.Size = new System.Drawing.Size(92, 23);
            this.btnGetXYPixelOriginalPic.TabIndex = 6;
            this.btnGetXYPixelOriginalPic.Text = "Get Pixel Info";
            this.btnGetXYPixelOriginalPic.UseVisualStyleBackColor = true;
            this.btnGetXYPixelOriginalPic.Click += new System.EventHandler(this.btnGetXYPixelOriginalPic_Click);
            // 
            // tbYOriginalPic
            // 
            this.tbYOriginalPic.Location = new System.Drawing.Point(405, 76);
            this.tbYOriginalPic.Name = "tbYOriginalPic";
            this.tbYOriginalPic.Size = new System.Drawing.Size(92, 20);
            this.tbYOriginalPic.TabIndex = 5;
            // 
            // tbXOriginalPic
            // 
            this.tbXOriginalPic.Location = new System.Drawing.Point(405, 50);
            this.tbXOriginalPic.Name = "tbXOriginalPic";
            this.tbXOriginalPic.Size = new System.Drawing.Size(92, 20);
            this.tbXOriginalPic.TabIndex = 4;
            // 
            // btnWriteTextInPic
            // 
            this.btnWriteTextInPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWriteTextInPic.Location = new System.Drawing.Point(122, 311);
            this.btnWriteTextInPic.Name = "btnWriteTextInPic";
            this.btnWriteTextInPic.Size = new System.Drawing.Size(116, 23);
            this.btnWriteTextInPic.TabIndex = 3;
            this.btnWriteTextInPic.Text = "Write Text In Image";
            this.btnWriteTextInPic.UseVisualStyleBackColor = true;
            this.btnWriteTextInPic.Click += new System.EventHandler(this.btnWriteTextInPic_Click);
            // 
            // tbInputText
            // 
            this.tbInputText.Font = new System.Drawing.Font("IRANSans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbInputText.Location = new System.Drawing.Point(9, 265);
            this.tbInputText.Name = "tbInputText";
            this.tbInputText.Size = new System.Drawing.Size(344, 40);
            this.tbInputText.TabIndex = 2;
            // 
            // btnOpenOriginalPic
            // 
            this.btnOpenOriginalPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpenOriginalPic.Location = new System.Drawing.Point(151, 16);
            this.btnOpenOriginalPic.Name = "btnOpenOriginalPic";
            this.btnOpenOriginalPic.Size = new System.Drawing.Size(75, 23);
            this.btnOpenOriginalPic.TabIndex = 1;
            this.btnOpenOriginalPic.Text = "Open Image";
            this.btnOpenOriginalPic.UseVisualStyleBackColor = true;
            this.btnOpenOriginalPic.Click += new System.EventHandler(this.btnOpenOriginalPic_Click);
            // 
            // pbOriginalPic
            // 
            this.pbOriginalPic.Location = new System.Drawing.Point(9, 48);
            this.pbOriginalPic.Name = "pbOriginalPic";
            this.pbOriginalPic.Size = new System.Drawing.Size(344, 173);
            this.pbOriginalPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginalPic.TabIndex = 0;
            this.pbOriginalPic.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnOpenCodedPic);
            this.groupBox2.Controls.Add(this.btnReadTextFromPic);
            this.groupBox2.Controls.Add(this.tbOutputText);
            this.groupBox2.Controls.Add(this.pbOpenedCodedPic);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(524, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 565);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decoder";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 460);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Enter Your Text Here:";
            // 
            // btnOpenCodedPic
            // 
            this.btnOpenCodedPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpenCodedPic.Location = new System.Drawing.Point(223, 16);
            this.btnOpenCodedPic.Name = "btnOpenCodedPic";
            this.btnOpenCodedPic.Size = new System.Drawing.Size(75, 23);
            this.btnOpenCodedPic.TabIndex = 29;
            this.btnOpenCodedPic.Text = "Open Image";
            this.btnOpenCodedPic.UseVisualStyleBackColor = true;
            this.btnOpenCodedPic.Click += new System.EventHandler(this.btnOpenCodedPic_Click);
            // 
            // btnReadTextFromPic
            // 
            this.btnReadTextFromPic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReadTextFromPic.Location = new System.Drawing.Point(185, 404);
            this.btnReadTextFromPic.Name = "btnReadTextFromPic";
            this.btnReadTextFromPic.Size = new System.Drawing.Size(135, 30);
            this.btnReadTextFromPic.TabIndex = 30;
            this.btnReadTextFromPic.Text = "Read Text From Image";
            this.btnReadTextFromPic.UseVisualStyleBackColor = true;
            this.btnReadTextFromPic.Click += new System.EventHandler(this.btnReadTextFromPic_Click);
            // 
            // tbOutputText
            // 
            this.tbOutputText.Font = new System.Drawing.Font("IRANSans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbOutputText.Location = new System.Drawing.Point(82, 498);
            this.tbOutputText.Name = "tbOutputText";
            this.tbOutputText.Size = new System.Drawing.Size(344, 40);
            this.tbOutputText.TabIndex = 29;
            // 
            // pbOpenedCodedPic
            // 
            this.pbOpenedCodedPic.Location = new System.Drawing.Point(23, 48);
            this.pbOpenedCodedPic.Name = "pbOpenedCodedPic";
            this.pbOpenedCodedPic.Size = new System.Drawing.Size(470, 314);
            this.pbOpenedCodedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOpenedCodedPic.TabIndex = 0;
            this.pbOpenedCodedPic.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 571);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 595);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steganography";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodedPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalPic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenedCodedPic)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOriginalPic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbOpenedCodedPic;
        private System.Windows.Forms.Button btnOpenOriginalPic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbInputText;
        private System.Windows.Forms.Button btnWriteTextInPic;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveCodedPic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBlueCodedPic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGreenCodedPic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRedCodedPic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGetXYPixelCodedPic;
        private System.Windows.Forms.TextBox tbYCodedPic;
        private System.Windows.Forms.TextBox tbXCodedPic;
        private System.Windows.Forms.PictureBox pbCodedPic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBlueOriginalPic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGreenOriginalPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRedOriginalPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetXYPixelOriginalPic;
        private System.Windows.Forms.TextBox tbYOriginalPic;
        private System.Windows.Forms.TextBox tbXOriginalPic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnOpenCodedPic;
        private System.Windows.Forms.Button btnReadTextFromPic;
        private System.Windows.Forms.TextBox tbOutputText;
        private System.Windows.Forms.TextBox tbPixelColorOriginal;
        private System.Windows.Forms.TextBox tbPixelColorCoded;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

