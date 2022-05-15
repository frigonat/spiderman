
namespace SpiderMan
{
	/// <summary>
	/// Modela los estados que puede tener un Sistema IBM i.-
	/// </summary>
	public enum EstadosDeSistema : int 
	{
		/// <summary>
		/// Incidente Abierto
		/// </summary>
		Habilitado = 1,
		/// <summary>
		/// Incidente asignado a INFOR
		/// </summary>
		Deshabilitado = 2,

	}
}