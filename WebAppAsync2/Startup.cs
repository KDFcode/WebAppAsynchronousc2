﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAsync2.Startup))]
namespace WebAppAsync2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
