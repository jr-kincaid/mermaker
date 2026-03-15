namespace Mermaker.Core.Flowchart;

using System.Text;

public class FlowchartDiagram
{
    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="orientation">Orientation</param>
    public FlowchartOrientation Orientation {get; set;}

    public string Title { get; set; }

    public string Generate ()
    {
        StringBuilder builder = new StringBuilder();

        if(!string.IsNullOrWhiteSpace(Title))
        {
            builder.AppendLine(Title);
        }
        
        var name = "flowchart LR";
        builder.Append(name);
        return builder.ToString();
    }
}
