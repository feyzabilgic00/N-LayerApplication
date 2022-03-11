namespace N_Layer.Core.Entities
{
    /* BaseEntity classından nesne örneği üretilmesini engellemek için abstract olarak tanımladık.*/
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
