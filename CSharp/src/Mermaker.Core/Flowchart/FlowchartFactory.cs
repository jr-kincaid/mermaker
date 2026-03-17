using System.Text;
using Mermaker.Core.Common;
using Mermaker.FrontMatter;

namespace Mermaker.Core.Flowchart;

public class FlowchartFactory
{
    /// <summary>
    /// Makes a <see cref="DiagramFrontmatter"/>.
    /// </summary>
    /// <returns><see cref="DiagramFrontmatter"/>.</returns>
    public DiagramFrontmatter MakeFrontMatter()
    {
        return new DiagramFrontmatter();
    }

    /// <summary>
    /// Generates Diagram Type Declaration.
    /// </summary>
    /// <param name="builder">Diagram's <see cref="StringBuilder"/>.</param>
    /// <param name="diagram">Diagram.</param>
    public void AddDiagramTypeDeclaration(StringBuilder builder, FlowchartDiagram diagram)
    {
        var orientation = diagram.Orientation;
        builder.Append(Constants.DiagramName);

        if (
            orientation != FlowchartOrientation.TopDown &&
            orientation != FlowchartOrientation.TopToBottom
        )
        {
            var o = orientation switch
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