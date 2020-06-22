using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DevExpress.ExpressApp.EF.DesignTime;
namespace Bells6.Module.BusinessObjects
{
    public class Bells6ContextInitializer : DbContextTypesInfoInitializerBase {
        protected override DbContext CreateDbContext() {
            DbContextInfo contextInfo = new DbContextInfo(typeof(Bells6DbContext), new DbProviderInfo(providerInvariantName: "System.Data.SqlClient", providerManifestToken: "2008"));
            return contextInfo.CreateInstance();
        }
    }
}