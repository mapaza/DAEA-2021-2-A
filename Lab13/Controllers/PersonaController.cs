using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab13.Models;

namespace Lab13.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listar()
        {
            List<Persona> personas = new List<Persona>();

            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Av. Evergen 123",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });

            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "María",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNac = Convert.ToDateTime("1995-10-28"),
                Email = "maria@mail.com"
            });

            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av. Los manzanos 3101",
                FechaNac = Convert.ToDateTime("1982-02-14"),
                Email = "carlos@mail.com"
            });

            return View(personas);
        }

        public ActionResult Mostrar(int id)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Av. Evergen 123",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });

            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "María",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNac = Convert.ToDateTime("1995-10-28"),
                Email = "maria@mail.com"
            });

            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av. Los manzanos 3101",
                FechaNac = Convert.ToDateTime("1982-02-14"),
                Email = "carlos@mail.com"
            });

            Persona persona = (from p in personas
                               where p.PersonaID == id
                               select p).FirstOrDefault();

            return View(persona);
        }    


        [HttpGet]
        public ActionResult Submit(string tipo, string dato)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "Av. Evergen 123",
                FechaNac = Convert.ToDateTime("1997-11-07"),
                Email = "juan@mail.com"
            });

            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "María",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNac = Convert.ToDateTime("1995-10-28"),
                Email = "maria@mail.com"
            });

            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av. Los manzanos 3101",
                FechaNac = Convert.ToDateTime("1982-02-14"),
                Email = "carlos@mail.com"
            });

            Persona persona = new Persona {};
            string estado;
           
            if (tipo.Equals("nombre")) {
                 persona = (from p in personas
                                   where p.Nombre == dato
                                   select p).FirstOrDefault();

                if(persona is null){
                    
                    estado = "no_encontrado";
                }
                else
                {
                    estado = "encontrado";
                    ViewBag.estado = estado;
                    ViewBag.id = persona.PersonaID;
                    ViewBag.nombre = persona.Nombre;
                    ViewBag.apellido = persona.Apellido;
                    ViewBag.fecha_nacimiento = persona.FechaNac;
                    ViewBag.direccion = persona.Direccion;
                    ViewBag.email = persona.Email;
                }
                
            }
            else if (tipo.Equals("apellido"))
            {
                persona = (from p in personas
                                   where p.Apellido == dato
                                   select p).FirstOrDefault();
                if (persona is null)
                {
                    estado = "no_encontrado";
                }
                else
                {
                    estado = "encontrado";
                    ViewBag.estado = estado;
                    ViewBag.id = persona.PersonaID;
                    ViewBag.nombre = persona.Nombre;
                    ViewBag.apellido = persona.Apellido;
                    ViewBag.fecha_nacimiento = persona.FechaNac;
                    ViewBag.direccion = persona.Direccion;
                    ViewBag.email = persona.Email;
                }
            }

            
            return View("Busqueda");
        }
    }
}
