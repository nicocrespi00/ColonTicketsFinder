namespace ColonWorker
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Welcome
    {
        [JsonProperty("nCode")]
        public long NCode { get; set; }

        [JsonProperty("oData")]
        public OData OData { get; set; }
    }

    public partial class OData
    {
        [JsonProperty("oEspectaculoCartel")]
        public OEspectaculoCartel OEspectaculoCartel { get; set; }
    }

    public partial class OEspectaculoCartel
    {
        [JsonProperty("idEspectaculoCartel")]
        public long IdEspectaculoCartel { get; set; }

        [JsonProperty("idEspectaculoCartelTipo")]
        public long IdEspectaculoCartelTipo { get; set; }

        [JsonProperty("idEspectaculoCartelSubtipo")]
        public long IdEspectaculoCartelSubtipo { get; set; }

        [JsonProperty("idEspectaculoCartelLinkDestino")]
        public long IdEspectaculoCartelLinkDestino { get; set; }

        [JsonProperty("idEspectaculoTipo")]
        public long IdEspectaculoTipo { get; set; }

        [JsonProperty("cNombre")]
        public string CNombre { get; set; }

        [JsonProperty("cDescripcion")]
        public string CDescripcion { get; set; }

        [JsonProperty("cDescripcion_l172")]
        public string CDescripcionL172 { get; set; }

        [JsonProperty("listaImagenes")]
        public ListaImagene[] ListaImagenes { get; set; }

        [JsonProperty("listaEtiquetas")]
        public object[] ListaEtiquetas { get; set; }

        [JsonProperty("listaEstablecimiento")]
        public ListaEstablecimiento[] ListaEstablecimiento { get; set; }

        [JsonProperty("cWebUri")]
        public string CWebUri { get; set; }

        [JsonProperty("cSeo")]
        public string CSeo { get; set; }

        [JsonProperty("cHtmlScript")]
        public string CHtmlScript { get; set; }

        [JsonProperty("cInformacionLegal")]
        public string CInformacionLegal { get; set; }

        [JsonProperty("cInformacionFinanciera")]
        public string CInformacionFinanciera { get; set; }

        [JsonProperty("cInformacionImportante")]
        public string CInformacionImportante { get; set; }

        [JsonProperty("listaPromocion")]
        public ListaPromocion[] ListaPromocion { get; set; }
    }

    public partial class ListaEstablecimiento
    {
        [JsonProperty("idEspectaculo")]
        public long IdEspectaculo { get; set; }

        [JsonProperty("idEspectaculoTipoListaFuncion")]
        public long IdEspectaculoTipoListaFuncion { get; set; }

        [JsonProperty("idEstablecimiento")]
        public long IdEstablecimiento { get; set; }

        [JsonProperty("idPais")]
        public long IdPais { get; set; }

        [JsonProperty("idProvincia")]
        public long IdProvincia { get; set; }

        [JsonProperty("idPartido")]
        public long IdPartido { get; set; }

        [JsonProperty("idLocalidad")]
        public long IdLocalidad { get; set; }

        [JsonProperty("idZonaGeografica")]
        public long IdZonaGeografica { get; set; }

        [JsonProperty("cNombre")]
        public string CNombre { get; set; }

        [JsonProperty("cSeo")]
        public string CSeo { get; set; }

        [JsonProperty("cDescripcion")]
        public string CDescripcion { get; set; }

        [JsonProperty("cDomicilio")]
        public string CDomicilio { get; set; }

        [JsonProperty("cTelefono")]
        public string CTelefono { get; set; }

        [JsonProperty("cGoogleMapTag")]
        public string CGoogleMapTag { get; set; }

        [JsonProperty("listaImagenes")]
        public ListaImagene[] ListaImagenes { get; set; }

        [JsonProperty("listaFuncion")]
        public ListaFuncion[] ListaFuncion { get; set; }

        [JsonProperty("fPrecioDesde")]
        public long FPrecioDesde { get; set; }

        [JsonProperty("fPrecioHasta")]
        public long FPrecioHasta { get; set; }

        [JsonProperty("cZona")]
        public string CZona { get; set; }
    }

    public partial class ListaFuncion
    {
        [JsonProperty("idFuncion")]
        public long IdFuncion { get; set; }

        [JsonProperty("cHashValidacion")]
        public string CHashValidacion { get; set; }

        [JsonProperty("cEtiqueta")]
        public string CEtiqueta { get; set; }

        [JsonProperty("cLeyenda")]
        public string CLeyenda { get; set; }

        [JsonProperty("cIdioma")]
        public string CIdioma { get; set; }

        [JsonProperty("cTipoProducto")]
        public string CTipoProducto { get; set; }

        [JsonProperty("bIncluyeHora")]
        public bool BIncluyeHora { get; set; }

        [JsonProperty("listaImagenes")]
        public object ListaImagenes { get; set; }

        [JsonProperty("oFecha")]
        public OFecha OFecha { get; set; }

        [JsonProperty("bActivaParaLaVenta")]
        public bool BActivaParaLaVenta { get; set; }

        [JsonProperty("dFuncion")]
        public DateTimeOffset DFuncion { get; set; }

        [JsonProperty("idFuncionTipo")]
        public long IdFuncionTipo { get; set; }

        [JsonProperty("nPosicionesDisponibles")]
        public long NPosicionesDisponibles { get; set; }

        [JsonProperty("Sectores")]
        public Sectore[] Sectores { get; set; }
    }

    public partial class OFecha
    {
        [JsonProperty("nAnio")]
        public long NAnio { get; set; }

        [JsonProperty("nMes")]
        public long NMes { get; set; }

        [JsonProperty("nDia")]
        public long NDia { get; set; }

        [JsonProperty("nDiaSemana")]
        public long NDiaSemana { get; set; }

        [JsonProperty("nHora")]
        public long NHora { get; set; }

        [JsonProperty("nMinutos")]
        public long NMinutos { get; set; }
    }

    public partial class Sectore
    {
        [JsonProperty("Tipo")]
        public Tipo Tipo { get; set; }

        [JsonProperty("EtiquetaRegla")]
        public object EtiquetaRegla { get; set; }

        [JsonProperty("idSector")]
        public string IdSector { get; set; }

        [JsonProperty("cSectorColor")]
        public string CSectorColor { get; set; }

        [JsonProperty("nSectorOrden")]
        public long NSectorOrden { get; set; }

        [JsonProperty("CantidadDisponible")]
        public long CantidadDisponible { get; set; }

        [JsonProperty("Cantidad")]
        public long Cantidad { get; set; }

        [JsonProperty("Precio")]
        public long Precio { get; set; }

        [JsonProperty("SeleccionMaxima")]
        public long SeleccionMaxima { get; set; }

        [JsonProperty("Provider")]
        public string Provider { get; set; }
    }

    public partial class ListaImagene
    {
        [JsonProperty("cUri")]
        public string CUri { get; set; }

        [JsonProperty("listaEtiquetas")]
        public string[] ListaEtiquetas { get; set; }
    }

    public partial class ListaPromocion
    {
        [JsonProperty("idPromocion")]
        public long IdPromocion { get; set; }

        [JsonProperty("cNombre")]
        public string CNombre { get; set; }

        [JsonProperty("idPromocionTipoValidacion")]
        public long IdPromocionTipoValidacion { get; set; }

        [JsonProperty("cImagenUri")]
        public string CImagenUri { get; set; }

        [JsonProperty("cUrlReferencia")]
        public string CUrlReferencia { get; set; }

        [JsonProperty("listaAtributo")]
        public object ListaAtributo { get; set; }

        [JsonProperty("listaIdEtiqueta")]
        public object ListaIdEtiqueta { get; set; }

        [JsonProperty("listaImagen")]
        public object ListaImagen { get; set; }
    }

    public enum Tipo { G, N };

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, ColonWorker.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, ColonWorker.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TipoConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TipoConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Tipo) || t == typeof(Tipo?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "G":
                    return Tipo.G;
                case "N":
                    return Tipo.N;
            }
            throw new Exception("Cannot unmarshal type Tipo");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Tipo)untypedValue;
            switch (value)
            {
                case Tipo.G:
                    serializer.Serialize(writer, "G");
                    return;
                case Tipo.N:
                    serializer.Serialize(writer, "N");
                    return;
            }
            throw new Exception("Cannot marshal type Tipo");
        }

        public static readonly TipoConverter Singleton = new TipoConverter();
    }
}
