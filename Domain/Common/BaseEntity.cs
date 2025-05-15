namespace Domain.Common
{
    public class BaseEntity<T>
    {
        public T Id { get; protected set; } = default!;
        public DateTime CreatedAt { get; protected set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; protected set; }
        public bool IsDeleted { get; protected set; } = false;

        public void MarkAsUpdated()
        {
            UpdatedAt = DateTime.UtcNow;
        }
        public void SoftDeleted()
        {
            IsDeleted = true;
            MarkAsUpdated();
        }
    }
}
