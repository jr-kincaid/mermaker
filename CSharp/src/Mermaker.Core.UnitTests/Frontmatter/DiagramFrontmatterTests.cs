namespace Mermaker.Core.UnitTests.Frontmatter;

using System.Text;
using Mermaker.FrontMatter;
using NUnit.Framework;

[TestFixture]
public class DiagramFrontmatterTests
{
    [TestCase("", "")]
    [TestCase("Node", "---\r\ntitle: Node\r\n---\r\n")]
    public void Generate_WithTitleSpecified_CorrectOutput(string title, string expectedDiagram)
    {
        DiagramFrontmatter sut = new()
        {
            Title = title,
        };
        var builder = new StringBuilder();
        sut.Generate(builder);
        Assert.That(builder.ToString(), Is.EqualTo(expectedDiagram));
    }
}