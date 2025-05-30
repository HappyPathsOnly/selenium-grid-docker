﻿// <copyright file="EnumSchemaFilter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProductAPI
{
    using System;
    using System.Linq;
    using Microsoft.OpenApi.Any;
    using Microsoft.OpenApi.Models;
    using Swashbuckle.AspNetCore.SwaggerGen;

    public class EnumSchemaFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (!context.Type.IsSubclassOf(typeof(Enum)))
            {
                return;
            }

            var fields = context.Type.GetFields(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);

            schema.Enum = fields.Select(field => new OpenApiString(field.Name)).Cast<IOpenApiAny>().ToList();
            schema.Type = "string";
            schema.Properties = null;
            schema.AllOf = null;
        }
    }
}
