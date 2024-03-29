﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// using System.Web.Http.Filters;

namespace OdeToFood.Filters {
  public class LogAttribute : ActionFilterAttribute {

    public override void OnActionExecuting(ActionExecutingContext filterContext) {
      base.OnActionExecuting(filterContext);
    }

    public override void OnActionExecuted(ActionExecutedContext filterContext) {
      base.OnActionExecuted(filterContext);
    }

    public override void OnResultExecuted(ResultExecutedContext filterContext) {
      base.OnResultExecuted(filterContext);
    }

    public override void OnResultExecuting(ResultExecutingContext filterContext) {
      base.OnResultExecuting(filterContext);
    }
  }
}