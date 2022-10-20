namespace Content.WebApi.DI.Autofac.Modules
{
    using Commands.Abstractions;
    using global::Autofac;
    using global::Autofac.Extensions.ConfiguredModules;
    using Microsoft.Extensions.Configuration;
    using Persistence.ORM;
    using Persistence.ORM.Commands;
    using Tados.Autofac.Extensions.TypedFactories;

    public class CommandsModule : ConfiguredModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            //bool useOrm = Configuration.GetValue("UseORM", false);


            builder
                .RegisterGeneric(typeof(CreateObjectWithIdCommand<>))
                .As(typeof(IAsyncCommand<>))
                .InstancePerDependency();
                
            builder
                .RegisterGeneric(typeof(UpdateObjectWithIdCommand<>))
                .As(typeof(IAsyncCommand<>))
                .InstancePerDependency();
                
            builder
                .RegisterAssemblyTypes(typeof(PersistenceOrmAssemblyMarker).Assembly)
                .AsClosedTypesOf(typeof(IAsyncCommand<>))
                .InstancePerDependency();
            

            builder
                .RegisterGenericTypedFactory<IAsyncCommandFactory>()
                .InstancePerLifetimeScope();

            builder
                .RegisterType<DefaultAsyncCommandBuilder>()
                .As<IAsyncCommandBuilder>()
                .InstancePerLifetimeScope();
        }
    }
}