# FontelloIconMapGenerator

1. You go to https://fontello.com/ to pick your icons, download, unzip, the folder should contain a `config.json` which includes the icon **name** and **Unicode**.



```
{
  "name": "",
  "css_prefix_text": "icon-",
  "css_use_suffix": false,
  "hinting": true,
  "units_per_em": 1000,
  "ascent": 850,
  "glyphs": [
    {
      "uid": "7222571caa5c15f83dcfd447c58d68d9",
      "css": "search",
      "code": 59393,
      "src": "entypo"
    },
    {
      "uid": "559647a6f430b3aeadbecd67194451dd",
      "css": "menu",
      "code": 61641,
      "src": "fontawesome"
    },
	...
  ]
}
```

2. You run this app, pointing to the unzipped folder and C# class is printed out in console and clipboard.

```powershell
$ net7.0 > dotnet  .\FontelloIconMapGenerator.dll C:\work\fontello-194d84f3
public static class Icons
{
        public const string Search = "\uE801";
        public const string Menu = "\uF0C9";
        public const string Home_Outline = "\uE800";
        public const string Home = "\uE802";
        public const string Doc_Text = "\uF0F6";
        public const string Forumbee = "\uF211";
        public const string Sliders = "\uF1DE";
}


```

3. Paste it into your C# project, now you can use the icons as characters given you also copied the font file properly.

   In MAUI project for example

   * Copy fontello.ttf to fonts folder 

   * Register it in MauiProgram
     ```
     ...
     fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
     fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
     fonts.AddFont("fontello.ttf", "icons");
     ```

   * Now in xaml, you can use it 
     ```
      xmlns:local="clr-namespace:BeeMock"
     ...
     <Label Text="{Static local:Icons.Home}"  FontFamily="icons" ... />
     ```

     

​		
