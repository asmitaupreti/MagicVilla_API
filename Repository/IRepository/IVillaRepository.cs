using System;
using System.Linq.Expressions;
using MagicVilla_API.Models;

namespace MagicVilla_API.Repository.IRepository
{
	public interface IVillaRepository :IRepository<Villa>
	{
        // The model mapping with auto mapper is handled in api controller, repository directly commmunicate with entities, thats why we are using Villa not VillaDTO here
		

        Task<Villa> UpdateAsync(Villa entity);

        
    }
}

