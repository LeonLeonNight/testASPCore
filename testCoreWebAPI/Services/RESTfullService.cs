using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testCoreWebAPI.Services
{
    public abstract class RESTfullService<T> where T : class 
    {
        public async Task<T> Get(int entityId)
        {
            var result = await GetImpl(entityId);
            return result;
        }

        public abstract Task<T> GetImpl(int entityId);

        public async Task<T> Post(T entity)
        {
            var result = await PostImpl(entity);
            return result;
        }

        public abstract Task<T> PostImpl(T entity);

        public async Task<T> Put(T entity)
        {
            var result = await PutImpl(entity);
            return result;
        }

        public abstract Task<T> PutImpl(T entity);

        public async Task<T> Delete(int entityId)
        {
            var result = await DeleteImpl(entityId);
            return result;
        }

        public abstract Task<T> DeleteImpl(int entityId);
    }
}
