//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using Apps.Models;
using System;
using System.ComponentModel.DataAnnotations;
namespace Apps.Models.Sys
{

	public partial class SysImportExcelLogModel:Virtual_SysImportExcelLogModel
	{
		
	}
	public class Virtual_SysImportExcelLogModel
	{
		[Display(Name = "ID")]
		public virtual int Id { get; set; }
		[Display(Name = "导入时间")]
		public virtual System.DateTime ImportTime { get; set; }
		[Display(Name = "导入的表名")]
		public virtual string ImportTable { get; set; }
		[Display(Name = "导入的文件名")]
		public virtual string ImportFileName { get; set; }
		[Display(Name = "导入的文件Url")]
		public virtual string ImportFilePathUrl { get; set; }
		[Display(Name = "导入状态")]
		public virtual string ImportStatus { get; set; }
		[Display(Name = "导入用户")]
		public virtual string CreateBy { get; set; }
		}
}
