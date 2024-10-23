using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KONTROSHA_MASIVI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x=double.Parse(textBox1.Text);
            double y=double.Parse(textBox2.Text);
            Rectangle t1 = new Rectangle(x, y);
            Rectangle t2 = new Rectangle(2, 2);
            Rectangle t3= new Rectangle(-5,10);
  
            // t1 (parastais taisnstūris)
            richTextBox1.AppendText("t1 (Parastais taisnstūris):\n");
            richTextBox1.AppendText(t1.ToString() + "\n");
            richTextBox1.AppendText($"Vai taisnstūris? {t1.IsRectangle()}\n");
            richTextBox1.AppendText($"Vai kvadrāts? {t1.IsSquare()}\n");
            richTextBox1.AppendText($"Laukums: {t1.S()}\n");
            richTextBox1.AppendText($"Perimetrs: {t1.P()}\n");
            richTextBox1.AppendText($"Diagonāle: {t1.D()}\n");
            richTextBox1.AppendText($"Maksimālais riņķa rādiuss: {t1.R()}\n\n");

            // t2 (kvadrāts)
            richTextBox1.AppendText("t2 (Kvadrāts):\n");
            richTextBox1.AppendText(t2.ToString() + "\n");
            richTextBox1.AppendText($"Vai taisnstūris? {t2.IsRectangle()}\n");
            richTextBox1.AppendText($"Vai kvadrāts? {t2.IsSquare()}\n");
            richTextBox1.AppendText($"Laukums: {t2.S()}\n");
            richTextBox1.AppendText($"Perimetrs: {t2.P()}\n");
            richTextBox1.AppendText($"Diagonāle: {t2.D()}\n");
            richTextBox1.AppendText($"Maksimālais riņķa rādiuss: {t2.R()}\n\n");

            // t3 (nepareizs taisnstūris)
            richTextBox1.AppendText("t3 (Nepareizs taisnstūris):\n");
            richTextBox1.AppendText(t3.ToString() + "\n");
            richTextBox1.AppendText($"Vai taisnstūris? {t3.IsRectangle()}\n");
            richTextBox1.AppendText($"Vai kvadrāts? {t3.IsSquare()}\n");
            richTextBox1.AppendText($"Laukums: {t3.S()}\n");
            richTextBox1.AppendText($"Perimetrs: {t3.P()}\n");
            richTextBox1.AppendText($"Diagonāle: {t3.D()}\n");
            richTextBox1.AppendText($"Maksimālais riņķa rādiuss: {t3.R()}\n\n");

            t1++;
            try
            {
                t2--;
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("Izņēmums t2 samazināšanas laikā: " + ex.Message + "\n");
            }

            // Izvadām pēc palielināšanas un samazināšanas
            richTextBox1.AppendText("t1 pēc ++: " + t1.ToString() + "\n");
            richTextBox1.AppendText("t2 pēc --: " + t2.ToString() + "\n");

            // Salīdzinām taisnstūrus
            if (t1 > t2)
                richTextBox1.AppendText("t1 laukums ir lielāks par t2\n");
            else if (t1 < t2)
                richTextBox1.AppendText("t1 laukums ir mazāks par t2\n");
            else
                richTextBox1.AppendText("t1 laukums ir vienāds ar t2\n");

            // Salīdzinām malas
            if (t1 == t2)
                richTextBox1.AppendText("t1 un t2 malām ir vienāds garums.\n");
            else
                richTextBox1.AppendText("t1 un t2 malām ir dažādi garumi.\n");
        
    }
    }
}
