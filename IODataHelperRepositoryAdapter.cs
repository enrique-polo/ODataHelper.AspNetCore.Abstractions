using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using System.Linq;
using System.Threading.Tasks;

namespace ODataHelper.AspNetCore.Abstractions
{
    public interface IODataHelperRepositoryAdapter<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> AsQueryable();
        ValueTask<IQueryable> GetAsync(ODataQueryOptions<TEntity> options, 
            ODataQuerySettings querySettings,
            AllowedQueryOptions ignoreQueryOptions);
        ValueTask<TEntity> GetAsync(object key, ODataQueryOptions<TEntity> options, 
            ODataQuerySettings querySettings,
            AllowedQueryOptions ignoreQueryOptions);
        ValueTask<TEntity> InsertAsync(TEntity entity);
        ValueTask<TEntity> PatchAsync(TEntity entity, Delta<TEntity> delta);
        ValueTask<TEntity> PutAsync(TEntity entity);
        ValueTask<int> RemoveAsync(TEntity entity);
        ValueTask<int> PersistChangesAsync();
    }
}