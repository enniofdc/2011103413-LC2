﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using _2011103413_ENT;
using _2011103413_PER;

namespace _2011103413_API.Controllers
{
    public class PropietariosController : ApiController
    {
        private EnsambladoraDbContext db = new EnsambladoraDbContext();

        // GET: api/Propietarios
        public IQueryable<Propietario> GetPropietarios()
        {
            return db.Propietarios;
        }

        // GET: api/Propietarios/5
        [ResponseType(typeof(Propietario))]
        public IHttpActionResult GetPropietario(int id)
        {
            Propietario propietario = db.Propietarios.Find(id);
            if (propietario == null)
            {
                return NotFound();
            }

            return Ok(propietario);
        }

        // PUT: api/Propietarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPropietario(int id, Propietario propietario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != propietario.PropietarioId)
            {
                return BadRequest();
            }

            db.Entry(propietario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropietarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Propietarios
        [ResponseType(typeof(Propietario))]
        public IHttpActionResult PostPropietario(Propietario propietario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Propietarios.Add(propietario);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = propietario.PropietarioId }, propietario);
        }

        // DELETE: api/Propietarios/5
        [ResponseType(typeof(Propietario))]
        public IHttpActionResult DeletePropietario(int id)
        {
            Propietario propietario = db.Propietarios.Find(id);
            if (propietario == null)
            {
                return NotFound();
            }

            db.Propietarios.Remove(propietario);
            db.SaveChanges();

            return Ok(propietario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PropietarioExists(int id)
        {
            return db.Propietarios.Count(e => e.PropietarioId == id) > 0;
        }
    }
}