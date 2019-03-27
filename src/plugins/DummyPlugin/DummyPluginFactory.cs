﻿using System.Collections.Generic;
using Contract;

namespace DummyPlugin
{
    public sealed class DummyPlugin : SandboxPlugin, IStorageFactory
    {
        public DummyPlugin(ILogger logger)
            : base(logger)
        {
        }

        public override string Name => nameof(DummyPlugin);

        public override IStorageFactory Factory => this;

        public IMappedIntervalsCollection<T> Create<T>()
        {
            return new MappedIntervalsCollection<T>();
        }

        public IMappedIntervalsCollection<T> Create<T>(IReadOnlyList<MappedInterval<T>> intervals)
        {
            throw new System.NotImplementedException();
        }
    }
}