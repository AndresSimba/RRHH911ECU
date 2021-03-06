//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RRHH911ECU.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Personas
    {
        public int Per_id { get; set; }
        public Nullable<int> Per_Cedula { get; set; }
        public string Per_priNombre { get; set; }
        public string Per_segNombre { get; set; }
        public string Per_priApellido { get; set; }
        public string Per_segApellido { get; set; }
        public Nullable<System.DateTime> Per_fechNacimiento { get; set; }
        public Nullable<int> Zona_id { get; set; }
        public Nullable<int> DirInsti_Id { get; set; }
        public Nullable<int> Sede_id { get; set; }
        public Nullable<int> ProcesoInt_id { get; set; }
        public Nullable<int> EstrucProgra_id { get; set; }
        public Nullable<System.DateTime> Per_fechInicio { get; set; }
        public Nullable<System.DateTime> Per_fechDesde { get; set; }
        public Nullable<System.DateTime> Per_fechHasta { get; set; }
        public Nullable<int> EstructuraUno_id { get; set; }
        public Nullable<int> EstructuraDos_id { get; set; }
        public Nullable<int> Rmu_id { get; set; }
        public Nullable<int> Grado_id { get; set; }
        public Nullable<int> GrpOcupacional_id { get; set; }
        public Nullable<int> CargoInsti_id { get; set; }
        public Nullable<int> GrupoEtni_id { get; set; }
        public Nullable<int> Per_modLaboral_id { get; set; }
        public string Per_numContrato { get; set; }
        public Nullable<int> Per_partiGeneral { get; set; }
        public Nullable<int> Per_partiIndividual { get; set; }
        public string Per_genero { get; set; }
        public string Per_discapacidad { get; set; }
        public string Per_motivoSalida { get; set; }
        public Nullable<int> CorreoInts_id { get; set; }
        public Nullable<int> TelfInts_id { get; set; }
        public Nullable<int> Per_numCelular { get; set; }
        public string Per_dirDomicilio { get; set; }
        public string Per_correoPersonal { get; set; }
        public string Per_instrucFormal { get; set; }
        public Nullable<System.DateTime> Per_añosExperiencia { get; set; }
        public string Per_comServicios { get; set; }
        public string Per_oriDesComision { get; set; }
        public Nullable<System.DateTime> Per_fechComiDesde { get; set; }
        public Nullable<System.DateTime> Per_fechComiHasta { get; set; }
        public string Per_nomPerContacEmergencia { get; set; }
        public string Per_numPerContacEmergencia { get; set; }
        public string Per_observaciones { get; set; }
        public Nullable<int> inicial_id { get; set; }
        public string Per_estado { get; set; }
    
        public virtual Tbl_CargoInstitucional Tbl_CargoInstitucional { get; set; }
        public virtual Tbl_CorreoIntitucional Tbl_CorreoIntitucional { get; set; }
        public virtual Tbl_DireccionInstitucional Tbl_DireccionInstitucional { get; set; }
        public virtual Tbl_EstrcuturaUno Tbl_EstrcuturaUno { get; set; }
        public virtual Tbl_EstructuraDos Tbl_EstructuraDos { get; set; }
        public virtual Tbl_EstructuraProgramatica Tbl_EstructuraProgramatica { get; set; }
        public virtual Tbl_Grado Tbl_Grado { get; set; }
        public virtual Tbl_GrupoEtnico Tbl_GrupoEtnico { get; set; }
        public virtual Tbl_GrupoOcupacional Tbl_GrupoOcupacional { get; set; }
        public virtual Tbl_Inicial Tbl_Inicial { get; set; }
        public virtual Tbl_ModalidadLaboral Tbl_ModalidadLaboral { get; set; }
        public virtual Tbl_ProcesoInterno Tbl_ProcesoInterno { get; set; }
        public virtual Tbl_Rmu Tbl_Rmu { get; set; }
        public virtual Tbl_Sede Tbl_Sede { get; set; }
        public virtual Tbl_TelefonoIntitucional Tbl_TelefonoIntitucional { get; set; }
        public virtual Tbl_Zona Tbl_Zona { get; set; }
    }
}
