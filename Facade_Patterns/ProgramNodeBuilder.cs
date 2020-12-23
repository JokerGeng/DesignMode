using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Patterns
{
    public abstract class ProgramNode
    {
        public abstract void GetSourcePostion(int line, int index);

        public abstract void Add(ProgramNode child);

        public abstract void Remove(ProgramNode child);

        public abstract void Traverse(CodeGenerator generator);
        protected ProgramNode()
        {

        }
    }

    public class StatementNode : ProgramNode
    {
        List<ProgramNode> children = new List<ProgramNode>();
        public override void Add(ProgramNode child)
        {
            children.Add(child);
        }

        public override void GetSourcePostion(int line, int index)
        {
            
        }

        public override void Remove(ProgramNode child)
        {
            children.Remove(child);
        }

        public override void Traverse(CodeGenerator generator)
        {
            generator.Visit(this);
            List<ProgramNode> i = children;
            foreach (var item in i)
            {
                item.Traverse(generator);
            }
        }
    }

    public class ExpressionNode : ProgramNode
    {
        List<ProgramNode> children = new List<ProgramNode>();
        public override void Add(ProgramNode child)
        {
            children.Add(child);
        }

        public override void GetSourcePostion(int line, int index)
        {
           
        }

        public override void Remove(ProgramNode child)
        {
            children.Remove(child);
        }

        public override void Traverse(CodeGenerator generator)
        {
            generator.Visit(this);
            List<ProgramNode> i = children;
            foreach (var item in i)
            {
                item.Traverse(generator);
            }
        }
    }

    public abstract class ProgramNodeBuilder
    {
        public ProgramNodeBuilder()
        {

        }

        public abstract ProgramNode NewVarible(string varibleName);

        public abstract ProgramNode NewAssignment(ProgramNode varible, ProgramNode expression);

        public abstract ProgramNode NewReturnStatement(ProgramNode value);

        public abstract ProgramNode NewCondition(ProgramNode condition, ProgramNode truePart, ProgramNode falsePart);

        public abstract ProgramNode GetRootNode();
    }
}
