﻿using BenchmarkDotNet.Attributes;

namespace Console.Benchmarks
{
    public class EnumerationAscending<TPayload> : EnumerationWithRealData<TPayload>
        where TPayload : new()
    {
        [Benchmark]
        public void Work()
        {
            Execute(_ascendingOffsets);
        }
    }
}