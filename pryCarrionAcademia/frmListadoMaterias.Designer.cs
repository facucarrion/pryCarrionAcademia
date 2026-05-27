namespace pryCarrionAcademia
{
    partial class frmListadoMaterias
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
            this.optTodo = new System.Windows.Forms.RadioButton();
            this.optCodigo = new System.Windows.Forms.RadioButton();
            this.optNombre = new System.Windows.Forms.RadioButton();
            this.optPlan = new System.Windows.Forms.RadioButton();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstPlan = new System.Windows.Forms.ComboBox();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // optTodo
            // 
            this.optTodo.AutoSize = true;
            this.optTodo.Location = new System.Drawing.Point(13, 13);
            this.optTodo.Name = "optTodo";
            this.optTodo.Size = new System.Drawing.Size(50, 17);
            this.optTodo.TabIndex = 0;
            this.optTodo.TabStop = true;
            this.optTodo.Text = "Todo";
            this.optTodo.UseVisualStyleBackColor = true;
            // 
            // optCodigo
            // 
            this.optCodigo.AutoSize = true;
            this.optCodigo.Location = new System.Drawing.Point(13, 58);
            this.optCodigo.Name = "optCodigo";
            this.optCodigo.Size = new System.Drawing.Size(61, 17);
            this.optCodigo.TabIndex = 1;
            this.optCodigo.TabStop = true;
            this.optCodigo.Text = "Código:";
            this.optCodigo.UseVisualStyleBackColor = true;
            // 
            // optNombre
            // 
            this.optNombre.AutoSize = true;
            this.optNombre.Location = new System.Drawing.Point(13, 103);
            this.optNombre.Name = "optNombre";
            this.optNombre.Size = new System.Drawing.Size(65, 17);
            this.optNombre.TabIndex = 2;
            this.optNombre.TabStop = true;
            this.optNombre.Text = "Nombre:";
            this.optNombre.UseVisualStyleBackColor = true;
            // 
            // optPlan
            // 
            this.optPlan.AutoSize = true;
            this.optPlan.Location = new System.Drawing.Point(13, 153);
            this.optPlan.Name = "optPlan";
            this.optPlan.Size = new System.Drawing.Size(49, 17);
            this.optPlan.TabIndex = 3;
            this.optPlan.TabStop = true;
            this.optPlan.Text = "Plan:";
            this.optPlan.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(89, 58);
            this.txtCodigo.Mask = "0000";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(144, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 103);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lstPlan
            // 
            this.lstPlan.FormattingEnabled = true;
            this.lstPlan.Location = new System.Drawing.Point(89, 153);
            this.lstPlan.Name = "lstPlan";
            this.lstPlan.Size = new System.Drawing.Size(144, 21);
            this.lstPlan.TabIndex = 6;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colPlan,
            this.colActivo});
            this.dgvMaterias.Location = new System.Drawing.Point(239, 12);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(444, 194);
            this.dgvMaterias.TabIndex = 7;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colPlan
            // 
            this.colPlan.HeaderText = "Plan";
            this.colPlan.Name = "colPlan";
            // 
            // colActivo
            // 
            this.colActivo.HeaderText = "Estado";
            this.colActivo.Name = "colActivo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(13, 183);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(220, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmListadoMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 218);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.lstPlan);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.optPlan);
            this.Controls.Add(this.optNombre);
            this.Controls.Add(this.optCodigo);
            this.Controls.Add(this.optTodo);
            this.Name = "frmListadoMaterias";
            this.Text = "Listado de Materias";
            this.Load += new System.EventHandler(this.frmListadoMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optTodo;
        private System.Windows.Forms.RadioButton optCodigo;
        private System.Windows.Forms.RadioButton optNombre;
        private System.Windows.Forms.RadioButton optPlan;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox lstPlan;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivo;
        private System.Windows.Forms.Button btnBuscar;
    }
}