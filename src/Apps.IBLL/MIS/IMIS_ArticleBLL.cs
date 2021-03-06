﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2013-04-23 16:56:09 by App
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using Apps.Models;
using Apps.Common;
using Apps.Models.MIS;

namespace Apps.IBLL.MIS
{
    public partial interface IMIS_ArticleBLL
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="pager">JQgrid分页</param>
        /// <param name="queryStr">搜索条件</param>
        /// <returns>列表</returns>
        List<MIS_ArticleModel> GetList(ref GridPager pager, string queryStr,string cid,bool isManage,string userId,int check);
        List<MIS_ArticleModel> GetListByIsType(ref GridPager pager,int isType);
     
        /// <summary>
        /// 删除一个实体
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="id">id</param>
        /// <returns>是否成功</returns>
        bool Delete(ref ValidationErrors errors, string id,string userId);
       
        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="errors">持久的错误信息</param>
        /// <param name="id">主键</param>
        /// <param name="checkFlag">1审核0反审核</param>
        /// <param name="checker">审核人</param>
        /// <returns>是否成功</returns>
        bool Check(ref ValidationErrors errors, string id, int checkFlag, string checker);
        /// <summary>
        /// 判断一个实体是否存在
        /// </summary>
        
    }
}


