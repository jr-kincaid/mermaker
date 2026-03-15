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

    [TestCase(FlowchartOrientation.BottomToTop, "flowchart BT\r\n")]
    [TestCase(FlowchartOrientation.LeftToRight, "flowchart LR\r\n")]
    [TestCase(FlowchartOrientation.RightToLeft, "flowchart RL\r\n")]
    [TestCase(FlowchartOrientation.TopDown, "flowchart\r\n")]
    [TestCase(FlowchartOrientation.TopToBottom, "flowchart\r\n")]
    public void Generate_Orientation_Shows(FlowchartOrientation orientation, string expectedDiagram)
    {
        FlowchartDiagram sut = new()
        {
            Orientation = orientation
        };
        var result = sut.Generate();
        Assert.That(result, Is.EqualTo(expectedDiagram));
    }
}
