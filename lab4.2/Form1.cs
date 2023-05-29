using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4._2
{
    public partial class Form1 : Form
    {
        public class chislo
        {
            public int i;
            public System.EventHandler observers;
            public void setvalue(int setValue, ref int aValue, ref int bValue, ref int cValue, string s)
            {
                // i = setvalue;

                if (s == "A")
                {
                    i = setValue;
                    if (setValue >= bValue)
                    {
                        bValue = setValue;

                    }
                    if (setValue >= cValue)
                    {

                        cValue = setValue;
                    }

                }
                if (s == "B")
                {
                    if (setValue >= aValue && setValue <= cValue)
                        i = setValue;
                }
                if (s == "C")
                {
                    i = setValue;
                    if (setValue <= bValue)
                    {
                        bValue = setValue;

                    }
                    if (setValue <= aValue)
                    {

                        aValue = setValue;
                    }

                }
                // MessageBox.Show(s); 
                observers.Invoke(this, null);   // перепоручение (делегирование) классу GUI методов, связанных с интерфейсом пользователя
            }
            public int getvalue()
            {
                return i;
            }
            public void loadValues()
            {

                observers.Invoke(this, null);   // перепоручение (делегирование) классу GUI методов, связанных с интерфейсом пользователя
            }
        }





        chislo A = new chislo();
        chislo B = new chislo();
        chislo C = new chislo();
        Dictionary<chislo, string> elements = new Dictionary<chislo, string>();

        public Form1()
        {

            InitializeComponent();
            elements.Add(A, "A");
            elements.Add(B, "B");
            elements.Add(C, "C");
            foreach (var i in elements)
            {
                i.Key.observers += new System.EventHandler(this.UpdateFromModel);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.value_A = A.i;
            Properties.Settings.Default.value_B = B.i;
            Properties.Settings.Default.value_C = C.i;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            A.i = Properties.Settings.Default.value_A;
            B.i = Properties.Settings.Default.value_B;
            C.i = Properties.Settings.Default.value_C;
            A.loadValues();

        }

        private void UpdateFromModel(object sender, EventArgs e)
        {
            textBoxA.Text = A.getvalue().ToString();
            numericUpDownA.Value = A.getvalue();
            trackBarA.Value = A.getvalue();
            textBoxB.Text = B.getvalue().ToString();
            numericUpDownB.Value = B.getvalue();
            trackBarB.Value = B.getvalue();
            textBoxC.Text = C.getvalue().ToString();
            numericUpDownC.Value = C.getvalue();
            trackBarC.Value = C.getvalue();
        }





        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            var trackbar = sender as TrackBar;
            String s1 = trackbar.Name.Substring(trackbar.Name.Length - 1);
            foreach (var i in elements)
            {
                if (i.Value == s1)
                    i.Key.setvalue(trackbar.Value, ref A.i, ref B.i, ref C.i, i.Value);
            }
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            var numUpDown = sender as NumericUpDown;
            String s1 = numUpDown.Name.Substring(numUpDown.Name.Length - 1);
            foreach (var i in elements)
            {
                if (i.Value == s1)
                    i.Key.setvalue((int)numUpDown.Value, ref A.i, ref B.i, ref C.i, i.Value);
            }
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var txt = sender as TextBox;
                    String s1 = txt.Name.Substring((txt).Name.Length - 1);
                    foreach (var i in elements)
                    {
                        if (i.Value == s1)
                        {
                            i.Key.setvalue(Int32.Parse(txt.Text), ref A.i, ref B.i, ref C.i, i.Value);
                        }
                    }
                }
            }
            catch (Exception) { }
        }




    }

}
