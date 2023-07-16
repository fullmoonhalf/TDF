public partial class Singleton
{
    public static until.boot.BootSystem BootSystem = until.boot.BootSystem.Instance;
    public static until.gameobject.GameObjectControlMediator GameObjectControlMediator = until.gameobject.GameObjectControlMediator.Instance;
    public static until.gameobject.PrefabInstantiateMediator PrefabInstantiateMediator = until.gameobject.PrefabInstantiateMediator.Instance;
    public static until.gameobject.SceneLoader SceneLoader = until.gameobject.SceneLoader.Instance;
    public static until.input.InputManager InputManager = until.input.InputManager.Instance;
    public static until.mode.ModeManager ModeManager = until.mode.ModeManager.Instance;
    public static until.randomizer.RandomizerManager RandomizerManager = until.randomizer.RandomizerManager.Instance;
    public static until.modules.camera.CameraManager CameraManager = until.modules.camera.CameraManager.Instance;
#if TEST
    public static until.develop.DevelopIndicator DevelopIndicator = until.develop.DevelopIndicator.Instance;
    public static until.develop.DevelopCommandManager DevelopCommandManager = until.develop.DevelopCommandManager.Instance;
#endif
}
