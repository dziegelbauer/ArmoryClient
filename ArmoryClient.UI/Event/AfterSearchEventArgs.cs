using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmoryClient.Models;

namespace ArmoryClient.UI.Event;
public class AfterSearchEventArgs
{
    public string SearchRealm { get; set; }
    public string SearchName { get; set; }
    public Region SearchRegion { get; set; }
}
