using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
namespace Core.Aspects.Autofac.Perfonmance
{
    public class PerfonmanceAspect : MethodInterception
    {
        private int interval;
        private Stopwatch stopwatch;

        public PerfonmanceAspect(int _interval)
        {
            interval = _interval;
            stopwatch = ServiceTool.serviceProvider.GetService<Stopwatch>();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            stopwatch.Start();
        }

        protected override void OnAfter(IInvocation invocation)
        {
            if(stopwatch.Elapsed.TotalSeconds>interval)
            {
                Debug.WriteLine($"Perfonmance:{invocation.Method.DeclaringType.FullName}.{invocation.Method.Name}--->{stopwatch.Elapsed.TotalSeconds}");//Mail atılabilir//

            }
            stopwatch.Reset();
        }
    }
}
