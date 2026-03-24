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
    /// Adds a Node to the Diagram.
    /// </summary>
    /// <param name="shape">Shape to add.</param>
    public void AddNode(FlowchartNode shape)
    {
        // TODO: Check for dupes
        // TODO: Check for Syntax Issues 
        Factory.Nodes.Add(shape);
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
        foreach(var node in Factory.Nodes)
        {
            builder.AppendLine($"    {node.Id}");
        }
        return builder.ToString();
    }
}
