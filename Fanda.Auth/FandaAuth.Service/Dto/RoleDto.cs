using Fanda.Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FandaAuth.Service.Dto
{
    public class RoleDto : BaseDto
    {
        [Required]
        public Guid TenantId { get; set; }

        public ICollection<RolePrivilegeDto> Privileges { get; set; }
    }

    public class RoleListDto : BaseListDto
    {
    }

    public class RoleChildrenDto
    {
        public ICollection<RolePrivilegeDto> Privileges { get; set; }
    }
}
