﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Drawing2D;

namespace CVGenesis
{
    public partial class Academic_Template : Form
    {
        public Academic_Template()
        {
            InitializeComponent();

            readUser(GlobalUser._username);
            readEduData(GlobalUser._username);
            readTrainingData(GlobalUser._username);
            readWorkData(GlobalUser._username);
            readCertiData(GlobalUser._username);
            readSkillData(GlobalUser._username);
        }

        public void readUser(string str)
        {
            string user = $@"C:\Hackathon\CVGenesis\CV Data\Personal Details\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);
                foreach (string u in users)
                {
                    if (u.Contains("FirstName:"))
                    {
                        firstnameLabel.Text = u.Remove(0, 10);
                    }
                    else if (u.Contains("LastName:"))
                    {
                        lastnameLabel.Text = u.Remove(0, 9);
                    }
                    else if (u.Contains("DOB:"))
                    {
                        DOBLabel.Text = u.Remove(0, 4);
                    }
                    else if (u.Contains("POB:"))
                    {
                        POBLabel.Text = u.Remove(0, 4);
                    }
                    else if (u.Contains("Nationality:"))
                    {
                        nationLabel.Text = u.Remove(0, 12);
                    }
                    else if (u.Contains("Gender:"))
                    {
                        genderLabel.Text = u.Remove(0, 7);
                    }
                    else if (u.Contains("Address:"))
                    {
                        addressLabel.Text = u.Remove(0, 8);
                    }
                    else if (u.Contains("Email:"))
                    {
                        mailLabel.Text = u.Remove(0, 6);
                    }
                    else if (u.Contains("Phone:"))
                    {
                        mobileLabel.Text = u.Remove(0, 6);
                    }
                }

            }
        }
        public void readEduData(string str)
        {

            string user = $@"C:\Hackathon\CVGenesis\CV Data\Education Details\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string s in users)
                {
                    if (s.Contains("1."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        degreeLabel1.Text = k[0];
                        InsLabel1.Text = k[1];
                        subLabel1.Text = k[2];
                        yearLabel1.Text = k[3];
                        resLabel1.Text = k[4];
                        publiLabel.Text = k[5];
                        authorLabel.Text = k[6];
                        dateLabel.Text = k[7];
                    }

                    else if (s.Contains("2."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        degreeLabel2.Text = k[0];
                        InsLabel2.Text = k[1];
                        subLabel2.Text = k[2];
                        yearLabel2.Text = k[3];
                        resLabel2.Text = k[4];
                        publiLabel.Text = k[5];
                        authorLabel.Text = k[6];
                        dateLabel.Text = k[7];

                    }

                    else if (s.Contains("3."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        degreeLabel3.Text = k[0];
                        InsLabel3.Text = k[1];
                        subLabel3.Text = k[2];
                        yearLabel3.Text = k[3];
                        resLabel3.Text = k[4];
                        publiLabel.Text = k[5];
                        authorLabel.Text = k[6];
                        dateLabel.Text = k[7];

                    }

                }
            }




        }

        public void readTrainingData(string str)
        {

            string user = $@"C:\Hackathon\CVGenesis\CV Data\Training\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string s in users)
                {
                    if (s.Contains("1."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        quaLabel.Text = k[0];
                        orgLabel.Text = k[1];
                        fromLabel.Text = k[2];
                        toLabel.Text = k[3];


                    }

                    else if (s.Contains("2."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        quaLabel2.Text = k[0];
                        orgLabel2.Text = k[1];
                        formLabel2.Text = k[2];
                        toLabel2.Text = k[3];


                    }



                }
            }




        }

        public void readWorkData(string str)
        {

            string user = $@"C:\Hackathon\CVGenesis\CV Data\WorkExp\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string s in users)
                {
                    if (s.Contains("1."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        ocLabel1.Text = k[0];
                        emLabel1.Text = k[1];
                        conLabel1.Text = k[2];
                        fromLabel3.Text = k[3];
                        toLabel3.Text = k[4];

                    }

                    else if (s.Contains("2."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        occLabel2.Text = k[0];
                        emLabel2.Text = k[1];
                        conLabel2.Text = k[2];
                        fromLabel4.Text = k[3];
                        toLabel4.Text = k[4];

                    }



                }
            }




        }

        public void readCertiData(string str)
        {

            string user = $@"C:\Hackathon\CVGenesis\CV Data\Awards\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string s in users)
                {
                    if (s.Contains("1."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        titleLabel1.Text = k[0];
                        eventLabel1.Text = k[1];
                        cinsLabel1.Text = k[2];
                        DOWLabel1.Text = k[3];

                    }

                    else if (s.Contains("2."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        titleLabel2.Text = k[0];
                        eventLabel2.Text = k[1];
                        cinsLabel2.Text = k[2];
                        DOWLabel2.Text = k[3];

                    }



                }
            }




        }

        public void readSkillData(string str)
        {

            string user = $@"C:\Hackathon\CVGenesis\CV Data\Skills\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string s in users)
                {


                    string[] k = null;
                    k = s.Split(',');

                    lanskillLabel.Text = k[0];
                    digitalskillLabel.Text = k[1];
                    otherskillLabel.Text = k[2];






                }
            }

        }


        private static void SaveScreenshot(Form frm)
        {
            string imagePath = string.Format($@"C:\Hackathon\CVGenesis\Export\Academic_{GlobalUser._username}.png");
            string pdfPath = string.Format($@"C:\Hackathon\CVGenesis\Export\Academic_{GlobalUser._username}.pdf");
            Bitmap Image = new Bitmap(frm.Width, frm.Height);
            frm.DrawToBitmap(Image, new System.Drawing.Rectangle(0, 0, frm.Width, frm.Height));
            Image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Png);
        }

        public static void CreatePDF(string fileToCreate, string pngFileName)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(fileToCreate, FileMode.Create));
            doc.Open();
            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(pngFileName);
            png.SetAbsolutePosition(0, 0);
            doc.Add(png);
            doc.Close();
        }
        private void pdfButton_Click(object sender, EventArgs e)
        {
            selectButton1.Hide();
            loadButton1.Hide();
            pdfButton.Hide();
            SaveScreenshot(this);
            CreatePDF($@"C:\Hackathon\CVGenesis\Export\Academic_{GlobalUser._username}.pdf", $@"C:\Hackathon\CVGenesis\Export\Academic_{GlobalUser._username}.png");
        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void yearLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Academic_Template_Load(object sender, EventArgs e)
        {

        }

        private void quaLabel_Click(object sender, EventArgs e)
        {

        }

        private void orgLabel_Click(object sender, EventArgs e)
        {

        }

        private void fromLabel_Click(object sender, EventArgs e)
        {

        }

        private void toLabel_Click(object sender, EventArgs e)
        {

        }

        private void quaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void orgLabel2_Click(object sender, EventArgs e)
        {

        }

        private void formLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toLabel2_Click(object sender, EventArgs e)
        {

        }

        private void backLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Preview().Show();
        }

        private void label61_Click(object sender, EventArgs e)
        {

        }


        public string fileLocation;

        private void selectButton1_Click(object sender, EventArgs e)
        {
            string filelocation = "";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Browse Image File";
            fdlg.Filter = "Image Files (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All Files(*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                filelocation = fdlg.FileName;
            }

            PictureClass._path = filelocation;
        }

        private void loadButton1_Click(object sender, EventArgs e)
        {
            if (PictureClass._path != "")
            {
                Properties.Settings.Default.FileString = PictureClass._path;
                Properties.Settings.Default.Save();
            }

            System.Drawing.Image image = System.Drawing.Image.FromFile(Properties.Settings.Default.FileString);
            this.pictureBox.Image = image;


        }

    }
}
