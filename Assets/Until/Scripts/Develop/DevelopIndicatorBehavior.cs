#if TEST
using UnityEngine;


namespace until.develop
{
    [DefaultExecutionOrder(until.defines.UntilBehaviorOrder.Develop_DevelopIndicatorBehavior)]
    [DisallowMultipleComponent]
    public class DevelopIndicatorBehavior : utils.Behavior
    {
        private void Update()
        {
            Singleton.DevelopIndicator.update();
        }

        // �f�o�b�O�`��
        private void OnGUI()
        {
            Singleton.DevelopIndicator.draw(new RectInt(0, 0, Screen.width, Screen.height));
        }
    }
}
#endif
