using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSS.az.Abstract_Classes
{
    public abstract class UniqueID
    {
        public static long id = default;

        [Newtonsoft.Json.JsonProperty("Identifier")]
        public long ID { get; set; } = ++id;
    }
}
