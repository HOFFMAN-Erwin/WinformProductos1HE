namespace WinformProductos1HE
{
    partial class FormProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabC_productos = new System.Windows.Forms.TabPage();
            this.txb_Stock = new System.Windows.Forms.TextBox();
            this.txb_Descripcion = new System.Windows.Forms.TextBox();
            this.txb_Codigo = new System.Windows.Forms.TextBox();
            this.tabP_movimiento = new System.Windows.Forms.TabPage();
            this.lbl_StockMov = new System.Windows.Forms.Label();
            this.lbl_descripMov = new System.Windows.Forms.Label();
            this.lbl_cod_mov = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_act_mov = new System.Windows.Forms.Button();
            this.txb_Movim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Productos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabC_productos.SuspendLayout();
            this.tabP_movimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stock";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabC_productos);
            this.tabControl1.Controls.Add(this.tabP_movimiento);
            this.tabControl1.Location = new System.Drawing.Point(53, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 183);
            this.tabControl1.TabIndex = 2;
            // 
            // tabC_productos
            // 
            this.tabC_productos.Controls.Add(this.txb_Stock);
            this.tabC_productos.Controls.Add(this.txb_Descripcion);
            this.tabC_productos.Controls.Add(this.txb_Codigo);
            this.tabC_productos.Controls.Add(this.button1);
            this.tabC_productos.Controls.Add(this.label3);
            this.tabC_productos.Controls.Add(this.label1);
            this.tabC_productos.Controls.Add(this.label2);
            this.tabC_productos.Location = new System.Drawing.Point(4, 22);
            this.tabC_productos.Name = "tabC_productos";
            this.tabC_productos.Padding = new System.Windows.Forms.Padding(3);
            this.tabC_productos.Size = new System.Drawing.Size(692, 157);
            this.tabC_productos.TabIndex = 0;
            this.tabC_productos.Text = "Carga de Productos";
            this.tabC_productos.UseVisualStyleBackColor = true;
            // 
            // txb_Stock
            // 
            this.txb_Stock.Location = new System.Drawing.Point(121, 118);
            this.txb_Stock.Name = "txb_Stock";
            this.txb_Stock.Size = new System.Drawing.Size(100, 20);
            this.txb_Stock.TabIndex = 2;
            // 
            // txb_Descripcion
            // 
            this.txb_Descripcion.Location = new System.Drawing.Point(121, 76);
            this.txb_Descripcion.Name = "txb_Descripcion";
            this.txb_Descripcion.Size = new System.Drawing.Size(100, 20);
            this.txb_Descripcion.TabIndex = 2;
            // 
            // txb_Codigo
            // 
            this.txb_Codigo.Location = new System.Drawing.Point(121, 37);
            this.txb_Codigo.Name = "txb_Codigo";
            this.txb_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txb_Codigo.TabIndex = 2;
            // 
            // tabP_movimiento
            // 
            this.tabP_movimiento.Controls.Add(this.lbl_StockMov);
            this.tabP_movimiento.Controls.Add(this.lbl_descripMov);
            this.tabP_movimiento.Controls.Add(this.lbl_cod_mov);
            this.tabP_movimiento.Controls.Add(this.radioButton2);
            this.tabP_movimiento.Controls.Add(this.radioButton1);
            this.tabP_movimiento.Controls.Add(this.btn_act_mov);
            this.tabP_movimiento.Controls.Add(this.txb_Movim);
            this.tabP_movimiento.Controls.Add(this.label4);
            this.tabP_movimiento.Location = new System.Drawing.Point(4, 22);
            this.tabP_movimiento.Name = "tabP_movimiento";
            this.tabP_movimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_movimiento.Size = new System.Drawing.Size(692, 157);
            this.tabP_movimiento.TabIndex = 1;
            this.tabP_movimiento.Text = "Movimiento de Productos";
            this.tabP_movimiento.UseVisualStyleBackColor = true;
            // 
            // lbl_StockMov
            // 
            this.lbl_StockMov.AutoSize = true;
            this.lbl_StockMov.Location = new System.Drawing.Point(43, 92);
            this.lbl_StockMov.Name = "lbl_StockMov";
            this.lbl_StockMov.Size = new System.Drawing.Size(35, 13);
            this.lbl_StockMov.TabIndex = 4;
            this.lbl_StockMov.Text = "label5";
            // 
            // lbl_descripMov
            // 
            this.lbl_descripMov.AutoSize = true;
            this.lbl_descripMov.Location = new System.Drawing.Point(43, 60);
            this.lbl_descripMov.Name = "lbl_descripMov";
            this.lbl_descripMov.Size = new System.Drawing.Size(35, 13);
            this.lbl_descripMov.TabIndex = 4;
            this.lbl_descripMov.Text = "label5";
            // 
            // lbl_cod_mov
            // 
            this.lbl_cod_mov.AutoSize = true;
            this.lbl_cod_mov.Location = new System.Drawing.Point(43, 30);
            this.lbl_cod_mov.Name = "lbl_cod_mov";
            this.lbl_cod_mov.Size = new System.Drawing.Size(35, 13);
            this.lbl_cod_mov.TabIndex = 4;
            this.lbl_cod_mov.Text = "label5";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(264, 118);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Egreso";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(264, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ingreso";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_act_mov
            // 
            this.btn_act_mov.Location = new System.Drawing.Point(390, 92);
            this.btn_act_mov.Name = "btn_act_mov";
            this.btn_act_mov.Size = new System.Drawing.Size(75, 43);
            this.btn_act_mov.TabIndex = 2;
            this.btn_act_mov.Text = "Aceptar";
            this.btn_act_mov.UseVisualStyleBackColor = true;
            this.btn_act_mov.Click += new System.EventHandler(this.btn_act_mov_Click);
            // 
            // txb_Movim
            // 
            this.txb_Movim.Location = new System.Drawing.Point(98, 115);
            this.txb_Movim.Name = "txb_Movim";
            this.txb_Movim.Size = new System.Drawing.Size(100, 20);
            this.txb_Movim.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad";
            // 
            // dgv_Productos
            // 
            this.dgv_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Productos.Location = new System.Drawing.Point(57, 263);
            this.dgv_Productos.Name = "dgv_Productos";
            this.dgv_Productos.Size = new System.Drawing.Size(692, 150);
            this.dgv_Productos.TabIndex = 3;
            this.dgv_Productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Productos_CellContentClick);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Productos);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.tabControl1.ResumeLayout(false);
            this.tabC_productos.ResumeLayout(false);
            this.tabC_productos.PerformLayout();
            this.tabP_movimiento.ResumeLayout(false);
            this.tabP_movimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabC_productos;
        private System.Windows.Forms.TextBox txb_Stock;
        private System.Windows.Forms.TextBox txb_Descripcion;
        private System.Windows.Forms.TextBox txb_Codigo;
        private System.Windows.Forms.TabPage tabP_movimiento;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_act_mov;
        private System.Windows.Forms.TextBox txb_Movim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Productos;
        private System.Windows.Forms.Label lbl_descripMov;
        private System.Windows.Forms.Label lbl_cod_mov;
        private System.Windows.Forms.Label lbl_StockMov;
    }
}