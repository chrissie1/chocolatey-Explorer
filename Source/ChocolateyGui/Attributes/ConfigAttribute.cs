﻿using System;

namespace ChocolateyGui.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class ConfigAttribute : Attribute
    {
    }
}