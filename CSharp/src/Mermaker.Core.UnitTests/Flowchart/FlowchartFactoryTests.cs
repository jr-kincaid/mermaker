namespace Mermaker.Core.UnitTests;
using System.Text;
using Mermaker.Core.Flowchart;
using NUnit.Framework;

[TestFixture]
public class FlowchartFactoryTests
{
    [TestCase(FlowchartOrientation.BottomToTop, "flowchart BT\r\n")]
    [TestCase(FlowchartOrientation.LeftToRight, "flowchart LR\r\n")]
    [TestCase(FlowchartOrientation.RightToLeft, "flowchart RL\r\n")]
    [TestCase(FlowchartOrientation.TopDown, "flowchart\r\n")]
    [TestCase(FlowchartOrientation.TopToBottom, "flowchart\r\n")]
    public void AddDiagramTypeDeclaration_Makes_CorrectOutput(FlowchartOrientation orientation, string expectedDiagram)
    {
        FlowchartDiagram diagram = new()
        {
            Orientation = orientation
        };
        var sut = new FlowchartFactory();
        var builder = new StringBuilder();
        sut.AddDiagramTypeDeclaration(builder, diagram);
        Assert.That(builder.ToString(), Is.EqualTo(expectedDiagram));
    }
}
