using System;
using System.Collections.Generic;
using System.Text;

namespace LethalFoundation
{
    public struct KeywordReferences
    {
        public TerminalKeyword Route => Refs.AllKeywords[27];
        public TerminalKeyword Buy => Refs.AllKeywords[0];
        public TerminalKeyword Info => Refs.AllKeywords[6];
        public TerminalKeyword View => Refs.AllKeywords[19];
        public TerminalKeyword Moons => Refs.AllKeywords[21];
        public TerminalKeyword Confirm => Refs.AllKeywords[3];
        public TerminalKeyword Deny => Refs.AllKeywords[27];
    }
}
