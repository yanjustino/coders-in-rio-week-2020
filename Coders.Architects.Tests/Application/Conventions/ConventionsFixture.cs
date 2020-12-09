using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Fluent.Syntax.Elements.Types;
using ArchUnitNET.Loader;
using Dnad.Architects.Adapters.SqlServer;
using Dnad.Architects.Application.Ports.Database;
using Coders.Architects.MeetingManagement.Application.Events;
using Dnad.Architects.CertificateManagement.Application.Services.Interfaces;
using Dnad.Architects.CertificateManagement.Domain.Models.ValueObjects;
using Dnad.Architects.MeetingManagement.Application.Services.Interfaces;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Dnad.Architects.Tests.Application.Conventions
{
    public partial class InvoiceTests
    {
        private static System.Reflection.Assembly[] Assemblies => new[]
        {
            typeof(IInvoiceService).Assembly,
            typeof(ICertificateService).Assembly,
            typeof(InvoiceEventHandler).Assembly,
            typeof(CertificateUriDownload).Assembly,
            typeof(SqlServerHolder).Assembly,
            typeof(IDatabaseHolder).Assembly
        };        
        
        private static Architecture Architecture =>
            new ArchLoader().LoadAssemblies(Assemblies).Build();

        private static IObjectProvider<IType> EventClass =>
            Types()
                .That()
                .ResideInNamespace("Coders.Architects.MeetingManagement.Application.Events")
                .As("Domain Events");
        
        
        private static IObjectProvider<IType> MeetingManagementBoundedContext =>
            Types()
                .That()
                .ResideInAssembly("Dnad.Architects.MeetingManagement")
                .As("Appplication Layer");
        
        private static IObjectProvider<IType> CertificateManagementBoundedContext =>
            Types()
                .That()
                .ResideInAssembly("Dnad.Architects.CertificateManagement")
                .As("Appplication Layer");        

        private static IObjectProvider<IType> AdapterLayer =>
            Types()
                .That()
                .ResideInNamespace("Dnad.Architects.Adapters")
                .As("Adapter Layer");

        /* Classes Providers */
        
        private static IObjectProvider<Class> DataBaseHolerClasses =>
            Classes()
                .That()
                .ImplementInterface("IDatabaseHolder")
                .As("DataBaseHolerClasses Classes");        
    }
}