using GapCore;
using GapCore.modLoader;

namespace GapModTest;

// this mod will be loaded automatically because it has the AutomaticallyLoaded attribute,
// if it was set to false it would not be loaded automatically
[AutomaticallyLoaded]

// every mod has to have a class implementing the IMod interface to be registered by the mod loader
class ExampleGapMod : IMod {

    public const string MOD_ID = "example";
    
    private static ImageTransformerDispatcher DISPATCHER = new(MOD_ID);

    // returns the mod id to the mod loader to avoid conflicts between mods
    public string Register() => MOD_ID;

    // initializes the mod by manually registering the ExampleTransformer, ExampleGenerator is loaded automatically 
    public void Initialize() {
        DISPATCHER.Register("example_transformer", typeof(ExampleTransformer));
    }

    // some info about the mod
    public string GetInfo() => "this is an example GAP mod";
}