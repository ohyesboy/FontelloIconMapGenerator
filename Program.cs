using System.Globalization;
using System.Text;
using System.Text.Json;
using TextCopy;

if (args.Length != 1)
{
    Console.WriteLine("Need 1 argument to the folder contaning config.json from fontello");
    return;
}

//it can be full file path or just the folder
var path = args[0];
if (!File.Exists(path))
{
    path = Path.Combine(path, "config.json");
}

if (!File.Exists(path))
{
    Console.WriteLine("Path not found");
    return;
}

var json = File.ReadAllText(path);
var config = JsonSerializer.Deserialize<FontelloConfig>(json);
var sb = new StringBuilder();
sb.AppendLine(@"public static class Icons
{");
foreach (var item in config.glyphs)
{
    TextInfo info = CultureInfo.CurrentCulture.TextInfo;

    var name = item.css.Replace("-", "_").Replace(" ", "_");
    name = info.ToTitleCase(name);
    sb.AppendLine($"\tpublic const string {name} = \"\\u{item.code.ToString("X")}\";");
}
sb.AppendLine("}");

var content = sb.ToString();
Console.WriteLine(content);
ClipboardService.SetText(content);