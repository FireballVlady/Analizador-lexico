using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lexemas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Regex expreIf= new Regex(@"[/^If|if]");
            Regex expreElse = new Regex(@"[/^else|Else]");
            Regex expresionNum = new Regex(@"[/^0-9]+");
            Regex expreParentesisAper = new Regex(@"[/^\(]");
            Regex expreParentesisCerrar = new Regex(@"[/^\)]");
            Regex expreLlaveAper = new Regex(@"[/^\{]");
            Regex expreLlaveCerrar = new Regex(@"[/^\}]");
            Regex exprePalabras = new Regex("/^(\"([A-Z][a-z]+[0-9]*)\")|(\"([a-z]+[0-9]*)\")|(\"([A-Z]+[0-9]*)\")");
            Regex expreOp = new Regex(@"[/^\=|\+|\-|\*]");
            Regex expreId = new Regex(@"\;|\:|[a-z]+");

            foreach (Match elemento in expreId.Matches(textBox1.Text))
            {
                listBox1.Items.Add(elemento.Value);
            }
            foreach (Match elemento in expresionNum.Matches(textBox1.Text))
            {
                listBox2.Items.Add(elemento.Value);
            }
            
            foreach (Match elemento in expreParentesisAper.Matches(textBox1.Text))
            {
                listBox3.Items.Add(elemento.Value);
            }
            foreach (Match elemento in exprePalabras.Matches(textBox1.Text))
            {
                listBox4.Items.Add(elemento.Value);
            }
            foreach (Match elemento in expreParentesisCerrar.Matches(textBox1.Text))
            {
                listBox5.Items.Add(elemento.Value);
            }
            foreach (Match elemento in expreLlaveAper.Matches(textBox1.Text))
            {
                listBox6.Items.Add(elemento.Value);
            }
            foreach (Match elemento in expreLlaveCerrar.Matches(textBox1.Text))
            {
                listBox7.Items.Add(elemento.Value);
            }
            foreach (Match elemento in expreOp.Matches(textBox1.Text))
            {
                listBox8.Items.Add(elemento.Value);
            }
            foreach (Match elemento in expreElse.Matches(textBox1.Text))
            {
                listBox9.Items.Add(elemento.Value);
            }
            foreach (Match elemento in expreIf.Matches(textBox1.Text))
            {
                listBox10.Items.Add(elemento.Value);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
