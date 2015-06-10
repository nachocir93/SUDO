namespace PagoElectronico.ABM_Rol
{
    partial class FormABMRol
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.dataGridRoles = new System.Windows.Forms.DataGridView();
            this.nombreRolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.estado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado";
            // 
            // estado
            // 
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Todos",
            "Activos",
            "Inactivos"});
            this.estado.Location = new System.Drawing.Point(303, 35);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(129, 21);
            this.estado.TabIndex = 4;
            this.estado.Text = "Todos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(96, 35);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(129, 20);
            this.nombre.TabIndex = 0;
            this.nombre.Tag = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(400, 133);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 2;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // dataGridRoles
            // 
            this.dataGridRoles.AllowUserToAddRows = false;
            this.dataGridRoles.AllowUserToDeleteRows = false;
            this.dataGridRoles.AutoGenerateColumns = false;
            this.dataGridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreRolDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.Editar,
            this.Eliminar});
            this.dataGridRoles.DataSource = this.rolBindingSource;
            this.dataGridRoles.Location = new System.Drawing.Point(30, 172);
            this.dataGridRoles.Name = "dataGridRoles";
            this.dataGridRoles.ReadOnly = true;
            this.dataGridRoles.Size = new System.Drawing.Size(445, 145);
            this.dataGridRoles.TabIndex = 3;
            this.dataGridRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoles_CellContentClick);
            // 
            // nombreRolDataGridViewTextBoxColumn
            // 
            this.nombreRolDataGridViewTextBoxColumn.DataPropertyName = "nombreRol";
            this.nombreRolDataGridViewTextBoxColumn.HeaderText = "nombreRol";
            this.nombreRolDataGridViewTextBoxColumn.Name = "nombreRolDataGridViewTextBoxColumn";
            this.nombreRolDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreRolDataGridViewTextBoxColumn.ToolTipText = "Editar";
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataSource = typeof(PagoElectronico.Dominio.Rol);
            // 
            // FormABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 329);
            this.Controls.Add(this.dataGridRoles);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormABMRol";
            this.Text = "ABM Rol";
            this.Load += new System.EventHandler(this.FormABMRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView dataGridRoles;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
