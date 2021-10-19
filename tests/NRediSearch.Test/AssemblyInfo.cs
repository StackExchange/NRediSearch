using System;
using Xunit;

[assembly: CollectionBehavior(CollectionBehavior.CollectionPerAssembly, DisableTestParallelization = true)]

namespace NRediSearch.Tests
{
    public class AssemblyInfo
    {
        public AssemblyInfo()
        {
        }
    }
}
