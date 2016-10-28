using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public interface IPasswordPattern
    {
        void Initialize(Random random);

        string GetPattern();
        string GetPatternTitle();
    }
}
