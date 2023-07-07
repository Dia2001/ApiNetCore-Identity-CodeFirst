namespace ApiNetCore_Identity_CodeFirst.Repositories
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
