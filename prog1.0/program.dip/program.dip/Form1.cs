using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace program.dip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label16.Text = ""; calculate3.Hide(); calculate4.Hide(); calculate5.Hide();
            calculate6.Hide(); calculate7.Hide(); calculate8.Hide(); panel2.Hide();
            t00.Enabled = false; t01.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/in_dat.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(t11.Text); sw.WriteLine(t12.Text); sw.WriteLine(t13.Text);
                    sw.WriteLine(t14.Text); sw.WriteLine(t15.Text); sw.WriteLine(t16.Text);
                    sw.WriteLine(t17.Text); sw.WriteLine(t18.Text); sw.WriteLine(t19.Text);
                    sw.WriteLine(t110.Text); sw.WriteLine(t111.Text); sw.WriteLine(t112.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }//зберегти дані (введені)
        private void re1_Click(object sender, EventArgs e)
        {
            t113.Enabled = false; t114.Enabled = false;
            calculate2.Hide(); calculate1.Enabled = true; label16.Show(); calculate2.Enabled = true;
            calculate3.Hide(); calculate4.Hide(); calculate1.Show(); panel2.Hide();
            t113.Text = ""; t114.Text = ""; t00.Text = ""; t01.Text = "";
            label16.Text = "Планові запуски-зупинки";
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/in_dat.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter.ToString())
                        {
                            case "0":
                                { t11.Text = line; counter++; continue; }
                            case "1":
                                { t12.Text = line; counter++; continue; }
                            case "2":
                                { t13.Text = line; counter++; continue; }
                            case "3":
                                { t14.Text = line; counter++; continue; }
                            case "4":
                                { t15.Text = line; counter++; continue; }
                            case "5":
                                { t16.Text = line; counter++; continue; }
                            case "6":
                                { t17.Text = line; counter++; continue; }
                            case "7":
                                { t18.Text = line; counter++; continue; }
                            case "8":
                                { t19.Text = line; counter++; continue; }
                            case "9":
                                { t110.Text = line; counter++; continue; }
                            case "10":
                                { t111.Text = line; counter++; continue; }
                            case "11":
                                { t112.Text = line; counter++; continue; }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }//планові запуски-зупинки
        private void calculate1_Click(object sender, EventArgs e)
        {

            t113.Enabled = true; t114.Enabled = true;
            Process.Start("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pz1.exe");
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/res_pz.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter.ToString())
                        {
                            case "0":
                                { t114.Text = line; counter++; continue; }
                            case "1":
                                { t113.Text = line; counter++; continue; }
                        }
                    }
                }
                StreamReader file = new StreamReader("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pr_pz.txt", Encoding.Default);
                string str = file.ReadToEnd();
                richTextBox1.Text = str;
            }


            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
            calculate1.Enabled = false; calculate2.Show();
        }//планові запуски-зупинки(роз. напр)
        private void calculate2_Click(object sender, EventArgs e)
        {
            Process.Start("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pz2.exe");
            calculate2.Enabled = false;
            if (richTextBox1.Text != "")
            {
                try
                {
                    StreamReader file = new StreamReader("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pr_pz2.txt", Encoding.Default);
                    string str = file.ReadToEnd();
                    richTextBox1.Text = richTextBox1.Text + str;
                }
                catch (Exception)
                {
                    MessageBox.Show("The process failed: {0}", e.ToString());
                }
            }
            else
            {
                try
                {
                    StreamReader file = new StreamReader("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pr_pz2.txt", Encoding.Default);
                    string str = file.ReadToEnd();
                    richTextBox1.Text = str;
                }
                catch (Exception)
                {
                    MessageBox.Show("The process failed: {0}", e.ToString());
                }
            }
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/res_pz2.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter.ToString())
                        {
                            case "0":
                                { t00.Text = line; counter++; continue; }
                            case "1":
                                { t01.Text = line; counter++; continue; }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }//планові запуски-зупинки(роз.нак.пош.мет.)
        private void re2_Click(object sender, EventArgs e)
        {
            t113.Enabled = false; t114.Enabled = false; panel2.Hide(); t00.Text = ""; t01.Text = "";
            calculate1.Hide(); calculate2.Hide(); calculate3.Show(); calculate3.Enabled = true; calculate4.Enabled = true;
            richTextBox1.Text = ""; t113.Text = ""; t114.Text = ""; label16.Text = "Гідравлічні випробування";
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/in_dat.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter.ToString())
                        {
                            case "0":
                                { t11.Text = line; counter++; continue; }
                            case "1":
                                { t12.Text = line; counter++; continue; }
                            case "2":
                                { t13.Text = line; counter++; continue; }
                            case "3":
                                { t14.Text = line; counter++; continue; }
                            case "4":
                                { t15.Text = line; counter++; continue; }
                            case "5":
                                { t16.Text = line; counter++; continue; }
                            case "6":
                                { t17.Text = line; counter++; continue; }
                            case "7":
                                { t18.Text = line; counter++; continue; }
                            case "8":
                                { t19.Text = line; counter++; continue; }
                            case "9":
                                { t110.Text = line; counter++; continue; }
                            case "10":
                                { t111.Text = line; counter++; continue; }
                            case "11":
                                { t112.Text = line; counter++; continue; }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }//гідравлічні випр.
        private void calculate3_Click(object sender, EventArgs e)
        {
            calculate3.Enabled = false; calculate4.Show();
            t113.Enabled = true; t114.Enabled = true;
            Process.Start("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/hv1.exe");
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/res_hv.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter.ToString())
                        {
                            case "0":
                                { t114.Text = line; counter++; continue; }
                            case "1":
                                { t113.Text = line; counter++; continue; }
                        }
                    }
                }
                StreamReader file = new StreamReader("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pr_hv.txt", Encoding.Default);
                string str = file.ReadToEnd();
                richTextBox1.Text = str;
            }


            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
            calculate3.Enabled = false; calculate4.Show();
        }//гідравлічні випр.(роз. напр)
        private void calculate4_Click(object sender, EventArgs e)
        {
            Process.Start("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/hv2.exe");
            calculate4.Enabled = false;
            if (richTextBox1.Text != "")
            {
                try
                {
                    StreamReader file = new StreamReader("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pr_hv2.txt", Encoding.Default);
                    string str = file.ReadToEnd();
                    richTextBox1.Text = richTextBox1.Text + str;
                }
                catch (Exception)
                {
                    MessageBox.Show("The process failed: {0}", e.ToString());
                }
            }
            else
            {
                try
                {
                    StreamReader file = new StreamReader("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pr_hv2.txt", Encoding.Default);
                    string str = file.ReadToEnd();
                    richTextBox1.Text = str;
                }
                catch (Exception)
                {
                    MessageBox.Show("The process failed: {0}", e.ToString());
                }
            }
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/res_hv2.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter.ToString())
                        {
                            case "0":
                                { t00.Text = line; counter++; continue; }
                            case "1":
                                { t01.Text = line; counter++; continue; }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }//гідравлічні випр.(роз.нак.пош.мет.)
        private void re3_Click(object sender, EventArgs e)
        {
            t113.Enabled = false; t114.Enabled = false; panel2.Hide();
            calculate1.Hide(); calculate2.Hide(); calculate3.Hide(); calculate4.Hide(); calculate5.Show();
            calculate5.Enabled = true; calculate6.Enabled = true; t00.Text = ""; t01.Text = "";
            richTextBox1.Text = ""; t113.Text = ""; t114.Text = ""; label16.Text = "Теплові удари";
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/in_dat.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter.ToString())
                        {
                            case "0":
                                { t11.Text = line; counter++; continue; }
                            case "1":
                                { t12.Text = line; counter++; continue; }
                            case "2":
                                { t13.Text = line; counter++; continue; }
                            case "3":
                                { t14.Text = line; counter++; continue; }
                            case "4":
                                { t15.Text = line; counter++; continue; }
                            case "5":
                                { t16.Text = line; counter++; continue; }
                            case "6":
                                { t17.Text = line; counter++; continue; }
                            case "7":
                                { t18.Text = line; counter++; continue; }
                            case "8":
                                { t19.Text = line; counter++; continue; }
                            case "9":
                                { t110.Text = line; counter++; continue; }
                            case "10":
                                { t111.Text = line; counter++; continue; }
                            case "11":
                                { t112.Text = line; counter++; continue; }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }//теплові удари
        private void calculate5_Click(object sender, EventArgs e)
        {
            calculate5.Enabled = false; calculate6.Show();
            t113.Enabled = true; t114.Enabled = true;
            Process.Start("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/tu1.exe");
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/res_TU.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter.ToString())
                        {
                            case "0":
                                { t114.Text = line; counter++; continue; }
                            case "1":
                                { t113.Text = line; counter++; continue; }
                        }
                    }
                }
                StreamReader file = new StreamReader("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pr_TU.txt", Encoding.Default);
                string str = file.ReadToEnd();
                richTextBox1.Text = str;
            }


            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
            calculate5.Enabled = false; calculate6.Show();
        }//теплові удари(роз. напр)
        private void calculate6_Click(object sender, EventArgs e)
        {
            Process.Start("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/tu2.exe");
            calculate6.Enabled = false;
            if (richTextBox1.Text != "")
            {
                try
                {
                    StreamReader file = new StreamReader("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pr_TU2.txt", Encoding.Default);
                    string str = file.ReadToEnd();
                    richTextBox1.Text = richTextBox1.Text + str;
                }
                catch (Exception)
                {
                    MessageBox.Show("The process failed: {0}", e.ToString());
                }
            }
            else
            {
                try
                {
                    StreamReader file = new StreamReader("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pr_hv2.txt", Encoding.Default);
                    string str = file.ReadToEnd();
                    richTextBox1.Text = str;
                }
                catch (Exception)
                {
                    MessageBox.Show("The process failed: {0}", e.ToString());
                }
            }
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/res_TU2.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter.ToString())
                        {
                            case "0":
                                { t00.Text = line; counter++; continue; }
                            case "1":
                                { t01.Text = line; counter++; continue; }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }//теплові удари(роз.нак.пош.мет.)
        private void re4_Click(object sender, EventArgs e)
        {
            t113.Enabled = false; t114.Enabled = false;
            calculate1.Hide(); calculate2.Hide(); calculate3.Hide(); calculate4.Hide(); calculate5.Hide();
            calculate7.Show(); panel2.Hide(); t00.Text = ""; t01.Text = "";
            calculate7.Enabled = true; calculate8.Enabled = true;
            richTextBox1.Text = ""; t113.Text = ""; t114.Text = ""; label16.Text = "Термоциклювання";
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/in_dat.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter.ToString())
                        {
                            case "0":
                                { t11.Text = line; counter++; continue; }
                            case "1":
                                { t12.Text = line; counter++; continue; }
                            case "2":
                                { t13.Text = line; counter++; continue; }
                            case "3":
                                { t14.Text = line; counter++; continue; }
                            case "4":
                                { t15.Text = line; counter++; continue; }
                            case "5":
                                { t16.Text = line; counter++; continue; }
                            case "6":
                                { t17.Text = line; counter++; continue; }
                            case "7":
                                { t18.Text = line; counter++; continue; }
                            case "8":
                                { t19.Text = line; counter++; continue; }
                            case "9":
                                { t110.Text = line; counter++; continue; }
                            case "10":
                                { t111.Text = line; counter++; continue; }
                            case "11":
                                { t112.Text = line; counter++; continue; }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }//колив.темп.ст.барабана
        private void calculate7_Click(object sender, EventArgs e)
        {
            calculate5.Enabled = false; calculate6.Show();
            t113.Enabled = true; t114.Enabled = true;
            Process.Start("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/tc1.exe");
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/res_TC.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter.ToString())
                        {
                            case "0":
                                { t114.Text = line; counter++; continue; }
                            case "1":
                                { t113.Text = line; counter++; continue; }
                        }
                    }
                }
                StreamReader file = new StreamReader("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pr_TC.txt", Encoding.Default);
                string str = file.ReadToEnd();
                richTextBox1.Text = str;
            }


            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
            calculate7.Enabled = false; calculate8.Show();
        }//колив.темп.ст.барабана(роз. напр)
        private void calculate8_Click(object sender, EventArgs e)
        {
            Process.Start("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/tc2.exe");
            calculate6.Enabled = false;
            if (richTextBox1.Text != "")
            {
                try
                {
                    StreamReader file = new StreamReader("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pr_TC2.txt", Encoding.Default);
                    string str = file.ReadToEnd();
                    richTextBox1.Text = richTextBox1.Text + str;
                }
                catch (Exception)
                {
                    MessageBox.Show("The process failed: {0}", e.ToString());
                }
            }
            else
            {
                try
                {
                    StreamReader file = new StreamReader("E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/pr_hv2.txt", Encoding.Default);
                    string str = file.ReadToEnd();
                    richTextBox1.Text = str;
                }
                catch (Exception)
                {
                    MessageBox.Show("The process failed: {0}", e.ToString());
                }
            }
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/res_TC2.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        switch (counter.ToString())
                        {
                            case "0":
                                { t00.Text = line; counter++; continue; }
                            case "1":
                                { t01.Text = line; counter++; continue; }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }//колив.темп.ст.барабана(роз.нак.пош.мет.)
        private void consolution_Click(object sender, EventArgs e)
        {
            panel2.Show();
            t00.Text = ""; t01.Text = "";
        }//висновки
        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/res_pz2.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Replace(".", ",");
                        switch (counter.ToString())
                        {
                            case "0":
                                { t11.Text = ""; counter++; continue; }
                            case "1":
                                {textBox1.Text = line; counter++; continue;
                                }
                        }
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/res_hv2.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Replace(".", ",");
                        switch (counter.ToString())
                        {
                            case "0":
                                { t11.Text = ""; counter++; continue; }
                            case "1":
                                { textBox2.Text = line; counter++; continue; }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/res_TU2.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Replace(".", ",");
                        switch (counter.ToString())
                        {
                            case "0":
                                { t11.Text = ""; counter++; continue; }
                            case "1":
                                { textBox3.Text = line; counter++; continue; }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string path = @"E:/Other/Univer/Диплом5курс/prog1.0/program.dip/resurs/Resurs/BIN/res_TC2.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    int counter = 0;
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        line = line.Replace(".", ",");
                        switch (counter.ToString())
                        {
                            case "0":
                                { t11.Text = ""; counter++; continue; }
                            case "1":
                                {
                                    textBox4.Text = line; counter++; continue;
                                }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "0";
            if (textBox2.Text == "") textBox2.Text = "0";
            if (textBox3.Text == "") textBox3.Text = "0";
            if (textBox4.Text == "") textBox4.Text = "0";

            textBox5.Text = (Double.Parse(textBox1.Text) + Double.Parse(textBox2.Text)
                + Double.Parse(textBox3.Text) + Double.Parse(textBox4.Text)).ToString();
        }//треба виправити . і ,
    }
}