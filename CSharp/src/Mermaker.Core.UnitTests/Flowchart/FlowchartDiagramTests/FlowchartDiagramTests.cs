using Mermaker.Core.Flowchart;
using NUnit.Framework.Internal;

namespace Mermaker.Core.UnitTests;

public class FlowchartDiagramTests
{
    [Test]
    public void Generate_DefaultConstructor_ReturnsExpectedDiagram()
    {
        var sut = new FlowchartDiagram();
        var result = sut.Generate();
        Assert.That(result, Is.EqualTo("flowchart LR"));
    }
}
