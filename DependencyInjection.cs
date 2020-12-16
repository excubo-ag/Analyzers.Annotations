using System;

namespace Excubo.Analyzers.DependencyInjection
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class ExposesAttribute : Attribute
    {
        public ExposesAttribute(Type type)
        {
        }
    }
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class AsAttribute : Attribute
    {
        public AsAttribute(Type @interface)
        {
        }
    }
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class IgnoreDependencyAttribute : Attribute
    {
        public IgnoreDependencyAttribute(params Type[] interfaces)
        {
        }
    }
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class DependencyInjectionPointAttribute : Attribute
    {
    }
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class InjectsAttribute : Attribute
    {
        public InjectsAttribute(params Type[] types)
        {
        }
    }
}