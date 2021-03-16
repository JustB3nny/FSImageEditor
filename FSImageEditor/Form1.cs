using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace MiniPaint
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
        Graphics g;
        //nullable int for storing Null value
        bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false;
        //Event fired when the mouse pointer is moved over the Panel(pnl_Draw).
        private void Pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if(startPaint)
            {
                using (g = Graphics.FromImage(DrawArea))
                {
                    //Setting the Pen BackColor and line Width
                    Pen p = new Pen(btn_PenColor.BackColor, float.Parse(cmb_PenSize.Text));
                    //Drawing the line.
                    g.DrawLine(p, e.X, e.Y, e.X + 1, e.Y + 1);
                    pictureBox1.Image = DrawArea;
                    pictureBox1.Update();
                }
            }
        }
        //Event Fired when the mouse pointer is over Panel and a mouse button is pressed
        private void Pnl_Draw_MouseDown(object sender, MouseEventArgs e)
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
        //Fired when the mouse pointer is over the pnl_Draw and a mouse button is released.
        private void Pnl_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
        }
        //Button for Setting pen Color
        private void Button1_Click(object sender, EventArgs e)
        {
            //Open Color Dialog and Set BackColor of btn_PenColor if user click on OK
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog()==DialogResult.OK)
            {
                btn_PenColor.BackColor = c.Color;
            }
        }
        //New 
        private void BlankCanvasToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png|Gif Image|*.gif";
            save.InitialDirectory = "c:\\";
            if (save.ShowDialog() == DialogResult.OK)
            {
                    switch (save.FilterIndex)
                    {
                        case 1:
                            pictureBox1.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                        pictureBox1.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;

                        case 3:
                        pictureBox1.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png);
                            break;

                        case 4:
                        pictureBox1.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                    }
                }
            
        }
        private void Btn_Square_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void Btn_Rectangle_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void Btn_Circle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }
        //Exit under File Menu
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to Exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
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
        }
        void Blank()
        {
            Image blank = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Images\blank.png"));
            pictureBox1.Image = new Bitmap(blank);
            Bitmap test = new Bitmap(blank);
            FillPictureBox(pictureBox1, test);
            DrawArea = new Bitmap(pictureBox1.Image);
        }
    }
}


