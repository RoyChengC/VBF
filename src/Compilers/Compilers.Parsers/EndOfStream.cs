﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VBF.Compilers.Scanners;

namespace VBF.Compilers.Parsers
{
    public class EndOfStream : ProductionBase<Lexeme>
    {
        public EndOfStream()
        {

        }

        public override void Accept(IProductionVisitor visitor)
        {
            visitor.VisitEndOfStream(this);
        }

        public override bool Equals(object obj)
        {
            var otherEos = obj as EndOfStream;

            if (otherEos != null)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return -3177;
        }

        public override bool IsTerminal
        {
            get
            {
                return true;
            }
        }

        public override bool IsEos
        {
            get
            {
                return true;
            }
        }
    }
}
