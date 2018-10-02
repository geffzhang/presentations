using System.Collections.Generic;
using System.Linq;
using Irony.Ast;
using Irony.Interpreter.Ast;
using Irony.Parsing;

namespace CustomDsl.Ast
{
    public class CaseConditionListNode : AstNode
    {
        public IEnumerable<CaseConditionNode> CaseConditionNodes { get; private set; }

        public override void Init(AstContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);

            CaseConditionNodes = treeNode.ChildNodes.Select(x => (CaseConditionNode)x.AstNode).ToArray();
        }
    }
}