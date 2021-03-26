using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ODataHelper.AspNetCore.Abstractions
{
    public abstract class BaseODataHelperController<TEntity> : ODataController, IODataHelperController<TEntity>
        where TEntity : class
    {
        public abstract ValueTask<IActionResult> Get(ODataQueryOptions<TEntity> options);
        public abstract ValueTask<IActionResult> Get([FromODataUri] object key, ODataQueryOptions<TEntity> options);
        public abstract ValueTask<IActionResult> Post([FromBody] TEntity postEntity);
        public abstract ValueTask<IActionResult> Delete([FromODataUri] object key);
        [AcceptVerbs("PATCH", "MERGE")]
        public abstract ValueTask<IActionResult> Patch([FromODataUri] object key, Delta<TEntity> delta);
        public abstract ValueTask<IActionResult> Put([FromODataUri] object key, TEntity putEntity);
    }
}
