﻿using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace API;

public static class IdentityServiceExtension
{
    public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
    { 
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(
            Options=> {
                Options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TokenKey"])),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            }
        );

        return services;
    }
}

