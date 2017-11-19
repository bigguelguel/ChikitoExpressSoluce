using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ChikitoExpressService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAdmService
    {
        #region"Post and Get"
        [OperationContract]
        void PostPais(Pais pais);
        [OperationContract]
        List<Cliente> GetCliente();
        [OperationContract]
        void PostClient(Cliente client);
        [OperationContract]
        void PostMunicipio(Municipio municipio);
        [OperationContract]
        void PosProvencia(Provencia provencia);
        [OperationContract]
        void PostZona(Zona zona);
        [OperationContract]
        void PostDireccion(Direccione direccion);
        [OperationContract]
        void PostPersona(Persona persona);
        [OperationContract]
        void PostRole(Role rol);
        [OperationContract]
        void PostUser(User user);
        [OperationContract]
        void PostUserRole(UsersRole userRol);
        [OperationContract]
        void PostAdministrador(Administradore adm);
        [OperationContract]
        ViewAdministradore GetViewAdm(int value);
        [OperationContract]
        List<Provencia> GetProvencias();

        [OperationContract]
        List<Pais> GetPaises();
        [OperationContract]
        List<Administradore> GetAdm();
        [OperationContract]
        List<Persona> GetPersonas();
        [OperationContract]
        List<User> GetUsers();
        [OperationContract]
        List<UsersRole> GetUsersRoles();
        [OperationContract]
        List<Role> GetRoles();
        [OperationContract]
        List<Zona> GetZonas();
        [OperationContract]
        List<Municipio> GetMunicipios();
        [OperationContract]
        List<Direccione> GetDirecciones();
        #endregion
        #region"Remove"
        [OperationContract]
        void RetirarPais(int idpais);

        #endregion
        #region"Update"
        [OperationContract]
        void ActualizarPais(int idPais, string Nombre, Boolean e);
        [OperationContract]
        void ActualizarCliente(Cliente cliente, int iduser);
        #endregion
    }
}