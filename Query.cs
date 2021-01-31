using GraphQl.Data;
using GraphQl.Entities;
using System.Linq;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;

namespace GraphQl
{
    public class Query
    {
        [UseDbContext(typeof(Digitallabs_CI_DEVELOPContext))]
        [UseFiltering]
        [UseSorting]
        [UseProjection]
        public IQueryable<AmsRelColheitas> GetReports([ScopedService] Digitallabs_CI_DEVELOPContext context) =>
            context.AmsRelColheitas;
    }
}
