using System.Drawing;
using GapCore;
using GapCore.modLoader;
using NeoKolors.Settings;

namespace GapModTest;

// this example transformer will not be loaded automatically as it has the ExcludeFromModLoading attribute
[ExcludeFromModLoading]
public class ExampleTransformer : IImageTransformer<ExampleTransformer> {
    
    // this method transforms the image and returns it
    public Bitmap TransformImage(Bitmap image) => image;

    // settings shall be built using this method,
    // more at https://github.com/KryKomDev/NeoKolors/tree/main/NeoKolors.Settings
    public ISettingsBuilder<ExampleTransformer> GetSettings() => throw new NotImplementedException();

    // returns settings, should always be the same as the other GetSettings()
    ISettingsBuilder<IImageTransformer> IImageTransformer.GetSettings() => GetSettings();
}