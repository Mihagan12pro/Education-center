namespace Auth.PostgreSQL.DataAccess;

public interface IMigrationBuilder
{
    Task MigrateAsync();
}