namespace Mermaker.Core.Flowchart;

using System.Text;

public class FlowchartDiagram
{
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="orientation">Orientation</param>
    public FlowchartOrientation Orientation {get; set;}

    /// <summary>
    /// Title of the Diagram
    /// </summary>
    public string Title {get; set;} = string.Empty;
    
    /// <summary>
    /// Generates Diagram as a string.
    /// </summary>
    /// <returns>String.</returns>
    public string Generate ()
    {
        StringBuilder builder = new();
        GenerateDiagramTitle(builder);
        GenerateDiagramTypeDeclaration(builder);
        return builder.ToString();
    }

    /// <summary>
    /// Generates Title Line.
    /// </summary>
    /// <param name="builder">Diagram's <see cref="StringBuilder"/>.</param>
    public void GenerateDiagramTitle(StringBuilder builder)
    {
        if (string.IsNullOrEmpty(Title))
        {
            return;
        }
        builder.AppendLine(Constants.TitleSeparator);
        builder.AppendFormat($"{Constants.TitlePropertyName}: {Title}{Environment.NewLine}");
        builder.AppendLine(Constants.TitleSeparator);
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
