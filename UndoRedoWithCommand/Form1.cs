using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UndoRedoWithCommand
{
    public partial class Form1 : Form
    {
        UndoRedo undoRedo = new UndoRedo();
        Exec exec;
        Undo undo;
        Redo redo;

        public Form1()
        {
            InitializeComponent();
            UndoRedo undoRedo = new UndoRedo();
            Exec exec = new Exec(undoRedo);
            Undo undo = new Undo(undoRedo);
            Redo redo = new Redo(undoRedo);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.Z)
            {
                textBox1.Text = undoRedo.Undo(textBox1.Text);
                textBox1.SelectionStart = textBox1.Text.Length + 1;
            }

            else if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.KeyCode == Keys.Y)
            {
                textBox1.Text = undoRedo.Redo(textBox1.Text);
                textBox1.SelectionStart = textBox1.Text.Length + 1;
            }
            else
            {
                undoRedo.Exec(textBox1.Text);
            }

        }
    }
}
