﻿using System;
using System.Windows;
using Xunit;
using Prism.IocContainer.Wpf.Tests.Support;
using Prism.Logging;

namespace Prism.Autofac.Wpf.Tests
{
    
    public class AutofacBootstrapperNullLoggerFixture : BootstrapperFixtureBase
    {
        [Fact]
        public void NullLoggerThrows()
        {
            var bootstrapper = new NullLoggerBootstrapper();

            AssertExceptionThrownOnRun(bootstrapper, typeof(InvalidOperationException), "ILoggerFacade");
        }

        internal class NullLoggerBootstrapper : AutofacBootstrapper
        {
            protected override ILoggerFacade CreateLogger()
            {
                return null;
            }

            protected override DependencyObject CreateShell()
            {
                throw new NotImplementedException();
            }

            protected override void InitializeShell()
            {
                throw new NotImplementedException();
            }
        }
    }
}
