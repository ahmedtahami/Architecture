namespace Architecture.Database;

public sealed class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable(nameof(Customer), nameof(Customer));

        builder.HasKey(entity => entity.Id);

        builder.Property(entity => entity.Id).ValueGeneratedOnAdd().IsRequired();

        builder.Property(entity => entity.Name).HasMaxLength(250).IsRequired();
    }
}
