using System.Drawing;
using GapCore;
using NeoKolors.Settings;

namespace GapModTest;

// this generator will be loaded automatically
public class ExampleGenerator : IImageGenerator<ExampleGenerator> {
    
    // this will generate a new image and return it
    public Bitmap GenerateImage() => new(100, 100);

    // settings shall be built using this method,
    // more at https://github.com/KryKomDev/NeoKolors/tree/main/NeoKolors.Settings
    public SettingsBuilder<ExampleGenerator> GetSettings() => throw new NotImplementedException();

    // returns settings, should always be the same as the other GetSettings()
    ISettingsBuilder<IImageGenerator> IImageGenerator.GetSettings() => GetSettings();
}