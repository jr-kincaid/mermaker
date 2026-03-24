namespace Mermaker.Core.Flowchart;
public record FlowchartNodeBox(
    string Id,
    string Label = ""
) : FlowchartNode("[", "]", Id, Label);