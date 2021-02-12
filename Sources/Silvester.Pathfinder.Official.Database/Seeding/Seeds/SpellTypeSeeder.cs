using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class SpellTypeSeeder : IEntitySeeder<SpellType>
    {
        public IEnumerable<SpellType> GetSeedEntities()
        {
            yield return new SpellType { Id = Guid.Parse("daeadc1d-bf76-442b-9b4c-8276fa9effac"), Name = "Spell", Description = "A regular spell that has to be prepared or can be cast spontaneously, without any additional focus requirements, using a spell slot in the process." };
            yield return new SpellType { Id = Guid.Parse("fbd536e4-6468-4ca5-84de-aa2e5a33776f"), Name = "Cantrip", Description = "A cantrip is a special type of spell that’s weaker than other spells but can be used with greater freedom and flexibility. The title of a cantrip’s stat block says “Cantrip” instead of “Spell.” Casting a cantrip doesn’t use up your spell slots; you can cast a cantrip at will, any number of times per day. If you’re a prepared caster, you can prepare a specific number of cantrips each day. You can’t prepare a cantrip in a spell slot. A cantrip is always automatically heightened to half your level, rounded up. For a typical spellcaster, this means its level is equal to the highest level of spell slot you have." };
            yield return new SpellType { Id = Guid.Parse("69863985-2984-4514-9299-588c6dd32cd7"), Name = "Focus", Description = "Focus spells are a special type of spell attained directly from a branch of study, from a deity, or from another specific source. You can learn focus spells only through special class features or feats, rather than choosing them from a spell list. Furthermore, you cast focus spells using a special pool of Focus Points—you can’t prepare a focus spell in a spell slot or use your spell slots to cast focus spells; similarly, you can’t spend your Focus Points to cast spells that aren’t focus spells. Even some classes that don’t normally grant spellcasting, such as the champion and monk, can grant focus spells. Focus spells are automatically heightened to half your level rounded up, just like cantrips are. You can’t cast a focus spell if its minimum level is greater than half your level rounded up, even if you somehow gain access to it. Casting any of your focus spells costs you 1 Focus Point. You automatically gain a focus pool of 1 Focus Point the first time you gain an ability that gives you a focus spell. You replenish all the Focus Points in your pool during your daily preparations. You can also use the Refocus activity to pray, study, meditate, or otherwise reattune yourself to the source of your focus magic and regain a Focus Point. Some abilities allow you to increase the Focus Points in your pool beyond 1. Typically, these are feats that give you a new focus spell and increase the number of points in your pool by 1. Your focus pool can’t have a capacity beyond 3 Focus Points, even if feats that increase your pool would cause it to exceed this number." };
        }
    }
}
