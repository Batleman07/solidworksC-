using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace ProjetoGen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)

        {
            SldWorks swApp;
            ModelDoc2 swModel;
            swApp =  Marshal.GetActiveObject("sldworks.application") as SldWorks;
            swModel = swApp.NewDocument(swApp.GetDocumentTemplate((int)swDocumentTypes_e.swDocPART,"PART",0,0,0),0,0,0);
        }
    }
}
