using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RRHH911ECU.Models;

namespace RRHH911ECU.Controllers
{
    public class Tbl_PersonasController : Controller
    {
        private RRHHECU911Entities db = new RRHHECU911Entities();

        // GET: Tbl_Personas
        public ActionResult Index()
        {
            var tbl_Personas = db.Tbl_Personas.Include(t => t.Tbl_CargoInstitucional).Include(t => t.Tbl_CorreoIntitucional).Include(t => t.Tbl_DireccionInstitucional).Include(t => t.Tbl_EstrcuturaUno).Include(t => t.Tbl_EstructuraDos).Include(t => t.Tbl_EstructuraProgramatica).Include(t => t.Tbl_Grado).Include(t => t.Tbl_GrupoEtnico).Include(t => t.Tbl_GrupoOcupacional).Include(t => t.Tbl_Inicial).Include(t => t.Tbl_ModalidadLaboral).Include(t => t.Tbl_ProcesoInterno).Include(t => t.Tbl_Rmu).Include(t => t.Tbl_Sede).Include(t => t.Tbl_TelefonoIntitucional).Include(t => t.Tbl_Zona);
            return View(tbl_Personas.ToList());
        }

        // GET: Tbl_Personas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Personas tbl_Personas = db.Tbl_Personas.Find(id);
            if (tbl_Personas == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Personas);
        }

        // GET: Tbl_Personas/Create
        public ActionResult Create()
        {
            ViewBag.CargoInsti_id = new SelectList(db.Tbl_CargoInstitucional, "CargoIntsi_id", "CargoInsti_nom");
            ViewBag.CorreoInts_id = new SelectList(db.Tbl_CorreoIntitucional, "CorreoInts_id", "CorreoInts_nom");
            ViewBag.DirInsti_Id = new SelectList(db.Tbl_DireccionInstitucional, "DirInsti_Id", "DirInsti_nom");
            ViewBag.EstructuraUno_id = new SelectList(db.Tbl_EstrcuturaUno, "EstructuraUno_id", "EstructuraUno_nom");
            ViewBag.EstructuraDos_id = new SelectList(db.Tbl_EstructuraDos, "EstructuraDos_id", "EstructuraDos_nom");
            ViewBag.EstrucProgra_id = new SelectList(db.Tbl_EstructuraProgramatica, "EstrucProgra_id", "EstrucProgra_nom");
            ViewBag.Grado_id = new SelectList(db.Tbl_Grado, "Grado_id", "Grado_Per");
            ViewBag.GrupoEtni_id = new SelectList(db.Tbl_GrupoEtnico, "GrupoEtni_id", "GrupoEtni_nom");
            ViewBag.GrpOcupacional_id = new SelectList(db.Tbl_GrupoOcupacional, "GrpOcupacional_id", "GrpOcupacional_nom");
            ViewBag.inicial_id = new SelectList(db.Tbl_Inicial, "inicial_id", "inicial_NumArchivo");
            ViewBag.Per_modLaboral_id = new SelectList(db.Tbl_ModalidadLaboral, "Per_modLaboral_id", "Per_modLaboral_nombre");
            ViewBag.ProcesoInt_id = new SelectList(db.Tbl_ProcesoInterno, "ProcesoInt_id", "ProcesoInt_nombre");
            ViewBag.Rmu_id = new SelectList(db.Tbl_Rmu, "Rmu_id", "Rmu_estado");
            ViewBag.Sede_id = new SelectList(db.Tbl_Sede, "Sede_id", "Sede_nom");
            ViewBag.TelfInts_id = new SelectList(db.Tbl_TelefonoIntitucional, "TelfInts_id", "TelfInst_estado");
            ViewBag.Zona_id = new SelectList(db.Tbl_Zona, "Zona_id", "Zona_nom");
            return View();
        }

