using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inFilename.Text = openFileDialog1.FileName;
            }
        }

        private void outBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outFilename.Text = openFileDialog1.FileName;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            FileStream inFs;
            FileStream outFs;
            StreamReader reader;
            StreamWriter writer;
            String line;
            Int32 fizzNum;
            Int32 buzzNum;
            Int32 count;

            //Open input file.
            inFs = openFileStream(inFilename.Text, FileMode.Open);
            reader = openReader(inFs);

            //Open output file.
            outFs = openFileStream(outFilename.Text, FileMode.Create);
            writer = openWriter(outFs);

            //TODO: FizzBuzz...
            while ((line = reader.ReadLine()) != null)
            {
                bool inputValid = true;

                String[] numbers = line.Split(' ');

                fizzNum = Convert.ToInt32(numbers[0]);
                if ((fizzNum < 1) || (fizzNum > 20))
                {
                    writer.WriteLine("Fizz number is out of range [1, 20], received: " + fizzNum.ToString());
                    inputValid = false;
                }

                buzzNum = Convert.ToInt32(numbers[1]);
                if ((buzzNum < 1) || (buzzNum > 20))
                {
                    writer.WriteLine("Buzz number is out of range [1, 20], received: " + buzzNum.ToString());
                    inputValid = false;
                }

                count = Convert.ToInt32(numbers[2]);
                if ((count < 21) || (count > 100))
                {
                    writer.WriteLine("Count number is out of range [1, 20], received: " + count.ToString());
                    inputValid = false;
                }

                if (inputValid)
                    doFizzBuzz(fizzNum, buzzNum, count, writer);
            }

            reader.Close();
            writer.Close();
            inFs.Close();
            outFs.Close();

            System.Diagnostics.Process.Start("notepad.exe", outFilename.Text);

            Application.Exit();
        }

        private void doFizzBuzz(int pFizz, int pBuzz, int pCount, StreamWriter outputStream)
        {
            String outString = String.Empty;
            String fbString = String.Empty;

            for (int number = 1; number < pCount + 1; number ++)
            {
                fbString = String.Empty;

                if ((number % pFizz) == 0) //Add Fizz (F)
                    fbString += "F";

                if ((number % pBuzz) == 0) //Add Buzz (B)
                    fbString += "B";

                if (fbString == String.Empty) //Add number
                    fbString = number.ToString();

                outString += fbString;

                if (number < pCount)
                    outString += " ";
            }

            outputStream.WriteLine(outString);
#if DEBUG
            Console.WriteLine(outString);
#endif
        }

        public FileStream openFileStream(String pFilename, FileMode pFileMode)
        {
            FileStream stream = File.Open(pFilename, pFileMode);
            return (stream);
        }

        public StreamReader openReader(FileStream pStream)
        {
            StreamReader reader = new StreamReader(pStream);
            return (reader);
        }

        public StreamWriter openWriter (FileStream pStream)
        {
            StreamWriter writer = new StreamWriter(pStream);
            return (writer);
        }

    }
}
