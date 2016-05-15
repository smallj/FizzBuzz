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
        private BinaryReader prvReader;
        private BinaryWriter prvWriter;

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
            FileStream fs;

            //Open input file.
            fs = openFileStream(inFilename.Text, FileMode.Open);
            prvReader = openReader(fs);

            //Open output file.
            fs = openFileStream(outFilename.Text, FileMode.Create);
            prvWriter = openWriter(fs);

            //TODO: FizzBuzz...

            prvReader.Close();
            prvWriter.Close();
        }

        private void FizzBuzz( int pFizz, int pBuzz, int pCount)
        {
            String outString = String.Empty;
            String fbString = String.Empty;

            for (int number = 1; number < pCount + 1; pCount ++)
            {
                fbString = String.Empty;

                if ((number % pFizz) != 0) //Add Fizz (F)
                    fbString += "F";

                if ((number % pBuzz) != 0) //Add Buzz (B)
                    fbString += "B";

                if (fbString == String.Empty) //Add number
                    fbString = number.ToString();

                outString += fbString + " ";
            }
        }

        public FileStream openFileStream(String pFilename, FileMode pFileMode)
        {
            FileStream stream = File.Open(pFilename, pFileMode);
            return (stream);
        }

        public BinaryReader openReader(FileStream pStream)
        {
            BinaryReader reader = new BinaryReader(pStream);
            return (reader);
        }

        public BinaryWriter openWriter (FileStream pStream)
        {
            BinaryWriter writer = new BinaryWriter(pStream);
            return (writer);
        }

    }
}
