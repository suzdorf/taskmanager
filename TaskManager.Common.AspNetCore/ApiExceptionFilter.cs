﻿using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using TaskManager.Common.Resources;
using TaskManager.Core.Exceptions;

namespace TaskManager.Common.AspNetCore
{
    public class ApiExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var status = HttpStatusCode.InternalServerError;
            var message = ErrorMessages.Unknown; 

            var exceptionType = context.Exception.GetType();

            if (exceptionType == typeof(TaskManagerException))
            {
                message = context.Exception.Message;
                status = HttpStatusCode.BadRequest;
            }

            context.ExceptionHandled = true;

            HttpResponse response = context.HttpContext.Response;
            response.StatusCode = (int)status;
            response.ContentType = "application/json";
            var err = JsonConvert.SerializeObject(new BadRequestResponseContent {Message = message});
            response.WriteAsync(err);
        }
    }
}