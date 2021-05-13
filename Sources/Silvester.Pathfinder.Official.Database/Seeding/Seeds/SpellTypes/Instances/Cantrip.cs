using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SpellTypes.Instances
{
    public class Cantrip : Template
    {
        public static readonly Guid ID = Guid.Parse("fbd536e4-6468-4ca5-84de-aa2e5a33776f");

        public override SpellType GetSpellType()
        {
           return new SpellType 
           { 
               Id = ID, 
               Name = "Cantrip",
               Description = "A cantrip is a special type of spell that’s weaker than other spells but can be used with greater freedom and flexibility. The title of a cantrip’s stat block says “Cantrip” instead of “Spell.” Casting a cantrip doesn’t use up your spell slots; you can cast a cantrip at will, any number of times per day. If you’re a prepared caster, you can prepare a specific number of cantrips each day. You can’t prepare a cantrip in a spell slot. A cantrip is always automatically heightened to half your level, rounded up. For a typical spellcaster, this means its level is equal to the highest level of spell slot you have." 
           };
        }
    }
}
