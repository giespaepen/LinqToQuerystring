﻿namespace LinqToQuerystring.TreeNodes
{
    using System.Linq;
    using System.Linq.Expressions;

    using Antlr.Runtime;

    using LinqToQuerystring.TreeNodes.Base;

    public class AscNode : SingleChildNode
    {
        public AscNode(IToken payload)
            : base(payload)
        {
        }

        public override Expression BuildLinqExpression<T>(IQueryable query, Expression expression, ParameterExpression item = null)
        {
            return this.ChildNode.BuildLinqExpression<T>(query, expression, item);
        }
    }
}