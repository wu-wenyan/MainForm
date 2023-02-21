// 匯入 System.Diagnostics
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process notePad = new Process();
            // FileName 是要執行的檔案
            notePad.StartInfo.FileName = "CSD01.exe";
            notePad.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process notePad = new Process();
            // FileName 是要執行的檔案
            notePad.StartInfo.FileName = "CSD2.exe";
            notePad.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process notePad = new Process();
            // FileName 是要執行的檔案
            notePad.StartInfo.FileName = "CSD03.exe";
            notePad.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process notePad = new Process();
            // FileName 是要執行的檔案
            notePad.StartInfo.FileName = "CSD04.exe";
            notePad.Start();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}