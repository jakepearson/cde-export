﻿using System;
using System.Threading;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace cde_web.Filters
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public sealed class InitializeSimpleMembershipAttribute : ActionFilterAttribute
	{
		private static object _initializerLock = new object();

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
		}

	}
}
