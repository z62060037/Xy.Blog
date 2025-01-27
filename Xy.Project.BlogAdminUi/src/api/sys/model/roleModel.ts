import { BasicFetchResult } from '/@/api/model/baseModel'

export interface OutSysRolePageDto {
  id: number | string
  name: string
  code: string
  sort: number
  remark: string
  status: string
}

export type OutSysRolePage = BasicFetchResult<OutSysRolePageDto>
