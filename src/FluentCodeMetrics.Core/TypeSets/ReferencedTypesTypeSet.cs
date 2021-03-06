﻿using System;
using System.Collections.Generic;
using System.Linq;
using FluentCodeMetrics.Core.TypeConstraints;
using ThrowHelper;

namespace FluentCodeMetrics.Core.TypeSets
{
    public sealed class ReferencedTypesTypeSet : 
        TypeSet
    {
        private readonly IEnumerable<Type> sourceField;
        private readonly Type originalField;

        internal ReferencedTypesTypeSet(IEnumerable<Type> source, Type original)
        {
            sourceField = source;
            originalField = original;
        }

        public override IEnumerable<Type> GetAllTypes()
        {
            return sourceField;
        }

        public ReferencesInspector And
        {
            get
            {
                return new ReferencesInspector(
                    originalField, 
                    sourceField
                    );
            }
        }

        public ReferencedTypesTypeSet FilterBy(TypeConstraint filter)
        {
            Throw.IfArgumentNull(filter, "filter");
            return new ReferencedTypesTypeSet(
                sourceField.Where(filter.Check),
                originalField
                );
        }
    }
}
