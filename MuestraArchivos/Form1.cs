using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuestraArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@"\\D406186E927BE\Cockpit$\Cockpit 2.0\Publicaciones\Release 2.1\Fuentes");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.*", SearchOption.AllDirectories); //Getting Text files
            foreach (FileInfo file in Files)
            {
                try
                {
                    var _version = FileVersionInfo.GetVersionInfo(file.FullName).ProductVersion == null ? "" : FileVersionInfo.GetVersionInfo(file.FullName).ProductVersion;
                    rtxtOutput.AppendText(file.DirectoryName + "\t" + file.Name + "\t" + file.LastWriteTime + "\t" + _version + System.Environment.NewLine);
                }
                catch (Exception ex)
                {
                    throw;
                }
                
            }
            
        }
    }
}
