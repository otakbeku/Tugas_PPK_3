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

namespace Tugas_PPK_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method untuk membaca suatu file txt yang isinya ditampilkan 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_Button_Click(object sender, EventArgs e)
        {
            DialogResult Result = FileDialog1.ShowDialog();

            if (richTextBox1.Text != "")
            {
                richTextBox1.Text = "";
            }

            try
            {
                if (Result == DialogResult.OK)
                {
                    //  System.IO.StreamReader sr = new System.IO.StreamReader(FileDialog1.FileName);
                    //  String baca = "";
                    //  while ((baca = sr.ReadLine()) != null)
                    //  {
                    //      richTextBox1.AppendText(baca); Appendtext utk nambahin teks
                    //}

                    //Catatan:

                    ///From the Help files for the System.IO namespace:
                    // StreamReader: Implements a TextReader that reads characters from a byte stream in a particular encoding.
                    // StringReader: Implements a TextReader that reads from a string.
                    // TextReader: Represents a reader that can read a sequential series of characters.

                    // Use the one that's appropriate for the task at hand.
                    ///TextWriter/Reader is an abstract class. It provides an abstraction for writing/reading character based data to/from a data source.
                    //StreamWriter / Reader is a concrete implementation that uses a writeable/ readable Stream as data source.
                    //Since a Stream is abstraction for writing / reading byte based data, an Encoding instance is required for the translation between characters and bytes.
                    // StringWriter / Reader is a concrete implementation that uses a StringBuilder / string as data source.

                    TextReader tx = File.OpenText(FileDialog1.FileName);
                    String baca = tx.ReadToEnd();
                    richTextBox1.Text = baca;

                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error: ", Ex);
                MessageBox.Show("Error");
            }
        }
    }
}
