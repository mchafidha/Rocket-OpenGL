using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Text.RegularExpressions;
using System.Data;
using System.Xml; // GE xml alt reader
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.Text;
using System.Dynamic;
using System.Runtime.Serialization;
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform;
using Microsoft.CSharp;
using Microsoft.CSharp.RuntimeBinder;

namespace Coba_OpenGL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.simpleOpenGlControl1.InitializeContexts();

            Gl.glClearDepth(1.0);
            Gl.glClearColor(0.149f, 0.1529f, 0.1568f, 0.0f);

            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glDepthMask(Gl.GL_TRUE);

            //Gl.glViewport(-30, -15, width, heigth);
            Gl.glViewport(0, 0, width, heigth);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45.0f, (double)width / (double)heigth, 0.01f, 5000.0f);

            Gl.glCullFace(Gl.GL_BACK);

            comboPitch.SelectedIndex = 0;
            comboRoll.SelectedIndex = 1;
            comboYaw.SelectedIndex = 2;
        }
        short width = 560;
        short heigth = 512;
        double pitch = 0, roll = 0, yaw = 0;
        String cPitch, cRoll, cYaw;
        double x, y, z;

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.simpleOpenGlControl1.Invalidate();
            labelPitch.Text = "Pitch " + Convert.ToString(pitch);
            labelRoll.Text = "Roll " + Convert.ToString(roll);
            labelYaw.Text = "Yaw " + Convert.ToString(yaw);

            x = Convert.ToDouble(rPitch.Text);
            y = Convert.ToDouble(rRoll.Text);
            z = Convert.ToDouble(rYaw.Text);
        }

        #region 3D
        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            /*Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glTranslated(0, 0, -10);

            if (cYaw == "0") Gl.glRotated(-yaw, 1, 0, 0);
            else if (cYaw == "1") Gl.glRotated(-yaw, 0, 1, 0);
            else if (cYaw == "2") Gl.glRotated(-yaw, 0, 1, 0);

            if (cRoll == "0") Gl.glRotated(-roll, 1, 0, 0);
            else if (cRoll == "1") Gl.glRotated(-roll, 0, 0, 1);
            else if (cRoll == "2") Gl.glRotated(-roll, 0, 0, 1);

            if (cPitch == "0") Gl.glRotated(pitch, 1, 0, 0);
            else if (cPitch == "1") Gl.glRotated(pitch, 0, 1, 0);
            else if (cPitch == "2") Gl.glRotated(pitch, 0, 0, 1);

            Gl.glRotated(-90, 1, 0, 0);*/

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glTranslated(1, 0, -15);
            Gl.glRotated(pitch, 1, 0, 0);
            Gl.glRotated(-roll, 0, 1, 0);
            Gl.glRotated(-yaw, 0, 0, 1);
            Gl.glClearColor(0.6f, 1.0f, 1.0f, 0.0f);


            badan();
            ndas();
            bb();
            blar();
            pucuk();
            kontrol();
            garis();

            Gl.glPopMatrix();
        }
        void badan()
        {

            double a, b, c;
            a = 0.25;
            b = 0.5;
            c = 3.5;        // sumbu y
            //atas
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(-a, c, b);
            Gl.glVertex3d(a, c, b);
            Gl.glVertex3d(b, c, a);
            Gl.glVertex3d(b, c, -a);
            Gl.glVertex3d(a, c, -b);
            Gl.glVertex3d(-a, c, -b);
            Gl.glVertex3d(-b, c, -a);
            Gl.glVertex3d(-b, c, a);
            Gl.glEnd();
            // 1-2
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(47, 79, 79);
            Gl.glVertex3d(-a, c, b);
            Gl.glVertex3d(-a, -0.5, b);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(a, -0.5, b);
            Gl.glVertex3d(a, c, b);
            Gl.glEnd();
            // 2-3
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(a, c, b);
            Gl.glVertex3d(a, -0.5, b);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(b, -0.5, a);
            Gl.glVertex3d(b, c, a);

            Gl.glEnd();
            // 3-4
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(47, 79, 79);
            Gl.glVertex3d(b, c, a);
            Gl.glVertex3d(b, -0.5, a);
            Gl.glColor3ub(255, 100, 100);
            Gl.glVertex3d(b, -0.5, -a);
            Gl.glVertex3d(b, c, -a);
            Gl.glEnd();
            // 4-5
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(b, c, -a);
            Gl.glVertex3d(b, -0.5, -a);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(a, -0.5, -b);
            Gl.glVertex3d(a, c, -b);
            Gl.glEnd();
            // 5-6
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(47, 79, 79);
            Gl.glVertex3d(a, c, -b);
            Gl.glVertex3d(a, -0.5, -b);
            Gl.glColor3ub(255, 100, 100);
            Gl.glVertex3d(-a, -0.5, -b);
            Gl.glVertex3d(-a, c, -b);
            Gl.glEnd();
            // 6-7
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(-a, c, -b);
            Gl.glVertex3d(-a, -0.5, -b);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(-b, -0.5, -a);
            Gl.glVertex3d(-b, c, -a);
            Gl.glEnd();
            // 7-8
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(47, 79, 79);
            Gl.glVertex3d(-b, c, -a);
            Gl.glVertex3d(-b, -0.5, -a);
            Gl.glColor3ub(255, 100, 100);
            Gl.glVertex3d(-b, -0.5, a);
            Gl.glVertex3d(-b, c, a);
            Gl.glEnd();
            // 8-1
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(-b, c, a);
            Gl.glVertex3d(-b, -0.5, a);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(-a, -0.5, b);
            Gl.glVertex3d(-a, c, b);
            Gl.glEnd();


            //bawah
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(255, 255, 255);
            Gl.glVertex3d(-a, -0.55, b);
            Gl.glVertex3d(a, -0.55, b);
            Gl.glVertex3d(b, -0.55, a);
            Gl.glVertex3d(b, -0.55, -a);
            Gl.glVertex3d(a, -0.55, -b);
            Gl.glVertex3d(-a, -0.55, -b);
            Gl.glVertex3d(-b, -0.55, -a);
            Gl.glVertex3d(-b, -0.55, a);
            Gl.glEnd();

            //fin atas
            //1
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(197, 195, 145);
            Gl.glVertex3d(-b, 1.3, 0);
            Gl.glVertex3d(-b, -1, 0);
            Gl.glVertex3d(-1.9, -1, 0);
            Gl.glVertex3d(-1.9, -0.5, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(197, 195, 145);
            Gl.glVertex3d(b, 1.3, 0);
            Gl.glVertex3d(b, -1, 0);
            Gl.glVertex3d(1.9, -1, 0);
            Gl.glVertex3d(1.9, -0.5, 0);
            Gl.glEnd();

            //3

            //Fin Bawah
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(197, 195, 145);
            Gl.glVertex3d(-b, -2.3, 0);
            Gl.glVertex3d(-b, -1.3, 0);
            Gl.glColor3ub(197, 195, 145);
            Gl.glVertex3d(-1.5, -2, 0);
            Gl.glVertex3d(-1.5, -2.3, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(197, 195, 145);
            Gl.glVertex3d(b, -2.3, 0);
            Gl.glVertex3d(b, -1.3, 0);
            Gl.glColor3ub(197, 195, 145);
            Gl.glVertex3d(1.5, -2, 0);
            Gl.glVertex3d(1.5, -2.3, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(197, 195, 145);
            Gl.glVertex3d(0, -2.3, b);
            Gl.glVertex3d(0, -1.3, b);
            Gl.glColor3ub(197, 195, 145);
            Gl.glVertex3d(0, -2, 1.5);
            Gl.glVertex3d(0, -2.3, 1.5);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(197, 195, 145);
            Gl.glVertex3d(0, -2.3, -b);
            Gl.glVertex3d(0, -1.3, -b);
            Gl.glColor3ub(197, 195, 145);
            Gl.glVertex3d(0, -2, -1.5);
            Gl.glVertex3d(0, -2.3, -1.5);
            Gl.glEnd();
        }
        void blar()
        {
            double a, b, c;
            a = 0.25;
            b = 0.5;
            c = 2.2;
            //fin bawah bawah
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3d(-b, -c, -b);
            Gl.glVertex3d(-b, -c, -0.3);
            Gl.glVertex3d(-b, -2, -b);
            Gl.glVertex3d(-b, -2, -0.3);
            Gl.glColor3ub(2, 80, 88);
            Gl.glEnd();
        }
        void ndas()
        {
            int q;
            double a, b, c, d;
            a = 0.25;
            b = 0.5;
            c = 3.5;
            double k, DEF_D = 0.5;
            Gl.glBegin(Gl.GL_TRIANGLES);
            for (k = 0; k <= 360; k += DEF_D)
            {
                Gl.glColor3ub(190, 190, 190);
                Gl.glVertex3d(0, c + 0.85, 0);
                Gl.glColor3ub(236, 236, 236);
                Gl.glVertex3d(Math.Cos(k) * 0.55, c, Math.Sin(k) * 0.55);
                Gl.glColor3ub(236, 236, 236);
                Gl.glVertex3d(Math.Cos(k + DEF_D) * 0.55, c, Math.Sin(k + DEF_D) * 0.55);
            }
            Gl.glEnd();

            Gl.glBegin(Gl.GL_TRIANGLES);
            for (k = 0; k <= 360; k += DEF_D)
            {
                Gl.glColor3ub(190, 190, 190);
                Gl.glVertex3d(0, c + 0.85, 0);
                Gl.glColor3ub(236, 236, 236);
                Gl.glVertex3d(Math.Cos(k) * 0.55, c, Math.Sin(k) * 0.55);
                Gl.glColor3ub(236, 236, 236);
                Gl.glVertex3d(Math.Cos(k + DEF_D) * 0.55, c, Math.Sin(k + DEF_D) * 0.55);
            }
            Gl.glEnd();



        }

        void bb()
        {
            double a, b, c, d;
            a = 0.25;
            b = 0.5;
            c = 1.5;
            d = 1.2;// sumbu y
                    /*
                                47, 79, 79);
                                Gl.glVertex3d(-a, c, b);
                                Gl.glVertex3d(-a, -0.5, b);
                                Gl.glColor3ub(105, 105, 105);
                                Gl.glVertex3d(a, -0.5, b);
                                Gl.glVertex3d(a, c, b);
                                Gl.glEnd();
                                // 2-3
                                Gl.glBegin(Gl.GL_POLYGON);
                                Gl.glColor3ub(105, 105, 105);
                                Gl.glVertex3d(a, c, b);
                                Gl.glVertex3d(a, -0.5, b);
                                Gl.glColor3ub(105, 105, 105);
                                Gl.glVertex3d(b, -0.5, a);
                                Gl.glVertex3d(b, c, a);*/

            // 1-2
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(47, 79, 79);
            Gl.glVertex3d(-a, -1.2, b);
            Gl.glVertex3d(-a, -1.8, b);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(a, -1.8, b);
            Gl.glVertex3d(a, -1.2, b);
            Gl.glEnd();
            // 2-3
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(a, -1.2, b);
            Gl.glVertex3d(a, -1.8, b);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(b, -1.8, a);
            Gl.glVertex3d(b, -1.2, a);
            Gl.glEnd();
            // 3-4
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(47, 79, 79);
            Gl.glVertex3d(b, -1.2, a);
            Gl.glVertex3d(b, -1.8, a);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(b, -1.8, -a);
            Gl.glVertex3d(b, -1.2, -a);
            Gl.glEnd();
            // 4-5
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(b, -1.2, -a);
            Gl.glVertex3d(b, -1.8, -a);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(a, -1.8, -b);
            Gl.glVertex3d(a, -1.2, -b);
            Gl.glEnd();
            // 5-6
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(47, 79, 79);
            Gl.glVertex3d(a, -1.2, -b);
            Gl.glVertex3d(a, -1.8, -b);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(-a, -1.8, -b);
            Gl.glVertex3d(-a, -1.2, -b);
            Gl.glEnd();
            // 6-7
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(-a, -1.2, -b);
            Gl.glVertex3d(-a, -1.8, -b);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(-b, -1.8, -a);
            Gl.glVertex3d(-b, -1.2, -a);
            Gl.glEnd();
            // 7-8
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(47, 79, 79);
            Gl.glVertex3d(-b, -1.2, -a);
            Gl.glVertex3d(-b, -1.8, -a);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(-b, -1.8, a);
            Gl.glVertex3d(-b, -1.2, a);
            Gl.glEnd();
            // 8-1
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(-b, -1.2, a);
            Gl.glVertex3d(-b, -1.8, a);
            Gl.glColor3ub(105, 105, 105);
            Gl.glVertex3d(-a, -1.8, b);
            Gl.glVertex3d(-a, -1.2, b);
            Gl.glEnd();

            //bawah atas tengah
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(255, 255, 255);
            Gl.glVertex3d(-a, -d, b);
            Gl.glVertex3d(a, -d, b);
            Gl.glVertex3d(b, -d, a);
            Gl.glVertex3d(b, -d, -a);
            Gl.glVertex3d(a, -d, -b);
            Gl.glVertex3d(-a, -d, -b);
            Gl.glVertex3d(-b, -d, -a);
            Gl.glVertex3d(-b, -d, a);
            Gl.glEnd();
        }

        void pucuk()
        {
            double a, b, c, d;
            a = 0.1;
            b = 0.2;
            c = 2.2;
            // 1-2
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(0, 0, 0);
            Gl.glVertex3d(-a, -1.8, b);
            Gl.glVertex3d(-a, -c, b);
            Gl.glVertex3d(a, -c, b);
            Gl.glVertex3d(a, -1.8, b);
            Gl.glEnd();
            // 2-3
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(0, 0, 0);
            Gl.glVertex3d(a, -1.8, b);
            Gl.glVertex3d(a, -c, b);
            Gl.glVertex3d(b, -c, a);
            Gl.glVertex3d(b, -1.8, a);
            Gl.glEnd();
            // 3-4
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(0, 0, 0);
            Gl.glVertex3d(b, -1.8, a);
            Gl.glVertex3d(b, -c, a);
            Gl.glVertex3d(b, -c, -a);
            Gl.glVertex3d(b, -1.8, -a);
            Gl.glEnd();
            // 4-5
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(0, 0, 0);
            Gl.glVertex3d(b, -1.8, -a);
            Gl.glVertex3d(b, -c, -a);
            Gl.glVertex3d(a, -c, -b);
            Gl.glVertex3d(a, -1.8, -b);
            Gl.glEnd();
            // 5-6
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(0, 0, 0);
            Gl.glVertex3d(a, -1.8, -b);
            Gl.glVertex3d(a, -c, -b);
            Gl.glVertex3d(-a, -c, -b);
            Gl.glVertex3d(-a, -1.8, -b);
            Gl.glEnd();
            // 6-7
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(0, 0, 0);
            Gl.glVertex3d(-a, -1.8, -b);
            Gl.glVertex3d(-a, -c, -b);
            Gl.glVertex3d(-b, -c, -a);
            Gl.glVertex3d(-b, -1.8, -a);
            Gl.glEnd();
            // 7-8
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(0, 0, 0);
            Gl.glVertex3d(-b, -1.8, -a);
            Gl.glVertex3d(-b, -c, -a);
            Gl.glVertex3d(-b, -c, a);
            Gl.glVertex3d(-b, -1.8, a);
            Gl.glEnd();
            // 8-1
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(0, 0, 0);
            Gl.glVertex3d(-b, -1.8, a);
            Gl.glVertex3d(-b, -c, a);
            Gl.glVertex3d(-a, -c, b);
            Gl.glVertex3d(-a, -1.8, b);
            Gl.glEnd();
        }

        void kontrol()
        {
            double a, b, c;
            a = 0.25;
            b = 0.5;
            c = 2.3;


            Gl.glLineWidth(2.5f);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3ub(100, 100, 0);
            Gl.glVertex3d(-b, -0.5, 0);
            Gl.glVertex3d(-b, -c - 1, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3ub(100, 100, 0);
            Gl.glVertex3d(b, -0.5, 0);
            Gl.glVertex3d(b, -c - 1, 0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3ub(100, 100, 0);
            Gl.glVertex3d(0, -0.5, -b);
            Gl.glVertex3d(0, -c - 1, -b);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3ub(100, 100, 0);
            Gl.glVertex3d(0, -0.5, b);
            Gl.glVertex3d(0, -c - 1, b);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glColor3ub(100, 50, 50);
            Gl.glVertex3d(b, -c - 0.3, 0);
            Gl.glVertex3d(b, -c, 0);
            Gl.glVertex3d(-a - 0.18, -c, 0);
            Gl.glVertex3d(-a - 0.18, -c - 0.3, 0);
            Gl.glEnd();

        }

        void garis()
        {
            double a, b, c;
            a = 5;
            b = 5;
            c = 5;

            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3f(0.0f, 225.1f, 0.0f);
            Gl.glVertex3d(b, c, 0);
            Gl.glVertex3d(b + 5, c + 5, 0);
            Gl.glEnd();
        }
        #endregion

        private void Xplus_Click(object sender, EventArgs e)
        {
            pitch += 15;
            //MessageBox.Show(Convert.ToString(pitch));
        }

        private void Xmin_Click(object sender, EventArgs e)
        {
            pitch += -15;
        }

        private void Yplus_Click(object sender, EventArgs e)
        {
            roll += 15;
        }

        private void Ymin_Click(object sender, EventArgs e)
        {
            roll += -15;
        }

        private void comboPitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPitch = comboPitch.SelectedIndex.ToString();
        }

        private void comboRoll_SelectedIndexChanged(object sender, EventArgs e)
        {
            cRoll = comboRoll.SelectedIndex.ToString();
        }

        private void comboYaw_SelectedIndexChanged(object sender, EventArgs e)
        {
            cYaw = comboYaw.SelectedIndex.ToString();
        }

        private void Zplus_Click(object sender, EventArgs e)
        {
            yaw += 15;
        }

        private void Zmin_Click(object sender, EventArgs e)
        {
            yaw += -15;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
