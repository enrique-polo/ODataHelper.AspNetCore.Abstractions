using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ODataHelper.AspNetCore.Abstractions
{
    public interface IODataHelperController<TEntity>
        where TEntity : class
    {
        ValueTask<IActionResult> Get(ODataQueryOptions<TEntity> options);
        ValueTask<IActionResult> Get([FromODataUri] object key, ODataQueryOptions<TEntity> options);
        ValueTask<IActionResult> Post([FromBody]TEntity postEntity);
        ValueTask<IActionResult> Delete([FromODataUri] object key);
        ValueTask<IActionResult> Patch([FromODataUri] object key, Delta<TEntity> delta);
        ValueTask<IActionResult> Put([FromODataUri] object key, TEntity putEntity);
    }
}
