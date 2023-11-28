﻿namespace Rei02.Area
{
    internal abstract class AreaBase
    {
        protected AreaBase(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract void Add(AreaBase area);
    }
}
