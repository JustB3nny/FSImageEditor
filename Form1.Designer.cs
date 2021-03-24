namespace FSImageEditor
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
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.panel7 = new System.Windows.Forms.Panel();
        	this.txt_ShapeSize = new System.Windows.Forms.TextBox();
        	this.lab_ShapeSize = new System.Windows.Forms.Label();
        	this.btn_Circle = new System.Windows.Forms.Button();
        	this.btn_Rectangle = new System.Windows.Forms.Button();
        	this.btn_Square = new System.Windows.Forms.Button();
        	this.panel8 = new System.Windows.Forms.Panel();
        	this.lab_DrawShapes = new System.Windows.Forms.Label();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.btn_Erase = new System.Windows.Forms.Button();
        	this.panel6 = new System.Windows.Forms.Panel();
        	this.lab_PenTool = new System.Windows.Forms.Label();
        	this.btn_PenColor = new System.Windows.Forms.Button();
        	this.cmb_PenSize = new System.Windows.Forms.ComboBox();
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.blankCanvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.panel1.SuspendLayout();
        	this.panel7.SuspendLayout();
        	this.panel8.SuspendLayout();
        	this.panel2.SuspendLayout();
        	this.panel6.SuspendLayout();
        	this.menuStrip1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// panel1
        	// 
        	this.panel1.BackColor = System.Drawing.Color.DimGray;
        	this.panel1.Controls.Add(this.panel7);
        	this.panel1.Controls.Add(this.panel2);
        	this.panel1.Location = new System.Drawing.Point(0, 21);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(140, 433);
        	this.panel1.TabIndex = 0;
        	// 
        	// panel7
        	// 
        	this.panel7.BackColor = System.Drawing.Color.Gray;
        	this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel7.Controls.Add(this.txt_ShapeSize);
        	this.panel7.Controls.Add(this.lab_ShapeSize);
        	this.panel7.Controls.Add(this.btn_Circle);
        	this.panel7.Controls.Add(this.btn_Rectangle);
        	this.panel7.Controls.Add(this.btn_Square);
        	this.panel7.Controls.Add(this.panel8);
        	this.panel7.Location = new System.Drawing.Point(5, 145);
        	this.panel7.Name = "panel7";
        	this.panel7.Size = new System.Drawing.Size(130, 184);
        	this.panel7.TabIndex = 3;
        	// 
        	// txt_ShapeSize
        	// 
        	this.txt_ShapeSize.BackColor = System.Drawing.Color.Silver;
        	this.txt_ShapeSize.Location = new System.Drawing.Point(3, 153);
        	this.txt_ShapeSize.Name = "txt_ShapeSize";
        	this.txt_ShapeSize.Size = new System.Drawing.Size(122, 20);
        	this.txt_ShapeSize.TabIndex = 9;
        	this.txt_ShapeSize.Text = "10";
        	// 
        	// lab_ShapeSize
        	// 
        	this.lab_ShapeSize.AutoSize = true;
        	this.lab_ShapeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lab_ShapeSize.Location = new System.Drawing.Point(6, 137);
        	this.lab_ShapeSize.Name = "lab_ShapeSize";
        	this.lab_ShapeSize.Size = new System.Drawing.Size(71, 13);
        	this.lab_ShapeSize.TabIndex = 8;
        	this.lab_ShapeSize.Text = "Shape Size";
        	// 
        	// btn_Circle
        	// 
        	this.btn_Circle.BackColor = System.Drawing.Color.Silver;
        	this.btn_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btn_Circle.Location = new System.Drawing.Point(3, 100);
        	this.btn_Circle.Name = "btn_Circle";
        	this.btn_Circle.Size = new System.Drawing.Size(122, 28);
        	this.btn_Circle.TabIndex = 7;
        	this.btn_Circle.Text = "Circle";
        	this.btn_Circle.UseVisualStyleBackColor = false;
        	this.btn_Circle.Click += new System.EventHandler(this.Btn_Circle_Click);
        	// 
        	// btn_Rectangle
        	// 
        	this.btn_Rectangle.BackColor = System.Drawing.Color.Silver;
        	this.btn_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btn_Rectangle.Location = new System.Drawing.Point(3, 66);
        	this.btn_Rectangle.Name = "btn_Rectangle";
        	this.btn_Rectangle.Size = new System.Drawing.Size(122, 28);
        	this.btn_Rectangle.TabIndex = 6;
        	this.btn_Rectangle.Text = "Rectangle";
        	this.btn_Rectangle.UseVisualStyleBackColor = false;
        	this.btn_Rectangle.Click += new System.EventHandler(this.Btn_Rectangle_Click);
        	// 
        	// btn_Square
        	// 
        	this.btn_Square.BackColor = System.Drawing.Color.Silver;
        	this.btn_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btn_Square.Location = new System.Drawing.Point(3, 32);
        	this.btn_Square.Name = "btn_Square";
        	this.btn_Square.Size = new System.Drawing.Size(122, 28);
        	this.btn_Square.TabIndex = 5;
        	this.btn_Square.Text = "Square";
        	this.btn_Square.UseVisualStyleBackColor = false;
        	this.btn_Square.Click += new System.EventHandler(this.Btn_Square_Click);
        	// 
        	// panel8
        	// 
        	this.panel8.BackColor = System.Drawing.Color.DarkGray;
        	this.panel8.Controls.Add(this.lab_DrawShapes);
        	this.panel8.Location = new System.Drawing.Point(0, 0);
        	this.panel8.Name = "panel8";
        	this.panel8.Size = new System.Drawing.Size(130, 27);
        	this.panel8.TabIndex = 1;
        	// 
        	// lab_DrawShapes
        	// 
        	this.lab_DrawShapes.AutoSize = true;
        	this.lab_DrawShapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lab_DrawShapes.ForeColor = System.Drawing.Color.Black;
        	this.lab_DrawShapes.Location = new System.Drawing.Point(15, 5);
        	this.lab_DrawShapes.Name = "lab_DrawShapes";
        	this.lab_DrawShapes.Size = new System.Drawing.Size(100, 16);
        	this.lab_DrawShapes.TabIndex = 1;
        	this.lab_DrawShapes.Text = "Draw Shapes";
        	// 
        	// panel2
        	// 
        	this.panel2.BackColor = System.Drawing.Color.Gray;
        	this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel2.Controls.Add(this.btn_Erase);
        	this.panel2.Controls.Add(this.panel6);
        	this.panel2.Controls.Add(this.btn_PenColor);
        	this.panel2.Controls.Add(this.cmb_PenSize);
        	this.panel2.Location = new System.Drawing.Point(5, 6);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(130, 133);
        	this.panel2.TabIndex = 1;
        	// 
        	// btn_Erase
        	// 
        	this.btn_Erase.Location = new System.Drawing.Point(4, 99);
        	this.btn_Erase.Name = "btn_Erase";
        	this.btn_Erase.Size = new System.Drawing.Size(122, 28);
        	this.btn_Erase.TabIndex = 4;
        	this.btn_Erase.Text = "Erase";
        	this.btn_Erase.UseVisualStyleBackColor = true;
        	this.btn_Erase.Click += new System.EventHandler(this._buttEraseClick);
        	// 
        	// panel6
        	// 
        	this.panel6.BackColor = System.Drawing.Color.DarkGray;
        	this.panel6.Controls.Add(this.lab_PenTool);
        	this.panel6.Location = new System.Drawing.Point(0, 0);
        	this.panel6.Name = "panel6";
        	this.panel6.Size = new System.Drawing.Size(130, 27);
        	this.panel6.TabIndex = 2;
        	// 
        	// lab_PenTool
        	// 
        	this.lab_PenTool.AutoSize = true;
        	this.lab_PenTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lab_PenTool.ForeColor = System.Drawing.Color.Black;
        	this.lab_PenTool.Location = new System.Drawing.Point(27, 5);
        	this.lab_PenTool.Name = "lab_PenTool";
        	this.lab_PenTool.Size = new System.Drawing.Size(71, 16);
        	this.lab_PenTool.TabIndex = 1;
        	this.lab_PenTool.Text = "Pen Tool";
        	// 
        	// btn_PenColor
        	// 
        	this.btn_PenColor.BackColor = System.Drawing.Color.Black;
        	this.btn_PenColor.Location = new System.Drawing.Point(4, 65);
        	this.btn_PenColor.Name = "btn_PenColor";
        	this.btn_PenColor.Size = new System.Drawing.Size(122, 28);
        	this.btn_PenColor.TabIndex = 2;
        	this.btn_PenColor.UseVisualStyleBackColor = false;
        	this.btn_PenColor.Click += new System.EventHandler(this.Btn_PenColor_Click);
        	// 
        	// cmb_PenSize
        	// 
        	this.cmb_PenSize.BackColor = System.Drawing.Color.Silver;
        	this.cmb_PenSize.FormattingEnabled = true;
        	this.cmb_PenSize.Items.AddRange(new object[] {
			"1",
			"2",
			"3",
			"4"});
        	this.cmb_PenSize.Location = new System.Drawing.Point(4, 38);
        	this.cmb_PenSize.Name = "cmb_PenSize";
        	this.cmb_PenSize.Size = new System.Drawing.Size(122, 21);
        	this.cmb_PenSize.TabIndex = 1;
        	this.cmb_PenSize.Text = "1";
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Size = new System.Drawing.Size(744, 24);
        	this.menuStrip1.TabIndex = 1;
        	this.menuStrip1.Text = "menuStrip1";
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.newToolStripMenuItem,
			this.saveToolStripMenuItem,
			this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem.Text = "File";
        	// 
        	// newToolStripMenuItem
        	// 
        	this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.blankCanvasToolStripMenuItem,
			this.loadImageToolStripMenuItem});
        	this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        	this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.newToolStripMenuItem.Text = "New";
        	// 
        	// blankCanvasToolStripMenuItem
        	// 
        	this.blankCanvasToolStripMenuItem.Name = "blankCanvasToolStripMenuItem";
        	this.blankCanvasToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        	this.blankCanvasToolStripMenuItem.Text = "Blank Canvas";
        	this.blankCanvasToolStripMenuItem.Click += new System.EventHandler(this.BlankCanvasToolStripMenuItem_Click);
        	// 
        	// loadImageToolStripMenuItem
        	// 
        	this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
        	this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
        	this.loadImageToolStripMenuItem.Text = "Load Image";
        	this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.LoadImageToolStripMenuItem_Click);
        	// 
        	// saveToolStripMenuItem
        	// 
        	this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        	this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.saveToolStripMenuItem.Text = "Save";
        	this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.exitToolStripMenuItem.Text = "Exit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Location = new System.Drawing.Point(142, 21);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(602, 433);
        	this.pictureBox1.TabIndex = 2;
        	this.pictureBox1.TabStop = false;
        	this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draw_MouseDown);
        	this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draw_MouseMove);
        	this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draw_MouseUp);
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.DimGray;
        	this.ClientSize = new System.Drawing.Size(744, 451);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.menuStrip1);
        	this.DoubleBuffered = true;
        	this.MaximizeBox = false;
        	this.Name = "Form1";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "FSImage Editor";
        	this.panel1.ResumeLayout(false);
        	this.panel7.ResumeLayout(false);
        	this.panel7.PerformLayout();
        	this.panel8.ResumeLayout(false);
        	this.panel8.PerformLayout();
        	this.panel2.ResumeLayout(false);
        	this.panel6.ResumeLayout(false);
        	this.panel6.PerformLayout();
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_PenSize;
        private System.Windows.Forms.Button btn_PenColor;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lab_PenTool;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_ShapeSize;
        private System.Windows.Forms.Label lab_ShapeSize;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_Square;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lab_DrawShapes;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blankCanvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Erase;
    }
}

