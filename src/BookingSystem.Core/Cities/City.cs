using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace BookingSystem.Cities
{
	[Table("Cities")]
    public class City : FullAuditedEntity , IMustHaveTenant
    {
			public int TenantId { get; set; }
			

		[Required]
		public virtual string Code { get; set; }
		
		[Required]
		public virtual string Name { get; set; }
		
		public virtual string DisplayName { get; set; }
		
		public virtual string Country { get; set; }
		

    }
}