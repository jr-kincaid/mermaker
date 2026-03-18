namespace Mermaker.Core.UnitTests;

using Mermaker.Core.Flowchart;
using NUnit.Framework;

[TestFixture]
public class FlowchartDiagramTests
{
    [Test]
    public void Make_DefaultConstructor_ReturnsExpectedDiagram()
    {
        var sut = new FlowchartDiagram();
        var result = sut.Make();
        Assert.That(result, Is.EqualTo("flowchart\r\n"));
    }

    [Test]
    public void Make_AddingANode_ReturnsExpectedDiagram()
    {
        var sut = new FlowchartDiagram();
        var node = new FlowchartNodeBox("A");
        sut.AddNode(node);
        var result = sut.Make();
        Assert.That(result, Is.EqualTo("flowchart\r\n    A\r\n"));
    }
}
