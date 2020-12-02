using System.Collections.Generic;
using System.Linq;

namespace Case99
{
    public class ItemsSource
    {
        private static readonly string[] _items = new[]
        {
            "Windows98",
            "Windows2000SP4",
            "WindowsCE",
            "WindowsMillenniumEdition",
            "WindowsMobileForPocketPC",
            "WindowsMobileForSmartphone",
            "WindowsServer2003",
            "WindowsXPMediaCenterEdition",
            "WindowsXPProfessionalx64Edition",
            "WindowsXPSP2",
            "WindowsXPStarterEdition"
        };

        public IEnumerable<string> GetItems(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return _items;
            }
            return from s in _items
                   where s.StartsWith(text)
                   select s;
        }
    }
}
