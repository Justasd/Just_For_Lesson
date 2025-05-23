// Signature file for parser generated by fsyacc
module CubyPar
type token = 
  | EOF
  | LPAR
  | RPAR
  | LBRACE
  | RBRACE
  | LBRACK
  | RBRACK
  | SEMI
  | COMMA
  | ASSIGN
  | AMP
  | COLON
  | CONTINUE
  | BREAK
  | QUEST
  | NOT
  | SEQOR
  | SEQAND
  | EQ
  | NE
  | GT
  | LT
  | GE
  | LE
  | PLUS
  | MINUS
  | TIMES
  | DIV
  | MOD
  | SELFPLUS
  | SELFMINUS
  | STRUCT
  | DOT
  | TRY
  | CATCH
  | THROW
  | CHAR
  | ELSE
  | IF
  | INT
  | FLOAT
  | NULL
  | PRINT
  | PRINTLN
  | RETURN
  | VOID
  | WHILE
  | SWITCH
  | CASE
  | FOR
  | IN
  | RANGE
  | STRING
  | DO
  | CSTCHAR of (char)
  | CSTSTRING of (string)
  | NAME of (string)
  | CSTFLOAT of (float32)
  | CSTINT of (int)
  | CSTBOOL of (int)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_LPAR
    | TOKEN_RPAR
    | TOKEN_LBRACE
    | TOKEN_RBRACE
    | TOKEN_LBRACK
    | TOKEN_RBRACK
    | TOKEN_SEMI
    | TOKEN_COMMA
    | TOKEN_ASSIGN
    | TOKEN_AMP
    | TOKEN_COLON
    | TOKEN_CONTINUE
    | TOKEN_BREAK
    | TOKEN_QUEST
    | TOKEN_NOT
    | TOKEN_SEQOR
    | TOKEN_SEQAND
    | TOKEN_EQ
    | TOKEN_NE
    | TOKEN_GT
    | TOKEN_LT
    | TOKEN_GE
    | TOKEN_LE
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_TIMES
    | TOKEN_DIV
    | TOKEN_MOD
    | TOKEN_SELFPLUS
    | TOKEN_SELFMINUS
    | TOKEN_STRUCT
    | TOKEN_DOT
    | TOKEN_TRY
    | TOKEN_CATCH
    | TOKEN_THROW
    | TOKEN_CHAR
    | TOKEN_ELSE
    | TOKEN_IF
    | TOKEN_INT
    | TOKEN_FLOAT
    | TOKEN_NULL
    | TOKEN_PRINT
    | TOKEN_PRINTLN
    | TOKEN_RETURN
    | TOKEN_VOID
    | TOKEN_WHILE
    | TOKEN_SWITCH
    | TOKEN_CASE
    | TOKEN_FOR
    | TOKEN_IN
    | TOKEN_RANGE
    | TOKEN_STRING
    | TOKEN_DO
    | TOKEN_CSTCHAR
    | TOKEN_CSTSTRING
    | TOKEN_NAME
    | TOKEN_CSTFLOAT
    | TOKEN_CSTINT
    | TOKEN_CSTBOOL
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startMain
    | NONTERM_Main
    | NONTERM_TopDeclares
    | NONTERM_TopDeclare
    | NONTERM_StructDeclare
    | NONTERM_MemberDefList
    | NONTERM_VariableDeclare
    | NONTERM_VariableDeclareAndAssign
    | NONTERM_VariableDescribe
    | NONTERM_FunctionDeclare
    | NONTERM_ParamDeclares
    | NONTERM_ParamDeclaresNotEmpty
    | NONTERM_Block
    | NONTERM_StmtOrDeclareSeq
    | NONTERM_Stmt
    | NONTERM_StmtM
    | NONTERM_StmtCase
    | NONTERM_StmtCatch
    | NONTERM_EXCEPTION
    | NONTERM_StmtU
    | NONTERM_Expr
    | NONTERM_ExprNotAccess
    | NONTERM_AtExprNotAccess
    | NONTERM_Access
    | NONTERM_Exprs
    | NONTERM_Exprs1
    | NONTERM_Const
    | NONTERM_ConstString
    | NONTERM_ConstFloat
    | NONTERM_ConstChar
    | NONTERM_Type
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val Main : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> (AbstractSyntax.Program) 
