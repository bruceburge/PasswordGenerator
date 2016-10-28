using System;

namespace PasswordGenerator
{
    public interface IPasswordPattern
    {
        void Initialize(Random random);

        string GetPattern();

        string GetPatternTitle();
    }
}