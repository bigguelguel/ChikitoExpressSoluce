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
        ChikitoExpressContext2 context;
        public AdmService()
        {
            context = new ChikitoExpressContext2();
            context.Configuration.ProxyCreationEnabled = false;
            
        }
        #endregion
        #region"Constructor"
    

        #endregion
        #region"Post"
        public void PostElementosDeMenu(ElementosDeMenu e)
        {
            context.ElementosDeMenus.Add(e);
            context.SaveChanges();
        }
        public void PostMenu(Menu m)
        {
            context.Menus.Add(m);
            context.SaveChanges();
        }
        public void PosProvencia(Provencia provencia)
        {
            provencia.fechaCreacion = DateTime.Now;
            context.Provencias.Add(provencia);
            context.SaveChanges();
        }

        public void PostClient(Cliente client)
        {
            context.Clientes.Add(client);
            context.SaveChanges();
        }
        public void PostAdministrador(Administradore adm)
        { 
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
        public List<ElementosDeMenu> GetElementosDeMenu()
        {
            return context.ElementosDeMenus.ToList();
        }
        public List<Menu> GetMenu()
        {
            return context.Menus.ToList();
        }
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
        public List<Cliente> GetCliente()
        {
            return context.Clientes.ToList();
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
        public void ActualizarCliente(Cliente cliente, int iduser)
        {
            context.Configuration.ProxyCreationEnabled = true;
            var zonas = context.Zonas.ToList();
            var client = context.Clientes.Find(iduser);
            client.puntoFidelizacion = cliente.puntoFidelizacion;
            client.estado = cliente.estado;
            client.Persona.Documento = cliente.Persona.Documento;
            client.Persona.email = cliente.Persona.email;
            client.Persona.estado = cliente.Persona.estado;
            client.Persona.telefono = cliente.Persona.telefono;
            client.Persona.primerNombre = cliente.Persona.primerNombre;
            client.Persona.segundoNombre = cliente.Persona.segundoNombre;
            client.Persona.primerApellido = cliente.Persona.primerApellido;
            client.Persona.segundoApellido = cliente.Persona.segundoApellido;
            client.Persona.nacionalidad = cliente.Persona.nacionalidad;
            client.Persona.fechaModicacion = DateTime.Now;
            client.Persona.Direccione.Zona = context.Zonas.Find(client.Persona.Direccione.idZona);
            client.Persona.Direccione.Apt = cliente.Persona.Direccione.Apt;
            client.Persona.Direccione.calle = cliente.Persona.Direccione.calle;
            client.Persona.Direccione.casa = cliente.Persona.Direccione.casa;
            client.Persona.Direccione.Edificio = cliente.Persona.Direccione.Edificio;
            client.Persona.Direccione.Zona.fechaModicacion = DateTime.Now;
            client.Persona.Direccione.idZona = cliente.Persona.Direccione.idZona;
            client.User.idUserName = cliente.User.idUserName;
            client.User.password = cliente.User.password;
            context.SaveChanges();
            context.Configuration.ProxyCreationEnabled = false;
        }

        public List<TiposPlato> GetTipoPlatos()
        {
            return context.TiposPlatos.ToList();
        }

        public void PostTipoPlatos(TiposPlato tipoPlato)
        {
            context.TiposPlatos.Add(tipoPlato);
            context.SaveChanges();
        }

        public List<TiposBebida> GetTipoBebidas()
        {
            return context.TiposBebidas.ToList();
        }

        public void PostTipoBebidas(TiposBebida tipoBebida)
        {
            context.TiposBebidas.Add(tipoBebida);
            context.SaveChanges();
        }

        public List<Plato> GetPlato()
        {
            return context.Platos.ToList();
        }

        public void PostPlatos(Plato plato)
        {
            context.Platos.Add(plato);
            context.SaveChanges();
        }

        public List<Bebida> GetBebida()
        {
            return context.Bebidas.ToList();
        }

        public void PostBebida(Bebida bebida)
        {
            context.Bebidas.Add(bebida);
            context.SaveChanges();
        }
        public void ActualizarBebida(int id, Bebida bebida, int idMenu)
        {
            var beb = context.Bebidas.Find(id);
            beb.Nombre = bebida.Nombre;
            beb.precio = bebida.precio;
            beb.idTipoBebida = bebida.idTipoBebida;
            beb.ElementosDeMenus = bebida.ElementosDeMenus;
            beb.descripcion = bebida.descripcion;
            beb.estado = bebida.estado;
            beb.imagen = bebida.imagen;
            var elemento = context.ElementosDeMenus.Single(c=> c.idBebida == id);
            elemento.idMenu = idMenu;
            context.SaveChanges();
        }
        public void ActualizarPlato(int id, Plato plat)
        {
            var beb = context.Platos.Find(id);
            beb.nombre = plat.nombre;
            beb.precio = plat.precio;
            beb.idTipoPlato = plat.idTipoPlato;
            beb.descripcion = plat.descripcion;
            beb.estado = plat.estado;
            beb.imagen = plat.imagen;
            context.SaveChanges();
        }
        #endregion
    }
}
