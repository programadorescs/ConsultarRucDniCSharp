using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarRucDniCSharp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private async void btnConsultar_Click(object sender, EventArgs e)
    {
      var mApiRest = new ApiRest();
      mApiRest.apiDni = "https://dniruc.apisperu.com/api/v1/dni/";
      mApiRest.apiRuc = "https://dniruc.apisperu.com/api/v1/ruc/";
      mApiRest.token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImphY2tzcHlAZ21haWwuY29tIn0.mbpfVZO4wvopyEeNk4hhmAgeUG6SwxjcaOOJyHj4aok";
      /*
       apiDni, tokenDni
      apiRuc, tokenRuc
       */
      if (txtBuscar.Text.Length != 11 && txtBuscar.Text.Length != 8)
      {
        MessageBox.Show("Nro documento incorrecto");
        return;
      }

      txtDni.Clear();
      txtNombre.Clear();
      txtDireccion.Clear();

      var tipoDoc = "Reniec";
      if (txtBuscar.Text.Length == 11)
      {
        tipoDoc = "Sunat";
      }

      try
      {
        if (tipoDoc.Equals("Reniec"))
        {
          lblCarga.Visible = true;
          var cliente = await ApisPeru_ConsultarDocumento.ConsultarDni(mApiRest, txtBuscar.Text.Trim());
          lblCarga.Visible = false;

          if (cliente != null)
          {
            txtDni.Text = cliente.dni;
            txtNombre.Text = cliente.nombreApellido;
            txtDireccion.Text = "";
          }
          else
            LimpiarTextos();
        }
        else
        {
          lblCarga.Visible = true;
          var cliente = await ApisPeru_ConsultarDocumento.ConsultarRuc(mApiRest, txtBuscar.Text.Trim());
          lblCarga.Visible = true;

          if (cliente != null)
          {
            txtDni.Text = cliente.ruc;
            txtNombre.Text = cliente.razonSocial;
            txtDireccion.Text = cliente.direccion;
          }
          else
            LimpiarTextos();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void LimpiarTextos()
    {
      txtDni.Clear();
      txtNombre.Clear();
      txtDireccion.Clear();

      MessageBox.Show("No se encontro ningun registro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void btnConsultarApiDevPeru_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Lo sentimos, aun en desarrollo...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
  }
}
