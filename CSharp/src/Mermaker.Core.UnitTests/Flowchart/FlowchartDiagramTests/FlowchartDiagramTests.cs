using System.Text;
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
        Assert.That(result, Is.EqualTo("flowchart\r\n"));
    }

    [TestCase("", "")]
    [TestCase("Node", "---\r\ntitle: Node\r\n---\r\n")]
    public void GenerateDiagramTitle_Generates_CorrectOutput(string title, string expectedDiagram)
    {
        FlowchartDiagram sut = new()
        {
            Title = title,
        };
        var builder = new StringBuilder();
        sut.GenerateDiagramTitle(builder);
        Assert.That(builder.ToString(), Is.EqualTo(expectedDiagram));
    }

    [TestCase(FlowchartOrientation.BottomToTop, "flowchart BT\r\n")]
    [TestCase(FlowchartOrientation.LeftToRight, "flowchart LR\r\n")]
    [TestCase(FlowchartOrientation.RightToLeft, "flowchart RL\r\n")]
    [TestCase(FlowchartOrientation.TopDown, "flowchart\r\n")]
    [TestCase(FlowchartOrientation.TopToBottom, "flowchart\r\n")]
    public void GenerateDiagramTypeDeclaration_Generates_CorrectOutput(FlowchartOrientation orientation, string expectedDiagram)
    {
        FlowchartDiagram sut = new()
        {
            Orientation = orientation
        };
        var builder = new StringBuilder();
        sut.GenerateDiagramTypeDeclaration(builder);
        Assert.That(builder.ToString(), Is.EqualTo(expectedDiagram));
    }
}
