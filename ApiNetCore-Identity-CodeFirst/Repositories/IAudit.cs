namespace ApiNetCore_Identity_CodeFirst.Repositories
{
    public interface IAudit
    {
        DateTime? CreatedAt { get; set; }
        string? CreatedBy { get; set; }
        DateTime? UpdatedAt { get; set; }
        string? UpdatedBy { get; set; }
    }
}
