/*
 * Author: Jacob Swift
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// Class to make text editor with save and open file capabilities.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// loads the GUI
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// open file dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
        /// <summary>
        /// Event handler for the open file Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(uxOpenFileDialog.FileName + " could not be opened.");
            }
        }
        /// <summary>
        /// Event handler for the save as function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(uxSaveFileDialog.FileName + " could not be saved.");

            }
        }
    }
}
