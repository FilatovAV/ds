using System;
using System.Collections.Generic;
using System.Linq;

namespace ds.test.impl
{
    public class Plugins : IPluginFactory
    {
        private readonly Dictionary<string, IPlugin> _plugins;

        public Plugins()
        {
            _plugins = new Dictionary<string, IPlugin>() { { "sum", new Sum() } };
        }
        public int PluginsCount => _plugins.Count;

        public string[] GetPluginNames => _plugins.Keys.ToArray();

        public IPlugin GetPlugin(string pluginName)
        {
            if (string.IsNullOrEmpty(pluginName))
            {
                throw new ArgumentNullException(nameof(pluginName));
            }
            _plugins.TryGetValue(pluginName, out var plugin);
            return plugin ?? throw new ArgumentException($"Плагин с именем {pluginName} не зарегистрирован!");
        }
    }
}
