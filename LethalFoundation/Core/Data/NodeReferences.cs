using System;
using System.Collections.Generic;
using System.Text;

namespace LethalFoundation
{
    public struct NodeReferences
    {
        public TerminalNode CancelRoute => Refs.Keywords.Route.GetNounAt(0).result.GetNounAt(0).result;
        public TerminalNode CancelBuy => Refs.Keywords.Route.GetNounAt(0).result.GetNounAt(1).result;
        public TerminalNode MoonsResult => Refs.Keywords.Moons.specialKeywordResult;
    }
}
