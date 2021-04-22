namespace ConsultarRucDniCSharp
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.txtBuscar = new System.Windows.Forms.TextBox();
      this.txtNombre = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDireccion = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtDni = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnConsultar = new System.Windows.Forms.Button();
      this.btnConsultarApiDevPeru = new System.Windows.Forms.Button();
      this.lblCarga = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Documento";
      // 
      // txtBuscar
      // 
      this.txtBuscar.Location = new System.Drawing.Point(80, 12);
      this.txtBuscar.Name = "txtBuscar";
      this.txtBuscar.Size = new System.Drawing.Size(100, 20);
      this.txtBuscar.TabIndex = 1;
      // 
      // txtNombre
      // 
      this.txtNombre.BackColor = System.Drawing.Color.White;
      this.txtNombre.Location = new System.Drawing.Point(80, 55);
      this.txtNombre.Name = "txtNombre";
      this.txtNombre.ReadOnly = true;
      this.txtNombre.Size = new System.Drawing.Size(248, 20);
      this.txtNombre.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Nombre";
      // 
      // txtDireccion
      // 
      this.txtDireccion.BackColor = System.Drawing.Color.White;
      this.txtDireccion.Location = new System.Drawing.Point(80, 81);
      this.txtDireccion.Name = "txtDireccion";
      this.txtDireccion.ReadOnly = true;
      this.txtDireccion.Size = new System.Drawing.Size(248, 20);
      this.txtDireccion.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(52, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Direccion";
      // 
      // txtDni
      // 
      this.txtDni.BackColor = System.Drawing.Color.White;
      this.txtDni.Location = new System.Drawing.Point(80, 107);
      this.txtDni.Name = "txtDni";
      this.txtDni.ReadOnly = true;
      this.txtDni.Size = new System.Drawing.Size(248, 20);
      this.txtDni.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 114);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(62, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Documento";
      // 
      // btnConsultar
      // 
      this.btnConsultar.Location = new System.Drawing.Point(54, 164);
      this.btnConsultar.Name = "btnConsultar";
      this.btnConsultar.Size = new System.Drawing.Size(119, 23);
      this.btnConsultar.TabIndex = 8;
      this.btnConsultar.Text = "Consultar ApisPeru";
      this.btnConsultar.UseVisualStyleBackColor = true;
      this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
      // 
      // btnConsultarApiDevPeru
      // 
      this.btnConsultarApiDevPeru.Location = new System.Drawing.Point(179, 164);
      this.btnConsultarApiDevPeru.Name = "btnConsultarApiDevPeru";
      this.btnConsultarApiDevPeru.Size = new System.Drawing.Size(119, 23);
      this.btnConsultarApiDevPeru.TabIndex = 9;
      this.btnConsultarApiDevPeru.Text = "Consultar ApiDevPeru";
      this.btnConsultarApiDevPeru.UseVisualStyleBackColor = true;
      this.btnConsultarApiDevPeru.Click += new System.EventHandler(this.btnConsultarApiDevPeru_Click);
      // 
      // lblCarga
      // 
      this.lblCarga.BackColor = System.Drawing.Color.Yellow;
      this.lblCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCarga.ForeColor = System.Drawing.Color.DarkGreen;
      this.lblCarga.Location = new System.Drawing.Point(15, 138);
      this.lblCarga.Name = "lblCarga";
      this.lblCarga.Size = new System.Drawing.Size(313, 23);
      this.lblCarga.TabIndex = 10;
      this.lblCarga.Text = "Consultando, espere por favor...";
      this.lblCarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblCarga.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(353, 199);
      this.Controls.Add(this.lblCarga);
      this.Controls.Add(this.btnConsultarApiDevPeru);
      this.Controls.Add(this.btnConsultar);
      this.Controls.Add(this.txtDni);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtDireccion);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtNombre);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtBuscar);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Consultar DNI - RUC";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtBuscar;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtDireccion;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtDni;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnConsultar;
    private System.Windows.Forms.Button btnConsultarApiDevPeru;
    private System.Windows.Forms.Label lblCarga;
  }
}

