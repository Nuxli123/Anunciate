using anunciate.Domain;
using anunciate.DAL.Implementation;
namespace anunciate.Business
{
	/// <summary>
	/// Autor: anunciate
	/// Comentarios: Clase de negocio que hereda del CRUD
	/// </summary>
	public class RolesBo : Base.CrudBase<Roles, RolesDaoImpl>
	{
	}
}
