﻿using Microsoft.AspNetCore.Authorization;
using Xy.Project.Application.Dtos.Sys.SysRoleManage;
using Xy.Project.Application.Services.Contracts.Sys;
using Xy.Project.Core.Filter;
using Xy.Project.Platform.Model.Entities.Sys;

namespace Xy.Project.Platform.Modular.Sys;

/// <summary>
/// 角色控制器
/// </summary>
public class SysRoleController :  ApiControllerBase<ISysRoleService, SysRole, AddSysRoleDto, EditSysRoleDto, OutSysRolePageDto>
{
    private readonly ISysRoleService _sysRoleService;
    public SysRoleController(ISysRoleService sysRoleService):base(sysRoleService)
    {
        _sysRoleService = sysRoleService;
    }

}
