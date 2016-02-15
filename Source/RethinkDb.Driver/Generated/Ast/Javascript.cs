












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class Javascript : ReqlExpr {

    
    
    
        public Javascript (object arg) : this(new Arguments(arg), null) {
        }
        public Javascript (Arguments args) : this(args, null) {
        }
        public Javascript (Arguments args, OptArgs optargs)
         : base(TermType.JAVASCRIPT, args, optargs) {
        }


    



    
///<summary>
/// "timeout": "T_NUM"
///</summary>
        public Javascript this[object optArgs] {
            get
            {
                var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
        
                return new Javascript (this.Args, newOptArgs);
            }
        }
        
///<summary>
/// "timeout": "T_NUM"
///</summary>
    public Javascript this[OptArgs optArgs] {
        get
        {
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
    
            return new Javascript (this.Args, newOptArgs);
        }
    }
    
///<summary>
/// "timeout": "T_NUM"
///</summary>
        public Javascript optArg(string key, object val){
            
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(key, val);
        
            return new Javascript (this.Args, newOptArgs);
        }


    

    


    
    }
}
