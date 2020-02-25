using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string pattern;
        private ICacheManager cacheManager;

        public CacheRemoveAspect(string _pattern)
        {
            pattern = _pattern;
            cacheManager = ServiceTool.serviceProvider.GetService<ICacheManager>();
        }
        protected override void OnSuccess(IInvocation invocation)
        {
            cacheManager.RemoveByPattern(pattern);
        }
    }
}
