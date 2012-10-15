using window.include;
using notepad.include;
using platform.include;

namespace program.optimal
{
    public class Plugin : IPlugin
    {
        public void _startupPlugin()
        {
            string shapeDescriptorUrl_ = @"rid://program.optimal.shapeDescriptorManagerUrl";
            WindowSingleton windowSingleton_ = __singleton<WindowSingleton>._instance();
            windowSingleton_._regShapeDescriptor(shapeDescriptorUrl_);

            string bindingManagerUrl_ = @"rid://program.optimal.bindingManager";
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            platformSingleton_._loadBindingManager(bindingManagerUrl_);
        }
    }
}
