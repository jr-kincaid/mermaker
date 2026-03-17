namespace Mermaker.Core.UnitTests;

using System.Text;
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
}
