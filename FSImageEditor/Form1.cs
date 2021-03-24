using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace FSImageEditor
{
	public partial class Form1 : Form
	{
		Bitmap DrawArea;
		public Form1()
		{
			InitializeComponent();
			g = pictureBox1.CreateGraphics();
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			Blank();
		}
		bool startPaint = false;
		bool erase = false;
		Graphics g;
		bool drawSquare = false;
		bool drawRectangle = false;
		bool drawCircle = false;
		//Event fired when the mouse pointer is moved over the picturebox.
		private void Draw_MouseMove(object sender, MouseEventArgs e)
		{
			if(startPaint)
			{
				using (g = Graphics.FromImage(DrawArea))
				{
					if (!erase){
						//Setting the Pen BackColor and line Width
						Pen p = new Pen(btn_PenColor.BackColor, float.Parse(cmb_PenSize.Text));
						g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
						g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
						p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
						p.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
						p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
						//Drawing the line.
						g.DrawLine(p, e.X, e.Y, e.X + 1, e.Y + 1);
						pictureBox1.Image = DrawArea;
						pictureBox1.Update();
					}
					else {
						Pen p = new Pen(Color.Transparent, float.Parse(cmb_PenSize.Text));
						g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
						g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
						g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
						p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
						p.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
						p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
						g.DrawLine(p, e.X, e.Y, e.X + 1, e.Y + 1);
						pictureBox1.Image = DrawArea;
						pictureBox1.Update();
					}
				}
			}
		}
		//Event Fired when the mouse pointer is over picturebox and a mouse button is pressed
		private void Draw_MouseDown(object sender, MouseEventArgs e)
		{
			startPaint = true;
			using (g = Graphics.FromImage(DrawArea))
			{
				if (drawSquare)
				{
					//Use Solid Brush for filling the graphic shapes
					SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
					//setting the width and height same for creating square.
					//Getting the width and Heigt value from Textbox(txt_ShapeSize)
					g.FillRectangle(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
					drawSquare = false;
				}
				if (drawRectangle)
				{
					SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
					//setting the width twice of the height
					g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
					drawRectangle = false;
				}
				if (drawCircle)
				{
					SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
					g.FillEllipse(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
					drawCircle = false;
				}
			}
		}
		//Stops drawing when the mouse pointer is over the picturebox and a mouse button is released.
		void Draw_MouseUp(object sender, MouseEventArgs e)
		{
			startPaint = false;
		}
		//Button for Setting pen Color
		void Btn_PenColor_Click(object sender, EventArgs e)
		{
			//Open Color Dialog and Set BackColor of btn_PenColor if user click on OK
			ColorDialog c = new ColorDialog();
			if(c.ShowDialog()==DialogResult.OK)
			{
				btn_PenColor.BackColor = c.Color;
			}
		}
		//New & load
		void BlankCanvasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Blank();
		}
		void LoadImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png|Gif Image|*.gif";
			dialog.InitialDirectory = "c:\\";
			dialog.Title = "File Explorer";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = new Bitmap(dialog.FileName);
				Bitmap test = new Bitmap(dialog.FileName);
				FillPictureBox(pictureBox1, test);
				DrawArea = new Bitmap(pictureBox1.Image);
			}
		}
		//Save
		void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png|Gif Image|*.gif";
			save.InitialDirectory = "c:\\";
			if (save.ShowDialog() == DialogResult.OK)
			{
				Bitmap back = new Bitmap(pictureBox1.BackgroundImage);
				var tosave = MergedBitmaps(back, DrawArea);
				switch (save.FilterIndex)
				{
					case 1:
						tosave.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
						break;
					case 2:
						tosave.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
						break;
					case 3:
						tosave.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png);
						break;
					case 4:
						tosave.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Gif);
						break;
				}
			}
		}
		//Shapes
		void Btn_Square_Click(object sender, EventArgs e)
		{
			drawSquare = true;
		}
		void Btn_Rectangle_Click(object sender, EventArgs e)
		{
			drawRectangle = true;
		}
		void Btn_Circle_Click(object sender, EventArgs e)
		{
			drawCircle = true;
		}
		//Exit under File Menu
		void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Do you want to Exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
			{
				Application.Exit();
			}
		}
		//Resizes image to perfectly fit picturebox
		static public void FillPictureBox(PictureBox pbox, Bitmap bmp)
		{
			pbox.SizeMode = PictureBoxSizeMode.Normal;
			bool source_is_wider = (float)bmp.Width / bmp.Height > (float)pbox.Width / pbox.Height;
			var resized = new Bitmap(pbox.Width, pbox.Height);
			var g = Graphics.FromImage(resized);
			var dest_rect = new Rectangle(0, 0, pbox.Width, pbox.Height);
			Rectangle src_rect;
			if (source_is_wider)
			{
				float size_ratio = (float)pbox.Height / bmp.Height;
				int sample_width = (int)(pbox.Width / size_ratio);
				src_rect = new Rectangle((bmp.Width - sample_width) / 2, 0, sample_width, bmp.Height);
			}
			else
			{
				float size_ratio = (float)pbox.Width / bmp.Width;
				int sample_height = (int)(pbox.Height / size_ratio);
				src_rect = new Rectangle(0, (bmp.Height - sample_height) / 2, bmp.Width, sample_height);
			}
			g.DrawImage(bmp, dest_rect, src_rect, GraphicsUnit.Pixel);
			g.Dispose();
			pbox.Image = resized;
			pbox.BackgroundImage = resized;
		}
		//Creates a blank canvas
		void Blank()
		{
			Image blank = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Images\blank.png"));
			pictureBox1.Image = new Bitmap(blank);
			Bitmap test = new Bitmap(blank);
			FillPictureBox(pictureBox1, test);
			DrawArea = new Bitmap(pictureBox1.Image);
		}
		//Toggles eraser
		void _buttEraseClick(object sender, EventArgs e)
		{
			if (!erase){
				erase = true;
				btn_Erase.BackColor = Color.IndianRed;
			}
			else {
				erase = false;
				btn_Erase.BackColor = Color.Silver;
			}
		}
		Bitmap MergedBitmaps(Bitmap bmp1, Bitmap bmp2) {
			Bitmap result = new Bitmap(Math.Max(bmp1.Width, bmp2.Width),Math.Max(bmp1.Height, bmp2.Height));
			using (Graphics g = Graphics.FromImage(result)) {
				g.DrawImage(bmp1, Point.Empty);
				g.DrawImage(bmp2, Point.Empty);
			}
			return result;
		}
	}
}
