using ArmoryClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryClient.Data.Repository;
public interface IStaticRepository
{
    Task<IEnumerable<Realm>> GetRealms();
}
