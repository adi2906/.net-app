using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect.PagPrincipala
{
    public partial class UCDesen : UserControl
    {
        int nrobs;
        float[] x, y;
        float v0 =0, v1=0, v2=0, v3=0, v4=0;

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();
            listBox1.DoDragDrop(textBox1.Text, DragDropEffects.All);
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.SelectAll();
            listBox1.DoDragDrop(textBox2.Text, DragDropEffects.All);
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.SelectAll();
            listBox1.DoDragDrop(textBox2.Text, DragDropEffects.All);
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.SelectAll();
            listBox1.DoDragDrop(textBox2.Text, DragDropEffects.All);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            listBox1.Items.Add(e.Data.GetData(DataFormats.Text));
        }

        private void textBox5_MouseDown(object sender, MouseEventArgs e)
        {
           textBox5.SelectAll();      
           listBox1.DoDragDrop(textBox5.Text, DragDropEffects.All);
        }

        public UCDesen()
        {
            InitializeComponent();
            nrobs = 5;
            x = new float[] { 1f, 2f, 3f, 4f, 5f };
            y = new float[] { 0f, 0f, 0f, 0f, 0f };
            this.ResizeRedraw = true;


        }

        //private void btAdaugaUtilizator_Click(object sender, EventArgs e)
        //{

        //}

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                v0 = Convert.ToInt32(textBox1.Text);
                v1 = Convert.ToInt32(textBox2.Text);
                v2 = Convert.ToInt32(textBox3.Text);
                v3 = Convert.ToInt32(textBox4.Text);
                v4 = Convert.ToInt32(textBox5.Text);
                panel2.Invalidate();
            }
            catch
            {
                MessageBox.Show("Date invalide/insuficiente");
            }
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

            y = new float[] { v0, v1, v2, v3, v4 };
            Graphics g = e.Graphics;
            Rectangle zonaClient = e.ClipRectangle;
            //pt desen
            Brush fundal = new SolidBrush(Color.Transparent);
            g.FillRectangle(fundal, zonaClient);
            zonaClient.X += 20;
            zonaClient.Y += 20;
            zonaClient.Height -= 40;
            zonaClient.Width -= 40;
            //tot ce e desenat e raportat la inaltimile de mai sus
            int i, vl = zonaClient.Left, vb = zonaClient.Bottom, vr = zonaClient.Right, vt = zonaClient.Top;
            float rap_dist_lat = 0.2f, max;
            SolidBrush[] pensule = new SolidBrush[]
            {
                new SolidBrush(Color.Pink),
                new SolidBrush(Color.RoyalBlue),
                new SolidBrush(Color.Moccasin),
                new SolidBrush(Color.PowderBlue),
                new SolidBrush(Color.Yellow),
                new SolidBrush(Color.LightGreen)
            };
            Pen[] creioane = new Pen[]
            {
                new Pen(Color.Red),
                new Pen(Color.Blue),
                new Pen(Color.Green),
                new Pen(Color.Olive),
                new Pen(Color.Yellow),
                new Pen(Color.Cyan)
            };

            SolidBrush pnsCrt;
            Pen penCrt;

            int lat, dist; //latimea unui dreptunghi bara + spatiu
            lat = (vr - vl) / (int)((nrobs + 1) * rap_dist_lat + nrobs);

            dist = (int)(lat * rap_dist_lat);

            for (max = y[0], i = 1; i < nrobs; i++)
                if (max < y[i])
                    max = y[i];

            penCrt = creioane[5];
            pnsCrt = pensule[4];
            g.DrawLine(penCrt, vl, vt, vl, vb);
            g.DrawLine(penCrt, vl, vb, vr, vb);
            penCrt = creioane[1];
            for (i = 0; i < nrobs; i++)
            {
                pnsCrt = pensule[(4 + i) % 6];
                //pt coltul stanga sus
                //axa oy creste in jos
                PointF pnt = new PointF(vl + dist + i * (lat + dist), vb - y[i] * (vb - vt) / max);
                SizeF sz = new SizeF(lat, y[i] * (vb - vt) / max);
                g.FillRectangle(pnsCrt, new RectangleF(pnt, sz));
                string denx = x[i].ToString();
                g.DrawString(denx, Font, pnsCrt, vl + dist + lat / 2 + i * (lat + dist), vb + 5);
            }


        }
    }
}
