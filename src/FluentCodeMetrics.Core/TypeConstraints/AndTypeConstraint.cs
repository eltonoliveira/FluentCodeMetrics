﻿using System;

namespace FluentCodeMetrics.Core.TypeConstraints
{
    public class AndTypeConstraint : TypeConstraint
    {
        private readonly TypeConstraint leftField;
        private readonly TypeConstraint rightField;

        internal AndTypeConstraint(TypeConstraint left, TypeConstraint right)
        {
            leftField = left;
            rightField = right;
        }

        public override bool Check(Type type)
        {
            return leftField.Check(type) && rightField.Check(type);
        }
    }
}