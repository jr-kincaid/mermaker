namespace Mermaker.Core.Flowchart;

public record FlowchartNode(
    string startDeliminator, 
    string endDeliminator,
    string Id,
    string Name = ""
);