﻿/**  版本信息模板在安装目录下，可自行修改。
* vw_SYS_Account.cs
*
* 功 能： N/A
* 类 名： vw_SYS_Account
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/3/4 19:47:37   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Demo.Model
{
	/// <summary>
	/// vw_SYS_Account:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class vw_SYS_Account
	{
		public vw_SYS_Account()
		{}
		#region Model
		private string _id;
		private string _accountname;
		private string _password;
		private string _accounttype;
		private string _roleid;
		private string _rolename;
		private string _state;
		private string _defaulturl;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AccountName
		{
			set{ _accountname=value;}
			get{return _accountname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AccountType
		{
			set{ _accounttype=value;}
			get{return _accounttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DefaultUrl
		{
			set{ _defaulturl=value;}
			get{return _defaulturl;}
		}
		#endregion Model

	}
}

