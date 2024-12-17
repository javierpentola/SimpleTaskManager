private void InitializeComponent()
{
    this.lstTareas = new System.Windows.Forms.ListBox();
    this.txtDescripcion = new System.Windows.Forms.TextBox();
    this.btnAgregar = new System.Windows.Forms.Button();
    this.btnMarcarCompletada = new System.Windows.Forms.Button();
    this.btnEliminar = new System.Windows.Forms.Button();
    this.SuspendLayout();
    // 
    // lstTareas
    // 
    this.lstTareas.FormattingEnabled = true;
    this.lstTareas.Location = new System.Drawing.Point(12, 12);
    this.lstTareas.Name = "lstTareas";
    this.lstTareas.Size = new System.Drawing.Size(360, 199);
    this.lstTareas.TabIndex = 0;
    // 
    // txtDescripcion
    // 
    this.txtDescripcion.Location = new System.Drawing.Point(12, 227);
    this.txtDescripcion.Name = "txtDescripcion";
    this.txtDescripcion.Size = new System.Drawing.Size(360, 20);
    this.txtDescripcion.TabIndex = 1;
    // 
    // btnAgregar
    // 
    this.btnAgregar.Location = new System.Drawing.Point(12, 253);
    this.btnAgregar.Name = "btnAgregar";
    this.btnAgregar.Size = new System.Drawing.Size(75, 23);
    this.btnAgregar.TabIndex = 2;
    this.btnAgregar.Text = "Agregar";
    this.btnAgregar.UseVisualStyleBackColor = true;
    this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
    // 
    // btnMarcarCompletada
    // 
    this.btnMarcarCompletada.Location = new System.Drawing.Point(93, 253);
    this.btnMarcarCompletada.Name = "btnMarcarCompletada";
    this.btnMarcarCompletada.Size = new System.Drawing.Size(125, 23);
    this.btnMarcarCompletada.TabIndex = 3;
    this.btnMarcarCompletada.Text = "Marcar como completada";
    this.btnMarcarCompletada.UseVisualStyleBackColor = true;
    this.btnMarcarCompletada.Click += new System.EventHandler(this.btnMarcarCompletada_Click);
    // 
    // btnEliminar
    // 
    this.btnEliminar.Location = new System.Drawing.Point(224, 253);
    this.btnEliminar.Name = "btnEliminar";
    this.btnEliminar.Size = new System.Drawing.Size(75, 23);
    this.btnEliminar.TabIndex = 4;
    this.btnEliminar.Text = "Eliminar";
    this.btnEliminar.UseVisualStyleBackColor = true;
    this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
    // 
    // Form1
    // 
    this.ClientSize = new System.Drawing.Size(384, 288);
    this.Controls.Add(this.btnEliminar);
    this.Controls.Add(this.btnMarcarCompletada);
    this.Controls.Add(this.btnAgregar);
    this.Controls.Add(this.txtDescripcion);
    this.Controls.Add(this.lstTareas);
    this.Name = "Form1";
    this.Text = "Gestión de Tareas";
    this.ResumeLayout(false);
    this.PerformLayout();
}
