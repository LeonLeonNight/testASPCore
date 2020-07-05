using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testCoreWebAPI.Services;

namespace testCoreWebAPI.Controllers.Base
{
    public abstract class RESTfullController<T, RESTfullService> : ControllerBase 
        where T : class
        where RESTfullService : RESTfullService<T>, new()
    {
        protected RESTfullService service = new RESTfullService();

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<T>> Get(int entityId)
        {
            var result = await service.Get(entityId);
            if(result == null)
            {
                return NotFound();
            }
            return new ObjectResult(result);
        }

        // POST api/users
        [HttpPost]
        public async Task<ActionResult<T>> Post(T entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }
            await service.Post(entity);
            return Ok(entity);
        }


        // PUT api/users/
        [HttpPut]
        public async Task<ActionResult<T>> Put(T entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }
            var result = await service.Put(entity);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<T>> Delete(int entityId)
        {
            var result = await service.Delete(entityId);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
