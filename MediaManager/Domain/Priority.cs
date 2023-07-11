namespace TallerProgramacion2020.MediaManager.Domain
{
    /// <summary>
    /// Enumeración que representa la prioridad que se 
    /// le puede asignar a una película o serie en la lista de seguimiento.
    /// </summary>
    public enum Priority : byte
    {
        Low = 1,
        Normal,
        High,
        Highest
    }
}
