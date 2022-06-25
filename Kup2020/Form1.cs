using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace Ornek2020
{
    public partial class Form1 : Form
    {
        float rotX = 0;
        float rotY = 0;
        float rotZ = 0;
        float hiz = 5;

        public Form1()
        {
            InitializeComponent();
            OpenGlControl.InitializeContexts();
            // OpenGL ilk işlemler
            Gl.glClearColor(0.0f, 0.0f, 0.5f, 0.0f);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(-2.0, 2.0, -2.0, 2.0, -2.0, 2.0);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);

            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        float[][] pt = { 
            new float[] { -1, -1, -1 }, new float[] { -1, 1, -1 },
            new float[] {  1, -1, -1 }, new float[] {  1, 1, -1 },
            new float[] { -1, -1,  1 }, new float[] { -1, 1,  1 },
            new float[] {  1, -1,  1 }, new float[] {  1, 1,  1 }
        };

        public void quad(int n1, int n2, int n3, int n4)
        {
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glColor3fv(pt[n1]); Gl.glVertex3fv(pt[n1]);
                Gl.glColor3fv(pt[n2]); Gl.glVertex3fv(pt[n2]);
                Gl.glColor3fv(pt[n3]); Gl.glVertex3fv(pt[n3]);
                Gl.glColor3fv(pt[n4]); Gl.glVertex3fv(pt[n4]);
            Gl.glEnd();
        }

        public void cube()
        {
            quad(6, 2, 3, 7); quad(5, 1, 0, 4);
            quad(7, 3, 1, 5); quad(4, 0, 2, 6);
            quad(2, 0, 1, 3); quad(7, 5, 4, 6);
        }

        private void MyPaint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glShadeModel(Gl.GL_SMOOTH);

            //Gl.glTranslatef(x,y,z);
            Gl.glPushMatrix();
                Gl.glRotatef(rotX, 1, 0, 0);
                Gl.glRotatef(rotY, 0, 1, 0);
                Gl.glRotatef(rotZ, 0, 0, 1);
                cube();
            Gl.glPopMatrix();
        }

        private void OpenGlControl_Load(object sender, EventArgs e)
        {

        }

        private void MyKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                rotZ = (rotZ + 5) % 360;
            if (e.KeyCode == Keys.D)
                rotZ = (rotZ - 5) % 360;
            if (e.KeyCode == Keys.W)
                rotX = (rotX + 5) % 360;
            if (e.KeyCode == Keys.S)
                rotX = (rotX - 5) % 360;
            OpenGlControl.Refresh();
        }

        private void buttonZDondur_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnimBaslat_Click(object sender, EventArgs e)
        {
            // timer Interval ile verilen msn hızla güncellenir
            timerDondur.Interval = 50;
            timerDondur.Start();
            hiz = 1;
            labelHiz.Text = "Hız = " + hiz;
        }

        private void buttonAnimHizlandir_Click(object sender, EventArgs e)
        {
            // Min 1, maks 9 olsun istedim.
            hiz = (hiz + 1) % 10;
            if (hiz == 0) hiz = 1;
            labelHiz.Text = "Hız = " + hiz;
        }

        private void buttonAnimDurdur_Click(object sender, EventArgs e)
        {
            hiz = 0;
            labelHiz.Text = "Hız = " + hiz;
            timerDondur.Stop();
        }

        private void timerDondur_Tick(object sender, EventArgs e)
        {
            rotZ = (rotZ + hiz) % 360;
            rotX = rotY = rotZ;
            OpenGlControl.Refresh();
        }
    }
}
