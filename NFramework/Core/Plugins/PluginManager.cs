using System;
using System.Collections.Generic;

namespace NFramework.Core.Plugins
{
    public class PluginManager
    {
        // Danh sách lưu trữ tất cả các plugin đã được đăng ký
        private readonly List<object> _plugins = new();

        // Đăng ký một plugin mới
        public void RegisterPlugin<T>(T plugin)
        {
            _plugins.Add(plugin);
            Console.WriteLine($"Plugin {typeof(T).Name} registered.");
        }

        // Lấy tất cả các plugin đã đăng ký kiểu T
        public IEnumerable<T> GetPlugins<T>()
        {
            foreach (var plugin in _plugins)
            {
                if (plugin is T typedPlugin)
                {
                    yield return typedPlugin;
                }
            }
        }

        // Kích hoạt tất cả các plugin đã đăng ký kiểu T và thực thi một hành động cụ thể
        public void ActivatePlugins<T>(Action<T> action)
        {
            foreach (var plugin in GetPlugins<T>())
            {
                action(plugin);
            }
        }
    }
}
