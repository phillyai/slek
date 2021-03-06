﻿namespace slek.Compilers.Syntax
{
    public class Node
    {
        public Node()
        {
        }
        public override bool Equals(object obj)
        {
            var node = obj as Node;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            return true;
        }
    }

    public class Program : Node
    {
        public StmtNode[] Nodes;
        public Program(StmtNode[] Nodes)
        {
            this.Nodes = Nodes;
        }
        public override bool Equals(object obj)
        {
            var node = obj as Program;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Nodes.Equals(node.Nodes)))
                return false;
            return true;
        }
    }

    public class StmtNode : Node
    {
        public StmtNode()
        {
        }
        public override bool Equals(object obj)
        {
            var node = obj as StmtNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            return true;
        }
    }

    public class ParamsNode : Node
    {
        public ValueInfoNode[] Parameters;
        public ParamsNode(ValueInfoNode[] Parameters)
        {
            this.Parameters = Parameters;
        }
        public override bool Equals(object obj)
        {
            var node = obj as ParamsNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Parameters.Equals(node.Parameters)))
                return false;
            return true;
        }
    }

    public class ValueInfoNode : Node
    {
        public string Name;
        public string Type;
        public ValueInfoNode(string Name, string Type)
        {
            this.Name = Name;
            this.Type = Type;
        }
        public override bool Equals(object obj)
        {
            var node = obj as ValueInfoNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Name.Equals(node.Name)))
                return false;
            if (!(this.Type.Equals(node.Type)))
                return false;
            return true;
        }
    }

    public class SuiteNode : Node
    {
        public StmtNode[] Statements;
        public SuiteNode(StmtNode[] Statements)
        {
            this.Statements = Statements;
        }
        public override bool Equals(object obj)
        {
            var node = obj as SuiteNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Statements.Equals(node.Statements)))
                return false;
            return true;
        }
    }

    public class ImportStmtNode : StmtNode
    {
        public SyntaxToken Name;
        public ImportStmtNode(SyntaxToken Name)
        {
            this.Name = Name;
        }
        public override bool Equals(object obj)
        {
            var node = obj as ImportStmtNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Name.Equals(node.Name)))
                return false;
            return true;
        }
    }

    public class BreakStmtNode : StmtNode
    {
        public BreakStmtNode()
        {
        }
        public override bool Equals(object obj)
        {
            var node = obj as BreakStmtNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            return true;
        }
    }

    public class ContinueStmtNode : StmtNode
    {
        public ContinueStmtNode()
        {
        }
        public override bool Equals(object obj)
        {
            var node = obj as ContinueStmtNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            return true;
        }
    }

    public class ReturnStmtNode : StmtNode
    {
        public ExprNode Expr;
        public ReturnStmtNode(ExprNode Expr)
        {
            this.Expr = Expr;
        }
        public override bool Equals(object obj)
        {
            var node = obj as ReturnStmtNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Expr.Equals(node.Expr)))
                return false;
            return true;
        }
    }

    public class ModuleDefStmtNode : StmtNode
    {
        public string Name;
        public Program Body;
        public ModuleDefStmtNode(string Name, Program Body)
        {
            this.Name = Name;
            this.Body = Body;
        }
        public override bool Equals(object obj)
        {
            var node = obj as ModuleDefStmtNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Name.Equals(node.Name)))
                return false;
            if (!(this.Body.Equals(node.Body)))
                return false;
            return true;
        }
    }

    public class StructDefStmtNode : StmtNode
    {
        public string Name;
        public Node[] Members;
        public StructDefStmtNode(string Name, Node[] Members)
        {
            this.Name = Name;
            this.Members = Members;
        }
        public override bool Equals(object obj)
        {
            var node = obj as StructDefStmtNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Name.Equals(node.Name)))
                return false;
            if (!(this.Members.Equals(node.Members)))
                return false;
            return true;
        }
    }

    public class CtorDefStmtNode : StmtNode
    {
        public ParamsNode Parameters;
        public SuiteNode Body;
        public CtorDefStmtNode(ParamsNode Parameters, SuiteNode Body)
        {
            this.Parameters = Parameters;
            this.Body = Body;
        }
        public override bool Equals(object obj)
        {
            var node = obj as CtorDefStmtNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Parameters.Equals(node.Parameters)))
                return false;
            if (!(this.Body.Equals(node.Body)))
                return false;
            return true;
        }
    }

    public class FuncDefStmtNode : StmtNode
    {
        public string Name;
        public ParamsNode Parameters;
        public string Type;
        public SuiteNode Body;
        public FuncDefStmtNode(string Name, ParamsNode Parameters, string Type, SuiteNode Body)
        {
            this.Name = Name;
            this.Parameters = Parameters;
            this.Type = Type;
            this.Body = Body;
        }
        public override bool Equals(object obj)
        {
            var node = obj as FuncDefStmtNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Name.Equals(node.Name)))
                return false;
            if (!(this.Parameters.Equals(node.Parameters)))
                return false;
            if (!(this.Type.Equals(node.Type)))
                return false;
            if (!(this.Body.Equals(node.Body)))
                return false;
            return true;
        }
    }

    public class VarDefStmtNode : StmtNode
    {
        public string Name;
        public string Type;
        public ExprNode Value;
        public VarDefStmtNode(string Name, string Type, ExprNode Value)
        {
            this.Name = Name;
            this.Type = Type;
            this.Value = Value;
        }
        public override bool Equals(object obj)
        {
            var node = obj as VarDefStmtNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Name.Equals(node.Name)))
                return false;
            if (!(this.Type.Equals(node.Type)))
                return false;
            if (!(this.Value.Equals(node.Value)))
                return false;
            return true;
        }
    }

    public class IfStmtNode : StmtNode
    {
        public ExprNode Condition;
        public SuiteNode Body;
        public IfStmtNode ElseIf;
        public SuiteNode Else;
        public IfStmtNode(ExprNode Condition, SuiteNode Body, IfStmtNode ElseIf, SuiteNode Else)
        {
            this.Condition = Condition;
            this.Body = Body;
            this.ElseIf = ElseIf;
            this.Else = Else;
        }
        public override bool Equals(object obj)
        {
            var node = obj as IfStmtNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Condition.Equals(node.Condition)))
                return false;
            if (!(this.Body.Equals(node.Body)))
                return false;
            if (!(this.ElseIf.Equals(node.ElseIf)))
                return false;
            if (!(this.Else.Equals(node.Else)))
                return false;
            return true;
        }
    }

    public class WhileStmtNode : StmtNode
    {
        public ExprNode Condition;
        public SuiteNode Body;
        public WhileStmtNode(ExprNode Condition, SuiteNode Body)
        {
            this.Condition = Condition;
            this.Body = Body;
        }
        public override bool Equals(object obj)
        {
            var node = obj as WhileStmtNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Condition.Equals(node.Condition)))
                return false;
            if (!(this.Body.Equals(node.Body)))
                return false;
            return true;
        }
    }

    public class ForStmtNode : StmtNode
    {
        public bool IsNewVarDef;
        public string Value;
        public string Type;
        public ExprNode Source;
        public SuiteNode Body;
        public ForStmtNode(bool IsNewVarDef, string Value, string Type, ExprNode Source, SuiteNode Body)
        {
            this.IsNewVarDef = IsNewVarDef;
            this.Value = Value;
            this.Type = Type;
            this.Source = Source;
            this.Body = Body;
        }
        public override bool Equals(object obj)
        {
            var node = obj as ForStmtNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.IsNewVarDef.Equals(node.IsNewVarDef)))
                return false;
            if (!(this.Value.Equals(node.Value)))
                return false;
            if (!(this.Type.Equals(node.Type)))
                return false;
            if (!(this.Source.Equals(node.Source)))
                return false;
            if (!(this.Body.Equals(node.Body)))
                return false;
            return true;
        }
    }

    public class ExprNode : StmtNode
    {
        public ExprNode()
        {
        }
        public override bool Equals(object obj)
        {
            var node = obj as ExprNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            return true;
        }
    }

    public class BinaryExprNode : ExprNode
    {
        public SyntaxToken Operator;
        public ExprNode Left;
        public ExprNode Right;
        public BinaryExprNode(SyntaxToken Operator, ExprNode Left, ExprNode Right)
        {
            this.Operator = Operator;
            this.Left = Left;
            this.Right = Right;
        }
        public override bool Equals(object obj)
        {
            var node = obj as BinaryExprNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Operator.Equals(node.Operator)))
                return false;
            if (!(this.Left.Equals(node.Left)))
                return false;
            if (!(this.Right.Equals(node.Right)))
                return false;
            return true;
        }
    }

    public class UnaryExprNode : ExprNode
    {
        public SyntaxToken Operator;
        public ExprNode Expression;
        public UnaryExprNode(SyntaxToken Operator, ExprNode Expression)
        {
            this.Operator = Operator;
            this.Expression = Expression;
        }
        public override bool Equals(object obj)
        {
            var node = obj as UnaryExprNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Operator.Equals(node.Operator)))
                return false;
            if (!(this.Expression.Equals(node.Expression)))
                return false;
            return true;
        }
    }

    public class AtomExprNode : ExprNode
    {
        public ExprNode Atom;
        public TrailerExprNode[] Trailers;
        public AtomExprNode(ExprNode Atom, TrailerExprNode[] Trailers)
        {
            this.Atom = Atom;
            this.Trailers = Trailers;
        }
        public override bool Equals(object obj)
        {
            var node = obj as AtomExprNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Atom.Equals(node.Atom)))
                return false;
            if (!(this.Trailers.Equals(node.Trailers)))
                return false;
            return true;
        }
    }

    public class TrailerExprNode : ExprNode
    {
        public TrailerExprNode()
        {
        }
        public override bool Equals(object obj)
        {
            var node = obj as TrailerExprNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            return true;
        }
    }

    public class IndexerExprNode : TrailerExprNode
    {
        public ExprNode Parameter;
        public IndexerExprNode(ExprNode Parameter)
        {
            this.Parameter = Parameter;
        }
        public override bool Equals(object obj)
        {
            var node = obj as IndexerExprNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Parameter.Equals(node.Parameter)))
                return false;
            return true;
        }
    }

    public class CallExprNode : TrailerExprNode
    {
        public ExprNode[] Parameters;
        public CallExprNode(ExprNode[] Parameters)
        {
            this.Parameters = Parameters;
        }
        public override bool Equals(object obj)
        {
            var node = obj as CallExprNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Parameters.Equals(node.Parameters)))
                return false;
            return true;
        }
    }

    public class ArrayExprNode : ExprNode
    {
        public ExprNode[] Values;
        public ArrayExprNode(ExprNode[] Values)
        {
            this.Values = Values;
        }
        public override bool Equals(object obj)
        {
            var node = obj as ArrayExprNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Values.Equals(node.Values)))
                return false;
            return true;
        }
    }

    public class NewArrayExprNode : ExprNode
    {
        public string Type;
        public ExprNode Length;
        public NewArrayExprNode(string Type, ExprNode Length)
        {
            this.Type = Type;
            this.Length = Length;
        }
        public override bool Equals(object obj)
        {
            var node = obj as NewArrayExprNode;
            if (node == null)
                return false;
            if (this.GetType() != node.GetType())
                return false;
            if (!(this.Type.Equals(node.Type)))
                return false;
            if (!(this.Length.Equals(node.Length)))
                return false;
            return true;
        }
    }
}
