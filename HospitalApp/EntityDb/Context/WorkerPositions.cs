using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDb.Context
{
    /// <summary>
    /// 
    /// </summary>
    class WorkerPositions:HeaderId
    {
        /// <summary>
        /// 
        /// </summary>
        public Users User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Positions Position { get; set; }
    }
}
