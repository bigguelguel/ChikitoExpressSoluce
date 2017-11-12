using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ChikitoExpressService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdmService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AdmService.svc or AdmService.svc.cs at the Solution Explorer and start debugging.
    public class AdmService : IAdmService
    {
        #region"Attribute"
        ChikitoExpressContext context;
        public AdmService()
        {
            context = new ChikitoExpressContext();
            context.Configuration.ProxyCreationEnabled = false;
            
        }
        #endregion
        #region"Constructor"
        public ViewAdministradore GetViewAdm(int value)
        {
            
            return context.ViewAdministradores.Single(c => c.idAdm == value);
        }

        #endregion
        #region"Post"
        public void PosProvencia(Provencia provencia)
        {
            provencia.fechaCreacion = DateTime.Now;
            context.Provencias.Add(provencia);
            context.SaveChanges();
        }


        public void PostAdministrador(Administradore adm)
        {
            adm.FechaCreacion = DateTime.Now;
            context.Administradores.Add(adm);
            context.SaveChanges();
        }

        public void PostDireccion(Direccione direccion)
        {
            context.Direcciones.Add(direccion);
            context.SaveChanges();
        }

        public void PostMunicipio(Municipio municipio)
        {
            municipio.fechaCreacion = DateTime.Now;
            context.Municipios.Add(municipio);
            context.SaveChanges();
        }

        public void PostPais(Pais pais)
        {
            pais.fechaCreacion = DateTime.Now;
            context.Paises.Add(pais);
            context.SaveChanges();
        }

        public void PostPersona(Persona persona)
        {
            persona.fechaCreacion = DateTime.Now;
            context.Personas.Add(persona);
            context.SaveChanges();
        }

        public void PostRole(Role rol)
        {
            rol.FechaCreacion = DateTime.Now;
            context.Roles.Add(rol);
            context.SaveChanges();
        }

        public void PostUser(User user)
        {
            user.fechaCreacion = DateTime.Now;
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void PostUserRole(UsersRole userRol)
        {
            context.UsersRoles.Add(userRol);
            context.SaveChanges();
        }

        public void PostZona(Zona zona)
        {
            zona.fechaCreacion = DateTime.Now;
            context.Zonas.Add(zona);
            context.SaveChanges();
        }
        #endregion
        #region"Get"
        public List<Administradore> GetAdm(int value)
        {
            return context.Administradores.ToList();
        }
        public List<Pais> GetPaises()
        {   
            return context.Paises.ToList();
        }

        public List<Administradore> GetAdm()
        {
            return context.Administradores.ToList();
        }
        public List<Provencia> GetProvencias()
        {
            return context.Provencias.ToList();
        }
        public List<Persona> GetPersonas()
        {
            return context.Personas.ToList();
        }

        public List<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public List<UsersRole> GetUsersRoles()
        {
            return context.UsersRoles.ToList();
        }

        public List<Role> GetRoles()
        {
            return context.Roles.ToList();
        }

        public List<Zona> GetZonas()
        {
            return context.Zonas.ToList();
        }

        public List<Municipio> GetMunicipios()
        {
            return context.Municipios.ToList();
        }

        public List<Direccione> GetDirecciones()
        {
           return context.Direcciones.ToList();
        }
        #endregion
        #region"Remove"
        public void RetirarPais(int idpais)
        {
            var p = context.Paises.Find(idpais);
            context.Paises.Remove(p);
            context.SaveChanges();
        }
        #endregion
        #region"Update"
        public void ActualizarPais(int idPais, string Nombre, Boolean e)
        {
            var pais = context.Paises.Find(idPais);
            pais.estado = e;
            pais.nombre = Nombre;
            pais.fechaModicacion = DateTime.Now;
            context.SaveChanges();
        }
        #endregion
    }
}
