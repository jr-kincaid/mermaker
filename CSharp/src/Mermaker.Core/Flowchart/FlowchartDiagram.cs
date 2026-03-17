namespace Mermaker.Core.Flowchart;

using System.Text;
using Mermaker.Core.Common;
using Mermaker.FrontMatter;

public class FlowchartDiagram
{
    private readonly DiagramFrontmatter Frontmatter;

    /// <summary>
    /// Constructor
    /// </summary>
    public FlowchartDiagram()
    {
        Frontmatter = new DiagramFrontmatter();
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="orientation">Orientation</param>
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
    public string Generate ()
    {
        StringBuilder builder = new();
        Frontmatter.Generate(builder);
        GenerateDiagramTypeDeclaration(builder);
        return builder.ToString();
    }

    /// <summary>
    /// Generates Diagram Type Declaration.
    /// </summary>
    /// <param name="builder">Diagram's <see cref="StringBuilder"/>.</param>
    public void GenerateDiagramTypeDeclaration(StringBuilder builder)
    {
        builder.Append(Constants.DiagramName);

        if (
            Orientation != FlowchartOrientation.TopDown &&
            Orientation != FlowchartOrientation.TopToBottom
        )
        {
            var o = Orientation switch
            {
                FlowchartOrientation.BottomToTop => Constants.OrientationBottomToTop,
                FlowchartOrientation.LeftToRight => Constants.OrientationLeftToRight,
                FlowchartOrientation.RightToLeft => Constants.OrientationRightToLeft,
                _ => string.Empty
            };
            builder.Append($" {o}");
        }
        builder.Append(Environment.NewLine);
    }
}
