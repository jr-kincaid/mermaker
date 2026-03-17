namespace Mermaker.Core;

using System.Text;
using Mermaker.Core.Flowchart;
using Mermaker.FrontMatter;

public class FlowchartDiagram
{
    private readonly DiagramFrontmatter Frontmatter;
    private readonly FlowchartFactory Factory;

    /// <summary>
    /// Constructor.
    /// </summary>
    public FlowchartDiagram()
    {
        Factory = new FlowchartFactory();
        Frontmatter = Factory.MakeFrontMatter();
    }

    /// <summary>
    /// Orientation.
    /// </summary>
    public FlowchartOrientation Orientation {get; set;}

    /// <summary>
    /// Title of the Diagram
    /// </summary>
    public string Title
    {
        get
        {
            return Frontmatter.Title;
        }
        set
        {
            Frontmatter.Title = value;
        }
    }
    
    /// <summary>
    /// Generates Diagram as a string.
    /// </summary>
    /// <returns>String.</returns>
    public string Make()
    {
        StringBuilder builder = new();
        Frontmatter.Make(builder);
        Factory.AddDiagramTypeDeclaration(builder, this);
        return builder.ToString();
    }

    
}
