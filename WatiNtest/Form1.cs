using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Importar las librerias de WatiN
using WatiN.Core;
using WatiN.Core.Native.InternetExplorer;

namespace WatiNtest
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private IE browser = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Inicializar el explorador web
            browser = new IE();
            tbConsole.Text = "Empezando...";
            //Ir al sitio web deseado
            browser.GoTo("http://www.google.com");
            //Localizar el text box de google y llenarlo
            browser.TextField(Find.ByName("q")).TypeText("TarritoAzul.com");
            //Hacer click en el boton de buscar
            browser.Element(Find.ByName("btnG")).Click();
            browser.WaitForComplete();
            tbConsole.AppendText("Fin.");
        }
    }
}
