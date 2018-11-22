﻿using Microsoft.Extensions.Options;
using TaskManager.Common.AspNetCore.AppSettings;

namespace TaskManager.MessagingService.AppSettings
{
    public class AppSettings : AppSettingsBase
    {
        public AppSettings(IOptions<AppSettingsModel> options) : base(options)
        {
        }
    }
}