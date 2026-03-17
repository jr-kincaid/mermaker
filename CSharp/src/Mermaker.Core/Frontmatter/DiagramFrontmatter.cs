namespace Mermaker.FrontMatter;

using System.Text;
using Mermaker.Core.Common;

public class DiagramFrontmatter
{
    /// <summary>
    /// Title of the Diagram
    /// </summary>
    public string Title {get; set;} = string.Empty;

    /// <summary>
    /// Generates Entire Frontmatter section.
    /// </summary>
    /// <param name="builder">Diagram's <see cref="StringBuilder"/>.</param>
    public void Generate(StringBuilder builder)
    {

        var lineGenerators = new [ ] {
            TryToGenerateTitleLine,
        };

        var lines = new List<string>();
        foreach(var lg in lineGenerators)
        {
            var success = lg(out var line);
            if(success)
            {
                lines.Add(line);
            }
        }
        if(lines.Count > 0)
        {
            builder.AppendLine(Constants.FrontMatterSeparator);
            builder.AppendLine(string.Join($"{Environment.NewLine}", lines));
            builder.AppendLine(Constants.FrontMatterSeparator);
        }
    }

    public bool TryToGenerateTitleLine(out string titleLine)
    {
        if (string.IsNullOrEmpty(Title))
        {
            titleLine =string.Empty;
            return false;
        }
        titleLine = $"{Constants.TitlePropertyName}: {Title}";
        return true;
    }
}