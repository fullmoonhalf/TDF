#if TEST
using UnityEngine;


namespace until.develop
{
    [DefaultExecutionOrder(until.defines.UntilBehaviorOrder.Develop_DevelopCommandBehavior)]
    [DisallowMultipleComponent]
    public class DevelopCommandBehavior : utils.Behavior
    {
        // Update is called once per frame
        private void Update()
        {
            Singleton.DevelopCommandManager.update();
        }

        private void OnGUI()
        {
            var screen = new Rect(200, 100, 400, 150);
            Singleton.DevelopCommandManager.draw(screen);
        }
    }
}
#endif


