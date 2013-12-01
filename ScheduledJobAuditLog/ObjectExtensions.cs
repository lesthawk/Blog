﻿using System;
using System.ComponentModel;

namespace EPiServer.CodeSample.ScheduledJobAuditLog
{
    public static class ObjectExtensions
    {
        public static string ToDescriptionString(this Object obj)
        {
            var attributes = (DescriptionAttribute[])obj.GetType().GetField(obj.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
