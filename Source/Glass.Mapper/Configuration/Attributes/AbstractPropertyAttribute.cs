﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Glass.Mapper.Configuration.Attributes
{
    /// <summary>
    /// Abstract class for all property attributes
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public abstract class AbstractPropertyAttribute : Attribute, IPropertySetting
    {
        public virtual void Configure(PropertyInfo propertyInfo, AbstractPropertyConfiguration config)
        {
            config.PropertyInfo = propertyInfo;
        }

    }
}