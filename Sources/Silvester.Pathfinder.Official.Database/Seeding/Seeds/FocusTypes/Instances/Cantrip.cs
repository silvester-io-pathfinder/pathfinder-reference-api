using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FocusTypes.Instances
{
    public class Cantrip : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override FocusType GetFocusType()
        {
           return new FocusType
           { 
               Id = ID, 
               Name = "Cantrip",
               Description = "A cantrip is a special type of spell that’s weaker than other spells but can be used with greater freedom and flexibility. The title of a cantrip’s stat block says “Cantrip” instead of “Focus.” Casting a cantrip doesn’t use up your spell slots or focus points; you can cast a cantrip at will, any number of times per day. If you’re a prepared caster, you can prepare a specific number of cantrips each day. You can’t prepare a cantrip in a spell slot. A cantrip is always automatically heightened to half your level, rounded up. For a typical spellcaster, this means its level is equal to the highest level of spell slot you have." 
           };
        }
    }
}
