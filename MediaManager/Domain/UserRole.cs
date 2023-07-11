namespace TallerProgramacion2020.MediaManager.Domain
{
    /// <summary>
    /// Enumerado que representa los roles de usuario.
    /// </summary>
    public enum UserRole : byte
    {
        /// <summary>
        /// Rol de usuario regular.
        /// </summary>
        User = 0,
        /// <summary>
        /// Rol de administrador.
        /// </summary>
        Admin
    }
}
