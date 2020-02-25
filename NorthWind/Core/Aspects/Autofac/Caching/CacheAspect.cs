using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        private int duration;
        private ICacheManager cacheManager;

        public CacheAspect(int _duration = 60)
        {
            duration = _duration;
            cacheManager = ServiceTool.serviceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation)
        {
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");
            var arguments = invocation.Arguments.ToList();
            var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})";

            if (cacheManager.IsAdd(key))
            {
                invocation.ReturnValue = cacheManager.Get(key);
                return;
            }

            invocation.Proceed();
            cacheManager.Add(key, invocation.ReturnValue, duration);
        }
    }
}
