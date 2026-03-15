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
    /// Generates a Mermaid Diagram as a string.
    /// </summary>
    /// <returns>String.</returns>
    public string Generate ()
    {
        StringBuilder builder = new();

        var name = "flowchart";
        builder.Append(name);

        if(
            Orientation != FlowchartOrientation.TopDown &&
            Orientation != FlowchartOrientation.TopToBottom
        )
        {
            var o = Orientation switch
            {
               FlowchartOrientation.BottomToTop => "BT",
               FlowchartOrientation.LeftToRight => "LR",
               FlowchartOrientation.RightToLeft => "RL",
               _=> string.Empty
            };
            builder.Append($" {o}");
        }
        builder.Append(Environment.NewLine);
        return builder.ToString();
    }
}
