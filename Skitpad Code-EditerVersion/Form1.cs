using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skitpad_Code_EditerVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
            private void NewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextInput.Clear();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
             OpenFileDialog op =  new OpenFileDialog();


            op.Title = "Save";
            op.Filter = "Text Document(*.txt)|*.txt| All Filles(*.*)| *.*";
            if (op.ShowDialog() == DialogResult.OK)
            {

                TextInput.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
                this.Text = op.FileName;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog op = new SaveFileDialog();


                op.Title = "Save";
                op.Filter = "Text Document(*.txt)|*.txt| All Filles(*.*)| *.*";
            
            if (op.ShowDialog() == DialogResult.OK)
            {

                TextInput.SaveFile(op.FileName, RichTextBoxStreamType.PlainText);
                this.Text = op.FileName;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           Close();
            
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput.Undo();
        }

        private void RedoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TextInput.Redo();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput.Paste();
        }

        private void CutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TextInput.Cut();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput.SelectAll();
        }

        private void DateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextInput.Text = System.DateTime.Now.ToString();
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog op = new FontDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                TextInput.Font = op.Font;

            }
        }

        private void ColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ColorDialog op = new ColorDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                TextInput.ForeColor = op.Color;
            }
        }

        private void TextInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Ngg All Rights Reserved(Lead Prgrammer JakeByo  Assistant Programmer JakeByo's dad)");
        }

        private void WhenWillWeUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We Will Update Every Month OR week");
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
        private void Form1_ResizeEnd(Object sender, EventArgs e)
        {

            
        }
    }
   }

