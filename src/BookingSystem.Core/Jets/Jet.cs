using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace BookingSystem.Jets
{
	[Table("Jets")]
    public class Jet : FullAuditedEntity , IMustHaveTenant
    {
			public int TenantId { get; set; }
			

		[Required]
		public virtual string JetType { get; set; }
		
		public virtual int TotalCapacity { get; set; }
		
		public virtual bool IsActive { get; set; }
		

    }
}