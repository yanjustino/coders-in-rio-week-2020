using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Dnad.Architects.Tests.Application.Conventions
{
    public partial class InvoiceTests
    {
        [Fact]
        public void ClassesShouldHaveCorrectName()
        {
            Classes()
                .That().AreAssignableTo(EventClass)
                .Should()
                .HaveNameEndingWith("EventHandler")
                .Check(Architecture);
        }        
    }
}