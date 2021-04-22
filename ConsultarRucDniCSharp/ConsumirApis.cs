using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ConsultarRucDniCSharp
{
  class ConsumirApis
  {
  }

  #region ******* ApisPeru *******
  public class ApisPeru_Dni
  {
    public string dni { get; set; }
    public string nombres { get; set; }
    public string apellidoPaterno { get; set; }
    public string apellidoMaterno { get; set; }
    public string codVerifica { get; set; }
    public string nombreApellido { get { return nombres + " " + apellidoPaterno + " " + apellidoMaterno; } }
  }

  public class ApisPeru_Ruc
  {
    public string ruc { get; set; }
    public string razonSocial { get; set; }
    public string nombreComercial { get; set; }
    public string direccion { get; set; }
    public string estado { get; set; }
    public string condicion { get; set; }
    public string departamento { get; set; }
    public string provincia { get; set; }
    public string distrito { get; set; }
    public string profesion { get; set; }
    public string direccionCompleta { get { return direccion + " " + departamento + " " + provincia + " " + distrito; } }
  }

  public class ApisPeru_ConsultarDocumento
  {
    public static async Task<ApisPeru_Dni> ConsultarDni(ApiRest mApiRest, string nroDocumento)
    {
      var result = await Task.Run(() =>
      {
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(mApiRest.apiDni + nroDocumento + "?token=" + mApiRest.token);
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "GET";

        // Recibir la respuesta de la consulta
        ApisPeru_Dni entidad;
        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
          entidad = JsonConvert.DeserializeObject<ApisPeru_Dni>(streamReader.ReadToEnd());
        }

        return entidad;
      });
      return result;
    }

    public static async Task<ApisPeru_Ruc> ConsultarRuc(ApiRest mApiRest, string nroDocumento)
    {
      var result = await Task.Run(() =>
      {
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(mApiRest.apiRuc + nroDocumento + "?token=" + mApiRest.token);
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "GET";

        // Recibir la respuesta de la consulta
        ApisPeru_Ruc entidad;
        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
          entidad = JsonConvert.DeserializeObject<ApisPeru_Ruc>(streamReader.ReadToEnd());
        }

        return entidad;
      });
      return result;
    }
  }

  #endregion


  #region ******* ApiPeru.DEV *******

  public class ApiPeruDevData_Dni
  {
    public string success { get; set; }
    public ApiPeruDev_Dni data { get; set; }


    public class ApiPeruDev_Dni
    {
      public string numero { get; set; }
      public string nombre_completo { get; set; }
      public string nombres { get; set; }
      public string apellido_paterno { get; set; }
      public string apellido_materno { get; set; }
      public string codigo_verificacion { get; set; }
      public string fecha_nacimiento { get; set; }
      public string sexo { get; set; }
    }
  }

  public class ApiPeruDevData_Ruc
  {
    public string success { get; set; }
    public ApiPeruDev_Ruc data { get; set; }


    public class ApiPeruDev_Ruc
    {
      public string ruc { get; set; }
      public string nombre_o_razon_social { get; set; }
      public string nombre_comercial { get; set; }
      public string estado { get; set; }
      public string condicion { get; set; }
      public string direccion { get; set; }
      public string direccion_completa { get; set; }
    }
  }

  public class Consulta_CPE
  {
    public string ruc_emisor { get; set; }
    public string codigo_tipo_documento { get; set; }
    public string serie_documento { get; set; }
    public string numero_documento { get; set; }
    public string fecha_de_emision { get; set; }
    public decimal total { get; set; }
  }

  public class Respuesta_CPE
  {
    public string success { get; set; }
    public Datos_cpe data { get; set; }


    public class Datos_cpe
    {
      public string comprobante_estado_codigo { get; set; }
      public string comprobante_estado_descripcion { get; set; }
      public string empresa_estado_codigo { get; set; }
      public string empresa_estado_description { get; set; }
      public string empresa_condicion_codigo { get; set; }
      public string empresa_condicion_descripcion { get; set; }
    }
  }

  public class ApiPeruDev_ConsultarDocumento_HttpWebRequest
  {
    public static async Task<ApiPeruDevData_Dni> ConsultarDni(ApiRest mApiRest, string nroDocumento)
    {
      var result = await Task.Run(() =>
      {
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(mApiRest.apiDni + nroDocumento);
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Headers.Add("Authorization", "Bearer " + mApiRest.token);
        httpWebRequest.Method = "GET";

        // Recibir la respuesta de la consulta
        ApiPeruDevData_Dni entidad;
        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
          entidad = JsonConvert.DeserializeObject<ApiPeruDevData_Dni>(streamReader.ReadToEnd());
        }

        return entidad;
      });
      return result;
    }

    public static async Task<ApiPeruDevData_Ruc> ConsultarRuc(ApiRest mApiRest, string nroDocumento)
    {
      var result = await Task.Run(() =>
      {
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(mApiRest.apiDni + nroDocumento);
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Headers.Add("Authorization", "Bearer " + mApiRest.token);
        httpWebRequest.Method = "GET";

        // Recibir la respuesta de la consulta
        ApiPeruDevData_Ruc entidad;
        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
          entidad = JsonConvert.DeserializeObject<ApiPeruDevData_Ruc>(streamReader.ReadToEnd());
        }

        return entidad;
      });
      return result;
    }
  }

  // Validar CPE
  public class ApiPeruDev_ValidarCpe_HttpWebRequest
  {
    public static async Task<string> ValidarCpe(string ruc, string tipodoc, string serie, string correlativo, string fecha, decimal importe, ApiCpe mApiCpe)
    {
      var result = await Task.Run(() =>
      {
        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        HttpWebRequest httpWebRequest;
        httpWebRequest = (HttpWebRequest)WebRequest.Create(mApiCpe.apicpe); //"https://apiperu.dev/api/cpe"
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "POST";
        httpWebRequest.Headers.Add("Authorization", "Bearer " + mApiCpe.apitoken); // "1092f1368f048f2d248b9beb47950fe11cfc77f7c9dc5c1a854e3e930712bd2b"

        // Escribe el json a enviar
        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
          var product = new Consulta_CPE
          {
            ruc_emisor = ruc,
            codigo_tipo_documento = tipodoc,
            serie_documento = serie,
            numero_documento = correlativo,
            fecha_de_emision = fecha,
            total = importe
          };

          string json = JsonConvert.SerializeObject(product);
          streamWriter.Write(json);
        }

        // Recibir la respuesta de la consulta
        Respuesta_CPE entidad;
        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
          entidad = JsonConvert.DeserializeObject<Respuesta_CPE>(streamReader.ReadToEnd());
        }

        // Mostrar datos
        return entidad.data.comprobante_estado_descripcion;
      });

      return result;
    }
  }

  #endregion
}
