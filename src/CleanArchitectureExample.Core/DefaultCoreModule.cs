using Autofac;
using CleanArchitectureExample.Core.Interfaces;
using CleanArchitectureExample.Core.Services;

namespace CleanArchitectureExample.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
