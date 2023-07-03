using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class TimeWatch {
        public DateTime Start() {
            return DateTime.Now;
        }

        public TimeSpan Stop(DateTime startTime) {
            return DateTime.Now - startTime;
        }
    }
}
