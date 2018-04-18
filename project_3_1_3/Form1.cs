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

namespace project_3_1_3
{
    public partial class Form1 : Form
    {
        string f_name;
        public Form1(string[] args)
        {

            InitializeComponent();
            for (int i = 0; i < args.Length; i++)
            {
                
                f_name = f_name + args[i];

            }

        }

        Random rnd = new Random();

        private void button2_Click(object sender, EventArgs e)  //this is the browse button
        {
            OpenFileDialog myfile = new OpenFileDialog();
            if (myfile.ShowDialog() == DialogResult.OK)
            {
                f_name = myfile.FileName;
            }
            textBox1.Text = f_name;
        }

        private void button1_Click(object sender, EventArgs e)  //this is the delete button
        {
            string filename = (textBox1.Text);
            if (File.Exists(filename))
            {
                int a = rnd.Next(1, 7);
                int b = rnd.Next(1, 7);
                int c = rnd.Next(1, 7);
                File.WriteAllText(filename, null); //clear the whole files*******if u use string.empty the file can not be recovered
                overwrite(filename, a);
                overwrite(filename, b);
                overwrite(filename, c);
                File.Delete(filename);
                MessageBox.Show("The file is deleted permanently and you're unable to recover it!!!!!!!!!");
                textBox1.Clear();
            }
            else
                MessageBox.Show("File not found..Please enter a valid filename into the textbox.");
        }

        private void Form1_Load(object sender, EventArgs e)  //form loading
        {
            textBox1.Text = f_name;
        }
        private void overwrite(string filename,int n)       //function for overwritting the file
        {
            byte input;
            FileStream mystream = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite);
             if (mystream.CanWrite)
             {
                 if(n==1) //for 1 randomize the process
                 {
                     //writting 0
                     mystream.Seek(0, SeekOrigin.Begin);
                      input = 48;                   
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }
                     //writting 1
                     mystream.Seek(0, SeekOrigin.Begin);
                     input = 49;  
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }
                     //writting random
                     mystream.Seek(0, SeekOrigin.Begin);
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         input = Convert.ToByte(rnd.Next(255));
                         mystream.WriteByte(input);
                     }
                 }
                 else if (n == 2) //for 2 randomize the process
                 {
                     //writting random
                     mystream.Seek(0, SeekOrigin.Begin);
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         input = Convert.ToByte(rnd.Next(255));
                         mystream.WriteByte(input);
                     }
                     //writting 0
                     mystream.Seek(0, SeekOrigin.Begin);
                      input = 48;
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }
                     //writting 1
                     mystream.Seek(0, SeekOrigin.Begin);
                     input = 49;
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }
                 }
                 else if (n == 3) //for 3 randomize the process
                 {
                     //writting 1
                     mystream.Seek(0, SeekOrigin.Begin);
                     input = 49;
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }
                     //writting random
                     mystream.Seek(0, SeekOrigin.Begin);
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         input = Convert.ToByte(rnd.Next(255));
                         mystream.WriteByte(input);
                     }
                     //writting 0
                     mystream.Seek(0, SeekOrigin.Begin);
                     input = 48;
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }
                    
                 }
                 else if (n == 4) //for 4 randomize the process
                 {
                    
                     //writting 0
                     mystream.Seek(0, SeekOrigin.Begin);
                     input = 48;
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }
                     //writting 1
                     mystream.Seek(0, SeekOrigin.Begin);
                     input = 49;
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }

                     //writting 0
                     mystream.Seek(0, SeekOrigin.Begin);
                     input = 48;
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }
                     //writting 1
                     mystream.Seek(0, SeekOrigin.Begin);
                     input = 49;
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }

                 }
                 else if (n == 5) //for 5 randomize the process
                 {
                     //writting random
                     mystream.Seek(0, SeekOrigin.Begin);
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         input = Convert.ToByte(rnd.Next(255));
                         mystream.WriteByte(input);
                     }
                     //writting 1
                     mystream.Seek(0, SeekOrigin.Begin);
                     input = 49;
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }
                     //writting 1
                     mystream.Seek(0, SeekOrigin.Begin);
                     input = 49;
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }
                     //writting 0
                     mystream.Seek(0, SeekOrigin.Begin);
                     input = 48;
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }
                 }
                 else  //for 6 randomize the process
                 {
                     //writting random
                     mystream.Seek(0, SeekOrigin.Begin);
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         input = Convert.ToByte(rnd.Next(255));
                         mystream.WriteByte(input);
                     }
                     //writting random
                     mystream.Seek(0, SeekOrigin.Begin);
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         input = Convert.ToByte(rnd.Next(255));
                         mystream.WriteByte(input);
                     }
                     //writting 0
                     mystream.Seek(0, SeekOrigin.Begin);
                     input = 48;
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }
                     //writting 0
                     mystream.Seek(0, SeekOrigin.Begin);
                     input = 48;
                     for (int i = 0; i < mystream.Length; i++)
                     {
                         mystream.WriteByte(input);
                     }
                 }
                 mystream.Flush();
                 mystream.Close();
             }
        }
    }
}
