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

    private void LimpiarTextos()
    {
      txtDni.Clear();
      txtNombre.Clear();
      txtDireccion.Clear();

      MessageBox.Show("No se encontro ningun registro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private async void btnConsultar_Click(object sender, EventArgs e)
    {
      var mApiRest = new ApiRest();
      mApiRest.apiDni = "https://dniruc.apisperu.com/api/v1/dni/";
      mApiRest.apiRuc = "https://dniruc.apisperu.com/api/v1/ruc/";
      mApiRest.token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImphY2tzcHlAZ21haWwuY29tIn0.mbpfVZO4wvopyEeNk4hhmAgeUG6SwxjcaOOJyHj4aok";
      
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
          lblCarga.Visible = false;

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

    private async void btnConsultarApiDevPeru_Click(object sender, EventArgs e)
    {
      var mApiRest = new ApiRest();
      mApiRest.apiDni = "https://apiperu.dev/api/dni/";
      mApiRest.apiRuc = "https://apiperu.dev/api/ruc/";
      mApiRest.token = "8d205535685ad1614c1be278c3ff5e2b89bea3781eb20f582b6132497cc149cf";

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
          var cliente = await ApiPeruDev_ConsultarDocumento_HttpWebRequest.ConsultarDni(mApiRest, txtBuscar.Text.Trim());
          lblCarga.Visible = false;

          if (cliente.success == "true")
          {
            txtDni.Text = cliente.data.numero;
            txtNombre.Text = cliente.data.nombre_completo;
            txtDireccion.Text = cliente.data.fecha_nacimiento;
          }
          else
            LimpiarTextos();
        }
        else
        {
          lblCarga.Visible = true;
          var cliente = await ApiPeruDev_ConsultarDocumento_HttpWebRequest.ConsultarRuc(mApiRest, txtBuscar.Text.Trim());
          lblCarga.Visible = false;

          if (cliente.success == "true")
          {
            txtDni.Text = cliente.data.ruc;
            txtNombre.Text = cliente.data.nombre_o_razon_social;
            txtDireccion.Text = cliente.data.direccion_completa;
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
  }
}
