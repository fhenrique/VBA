using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace GreenUPProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds;
            DataTable dt;
            DataGridView gdvClientes;
            
            ds = new DataSet();

            try
            {
                ds.ReadXml("c:/dados/clientes.xml");
                dt = ds.Tables("Clientes");
            }
            catch (FileNotFoundException ex)
            {
                dt = new DataTable("Clientes");
                dt.Columns.Add("Codigo");
                dt.Columns.Add("Nome");
                dt.Columns.Add("Endereco");
                dt.Columns.Add("Cidade");
                dt.Columns.Add("Cep");
                dt.Columns.Add("Telefone");
                dt.Columns.Add("Email");
                ds.Tables.Add(dt);
            }
            gdvClientes.DataSource = dt;
        }
    }
}
