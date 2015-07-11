using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5.Models
{   
	public  class OrderLineRepository : EFRepository<OrderLine>, IOrderLineRepository
	{

	}

	public  interface IOrderLineRepository : IRepository<OrderLine>
	{

	}
}