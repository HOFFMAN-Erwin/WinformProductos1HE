using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinformProductos1HE
{
    public partial class FormProductos : Form
    {

        Producto prodExistente;
        bool nuevo = true;
        int fila;
        Producto NuevoProducto;
        public FormProductos()

        {
            InitializeComponent();
            dgv_Crear();

        }

        void dgv_Crear()
        {
            dgv_Productos.Columns.Add("0", "Código");
            dgv_Productos.Columns.Add("1", "Descripción");
            dgv_Productos.Columns.Add("2", "Stock");
            // Tamaño Columnas
            dgv_Productos.Columns[0].Width = 170;
            dgv_Productos.Columns[1].Width = 320;
            dgv_Productos.Columns[2].Width = 120;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            NuevoProducto = new Producto(int.Parse(txb_Codigo.Text), txb_Descripcion.Text);
            lbl_cod_mov.Text =NuevoProducto.p_codigo.ToString();
            lbl_descripMov.Text = NuevoProducto.p_descripcion;
            lbl_StockMov.Text = "Hay "+NuevoProducto.p_stock.ToString()+" unidades.";

            tabC_productos.SelectTab = tabP_movimiento;
            txb_Movim.Clear();
            txb_Movim.Focus();
            MessageBox.Show("Producto Instanciado");

            //agregar al dgv
            dgv_Productos.Rows.Add(NuevoProducto.p_codigo.ToString(), NuevoProducto.p_descripcion.ToString(), NuevoProducto.p_stock.ToString());
            fila = (dgv_Productos.Rows.Count - 1);
            nuevo = true;
        }

        private void dgv_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdExistente = new Producto(Convert.ToInt32(dgv_Productos.CurrentRow.Cells[0].Value),
                          dgv_Productos.CurrentRow.Cells[1].Value.ToString(),
                          Convert.ToInt32(dgv_Productos.CurrentRow.Cells[2].Value));

            lblCodigoMov.Text = ProdExistente.p_codigo.ToString();
            lblDescripMov.Text = ProdExistente.p_descripcion;
            lblStockmov.Text = "Hay " + ProdExistente.p_stock.ToString() + " Unidades";
            txb_Movim.Clear();
            Fila = e.RowIndex;
            nuevo = false;
        }

        private void btn_act_mov_Click(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                if (rb_Ingreso.Checked == true)
                {
                    NuevoProd.Ingreso(int.Parse(txb_Movim.Text));
                }
                if (rb_Egreso.Checked == true)
                {
                    NuevoProd.Salida(int.Parse(txb_Movim.Text));
                }
                LlevarProdAldgv(NuevoProd, fila);
            }
            else
            {
                if (rb_Ingreso.Checked == true)
                {
                    ProdExistente.Ingreso(int.Parse(txb_Movim.Text));
                }
                if (rb_Egreso.Checked == true)
                {
                    ProdExistente.Salida(int.Parse(txb_Movim.Text));
                }
                LlevarProdAldgv(ProdExistente, fila);
            }
            void LlevarProdAldgv(Producto Prod, int lugar)
            {
                dgv_Productos[0, lugar].Value = Prod.p_codigo.ToString();
                dgv_Productos[1, lugar].Value = Prod.p_descripcion;
                dgv_Productos[2, lugar].Value = Prod.p_stock.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
