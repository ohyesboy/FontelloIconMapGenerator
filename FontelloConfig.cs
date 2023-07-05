// See https://aka.ms/new-console-template for more information
public class FontelloConfig
{
    public string name { get; set; }
    public string css_prefix_text { get; set; }
    public bool css_use_suffix { get; set; }
    public bool hinting { get; set; }
    public int units_per_em { get; set; }
    public int ascent { get; set; }
    public Glyph[] glyphs { get; set; }
}

public class Glyph
{
    public string uid { get; set; }
    public string css { get; set; }
    public int code { get; set; }
    public string src { get; set; }
}
