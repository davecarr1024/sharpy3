using System.Collections;
using System.Diagnostics;
using System.Text;

namespace Sharpy.Core.Processor
{
    public interface Result
    {
        IEnumerable<Result> ToEnumerable();
    }
}