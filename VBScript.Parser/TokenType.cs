﻿namespace VBScript.Parser
{
    public enum TokenType
    {
        Eof,
        LineTermination,
        Comment,
        StringLiteral,
        DecIntegerLiteral,
        HexIntegerLiteral,
        OctIntegerLiteral,
        DateLiteral,
        FloatLiteral,
        TrueLiteral,
        FalseLiteral,
        NullLiteral,
        EmptyLiteral,
        NothingLiteral,
        Identifier,
    }

    public enum Punctuation
    {
        LParen, RParen,
        LBracket, RBracket,
        Dot, Comma, Plus, Minus,
        Slash, Backslash,
        Star, Amp, Exp,
        Equal, NotEqual,
        Less, LessOrEqual,
        Greater, GreaterOrEqual
    }

    public enum Keyword
    {
        Step,
        Property,
        Explicit,
        Error,
        Erase,
        Default,
        And,
        ByRef,
        ByVal,
        Call,
        Case,
        Class,
        Const,
        Dim,
        Do,
        Each,
        Else,
        ElseIf,
        End,
        Eqv,
        Exit,
        For,
        Function,
        Get,
        Goto,
        If,
        Imp,
        In,
        Xor,
        With,
        While,
        WEnd,
        To,
        Until,
        Then,
        Sub,
        Set,
        Select,
        Resume,
        ReDim,
        Public,
        Private,
        Preserve,
        Or,
        Option,
        On,
        Not,
        Next,
        New,
        Mod,
        Loop,
        Let,
        Is
    }
}