        // POST: Tbl_Personas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Per_id,Per_Cedula,Per_priNombre,Per_segNombre,Per_priApellido,Per_segApellido,Per_fechNacimiento,Zona_id,DirInsti_Id,Sede_id,ProcesoInt_id,EstrucProgra_id,Per_fechInicio,Per_fechDesde,Per_fechHasta,EstructuraUno_id,EstructuraDos_id,Rmu_id,Grado_id,GrpOcupacional_id,CargoInsti_id,GrupoEtni_id,Per_modLaboral_id,Per_numContrato,Per_partiGeneral,Per_partiIndividual,Per_genero,Per_discapacidad,Per_motivoSalida,CorreoInts_id,TelfInts_id,Per_numCelular,Per_dirDomicilio,Per_correoPersonal,Per_instrucFormal,Per_añosExperiencia,Per_comServicios,Per_oriDesComision,Per_fechComiDesde,Per_fechComiHasta,Per_nomPerContacEmergencia,Per_numPerContacEmergencia,Per_observaciones,inicial_id,Per_estado")] Tbl_Personas tbl_Personas)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Personas.Add(tbl_Personas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CargoInsti_id = new SelectList(db.Tbl_CargoInstitucional, "CargoIntsi_id", "CargoInsti_nom", tbl_Personas.CargoInsti_id);
            ViewBag.CorreoInts_id = new SelectList(db.Tbl_CorreoIntitucional, "CorreoInts_id", "CorreoInts_nom", tbl_Personas.CorreoInts_id);
            ViewBag.DirInsti_Id = new SelectList(db.Tbl_DireccionInstitucional, "DirInsti_Id", "DirInsti_nom", tbl_Personas.DirInsti_Id);
            ViewBag.EstructuraUno_id = new SelectList(db.Tbl_EstrcuturaUno, "EstructuraUno_id", "EstructuraUno_nom", tbl_Personas.EstructuraUno_id);
            ViewBag.EstructuraDos_id = new SelectList(db.Tbl_EstructuraDos, "EstructuraDos_id", "EstructuraDos_nom", tbl_Personas.EstructuraDos_id);
            ViewBag.EstrucProgra_id = new SelectList(db.Tbl_EstructuraProgramatica, "EstrucProgra_id", "EstrucProgra_nom", tbl_Personas.EstrucProgra_id);
            ViewBag.Grado_id = new SelectList(db.Tbl_Grado, "Grado_id", "Grado_Per", tbl_Personas.Grado_id);
            ViewBag.GrupoEtni_id = new SelectList(db.Tbl_GrupoEtnico, "GrupoEtni_id", "GrupoEtni_nom", tbl_Personas.GrupoEtni_id);
            ViewBag.GrpOcupacional_id = new SelectList(db.Tbl_GrupoOcupacional, "GrpOcupacional_id", "GrpOcupacional_nom", tbl_Personas.GrpOcupacional_id);
            ViewBag.inicial_id = new SelectList(db.Tbl_Inicial, "inicial_id", "inicial_NumArchivo", tbl_Personas.inicial_id);
            ViewBag.Per_modLaboral_id = new SelectList(db.Tbl_ModalidadLaboral, "Per_modLaboral_id", "Per_modLaboral_nombre", tbl_Personas.Per_modLaboral_id);
            ViewBag.ProcesoInt_id = new SelectList(db.Tbl_ProcesoInterno, "ProcesoInt_id", "ProcesoInt_nombre", tbl_Personas.ProcesoInt_id);
            ViewBag.Rmu_id = new SelectList(db.Tbl_Rmu, "Rmu_id", "Rmu_estado", tbl_Personas.Rmu_id);
            ViewBag.Sede_id = new SelectList(db.Tbl_Sede, "Sede_id", "Sede_nom", tbl_Personas.Sede_id);
            ViewBag.TelfInts_id = new SelectList(db.Tbl_TelefonoIntitucional, "TelfInts_id", "TelfInst_estado", tbl_Personas.TelfInts_id);
            ViewBag.Zona_id = new SelectList(db.Tbl_Zona, "Zona_id", "Zona_nom", tbl_Personas.Zona_id);
            return View(tbl_Personas);
        }

        // GET: Tbl_Personas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Personas tbl_Personas = db.Tbl_Personas.Find(id);
            if (tbl_Personas == null)
            {
                return HttpNotFound();
            }
            ViewBag.CargoInsti_id = new SelectList(db.Tbl_CargoInstitucional, "CargoIntsi_id", "CargoInsti_nom", tbl_Personas.CargoInsti_id);
            ViewBag.CorreoInts_id = new SelectList(db.Tbl_CorreoIntitucional, "CorreoInts_id", "CorreoInts_nom", tbl_Personas.CorreoInts_id);
            ViewBag.DirInsti_Id = new SelectList(db.Tbl_DireccionInstitucional, "DirInsti_Id", "DirInsti_nom", tbl_Personas.DirInsti_Id);
            ViewBag.EstructuraUno_id = new SelectList(db.Tbl_EstrcuturaUno, "EstructuraUno_id", "EstructuraUno_nom", tbl_Personas.EstructuraUno_id);
            ViewBag.EstructuraDos_id = new SelectList(db.Tbl_EstructuraDos, "EstructuraDos_id", "EstructuraDos_nom", tbl_Personas.EstructuraDos_id);
            ViewBag.EstrucProgra_id = new SelectList(db.Tbl_EstructuraProgramatica, "EstrucProgra_id", "EstrucProgra_nom", tbl_Personas.EstrucProgra_id);
            ViewBag.Grado_id = new SelectList(db.Tbl_Grado, "Grado_id", "Grado_Per", tbl_Personas.Grado_id);
            ViewBag.GrupoEtni_id = new SelectList(db.Tbl_GrupoEtnico, "GrupoEtni_id", "GrupoEtni_nom", tbl_Personas.GrupoEtni_id);
            ViewBag.GrpOcupacional_id = new SelectList(db.Tbl_GrupoOcupacional, "GrpOcupacional_id", "GrpOcupacional_nom", tbl_Personas.GrpOcupacional_id);
            ViewBag.inicial_id = new SelectList(db.Tbl_Inicial, "inicial_id", "inicial_NumArchivo", tbl_Personas.inicial_id);
            ViewBag.Per_modLaboral_id = new SelectList(db.Tbl_ModalidadLaboral, "Per_modLaboral_id", "Per_modLaboral_nombre", tbl_Personas.Per_modLaboral_id);
            ViewBag.ProcesoInt_id = new SelectList(db.Tbl_ProcesoInterno, "ProcesoInt_id", "ProcesoInt_nombre", tbl_Personas.ProcesoInt_id);
            ViewBag.Rmu_id = new SelectList(db.Tbl_Rmu, "Rmu_id", "Rmu_estado", tbl_Personas.Rmu_id);
            ViewBag.Sede_id = new SelectList(db.Tbl_Sede, "Sede_id", "Sede_nom", tbl_Personas.Sede_id);
            ViewBag.TelfInts_id = new SelectList(db.Tbl_TelefonoIntitucional, "TelfInts_id", "TelfInst_estado", tbl_Personas.TelfInts_id);
            ViewBag.Zona_id = new SelectList(db.Tbl_Zona, "Zona_id", "Zona_nom", tbl_Personas.Zona_id);
            return View(tbl_Personas);
        }

        // POST: Tbl_Personas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Per_id,Per_Cedula,Per_priNombre,Per_segNombre,Per_priApellido,Per_segApellido,Per_fechNacimiento,Zona_id,DirInsti_Id,Sede_id,ProcesoInt_id,EstrucProgra_id,Per_fechInicio,Per_fechDesde,Per_fechHasta,EstructuraUno_id,EstructuraDos_id,Rmu_id,Grado_id,GrpOcupacional_id,CargoInsti_id,GrupoEtni_id,Per_modLaboral_id,Per_numContrato,Per_partiGeneral,Per_partiIndividual,Per_genero,Per_discapacidad,Per_motivoSalida,CorreoInts_id,TelfInts_id,Per_numCelular,Per_dirDomicilio,Per_correoPersonal,Per_instrucFormal,Per_añosExperiencia,Per_comServicios,Per_oriDesComision,Per_fechComiDesde,Per_fechComiHasta,Per_nomPerContacEmergencia,Per_numPerContacEmergencia,Per_observaciones,inicial_id,Per_estado")] Tbl_Personas tbl_Personas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Personas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CargoInsti_id = new SelectList(db.Tbl_CargoInstitucional, "CargoIntsi_id", "CargoInsti_nom", tbl_Personas.CargoInsti_id);
            ViewBag.CorreoInts_id = new SelectList(db.Tbl_CorreoIntitucional, "CorreoInts_id", "CorreoInts_nom", tbl_Personas.CorreoInts_id);
            ViewBag.DirInsti_Id = new SelectList(db.Tbl_DireccionInstitucional, "DirInsti_Id", "DirInsti_nom", tbl_Personas.DirInsti_Id);
            ViewBag.EstructuraUno_id = new SelectList(db.Tbl_EstrcuturaUno, "EstructuraUno_id", "EstructuraUno_nom", tbl_Personas.EstructuraUno_id);
            ViewBag.EstructuraDos_id = new SelectList(db.Tbl_EstructuraDos, "EstructuraDos_id", "EstructuraDos_nom", tbl_Personas.EstructuraDos_id);
            ViewBag.EstrucProgra_id = new SelectList(db.Tbl_EstructuraProgramatica, "EstrucProgra_id", "EstrucProgra_nom", tbl_Personas.EstrucProgra_id);
            ViewBag.Grado_id = new SelectList(db.Tbl_Grado, "Grado_id", "Grado_Per", tbl_Personas.Grado_id);
            ViewBag.GrupoEtni_id = new SelectList(db.Tbl_GrupoEtnico, "GrupoEtni_id", "GrupoEtni_nom", tbl_Personas.GrupoEtni_id);
            ViewBag.GrpOcupacional_id = new SelectList(db.Tbl_GrupoOcupacional, "GrpOcupacional_id", "GrpOcupacional_nom", tbl_Personas.GrpOcupacional_id);
            ViewBag.inicial_id = new SelectList(db.Tbl_Inicial, "inicial_id", "inicial_NumArchivo", tbl_Personas.inicial_id);
            ViewBag.Per_modLaboral_id = new SelectList(db.Tbl_ModalidadLaboral, "Per_modLaboral_id", "Per_modLaboral_nombre", tbl_Personas.Per_modLaboral_id);
            ViewBag.ProcesoInt_id = new SelectList(db.Tbl_ProcesoInterno, "ProcesoInt_id", "ProcesoInt_nombre", tbl_Personas.ProcesoInt_id);
            ViewBag.Rmu_id = new SelectList(db.Tbl_Rmu, "Rmu_id", "Rmu_estado", tbl_Personas.Rmu_id);
            ViewBag.Sede_id = new SelectList(db.Tbl_Sede, "Sede_id", "Sede_nom", tbl_Personas.Sede_id);
            ViewBag.TelfInts_id = new SelectList(db.Tbl_TelefonoIntitucional, "TelfInts_id", "TelfInst_estado", tbl_Personas.TelfInts_id);
            ViewBag.Zona_id = new SelectList(db.Tbl_Zona, "Zona_id", "Zona_nom", tbl_Personas.Zona_id);
            return View(tbl_Personas);
        }

        // GET: Tbl_Personas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Personas tbl_Personas = db.Tbl_Personas.Find(id);
            if (tbl_Personas == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Personas);
        }

        // POST: Tbl_Personas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Personas tbl_Personas = db.Tbl_Personas.Find(id);
            db.Tbl_Personas.Remove(tbl_Personas);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
