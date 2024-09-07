using Exiled.API.Interfaces;
using System.ComponentModel;

namespace ScpList
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
    }
}
