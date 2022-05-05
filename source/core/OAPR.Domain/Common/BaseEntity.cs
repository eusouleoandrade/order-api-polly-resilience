namespace OAPR.Domain.Common
{
    public abstract class BaseEntity<TId> where TId : struct
    {
        public TId Id { get; set; }
    }
}