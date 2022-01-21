using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArcaneTheses.Instances
{
    public class SpellBlending : Template
    {
        public static readonly Guid ID = Guid.Parse("4491e4c1-f277-44a9-b361-5b54c19cc3b2");

        protected override ArcaneThesis GetArcaneThesis()
        {
            return new ArcaneThesis
            {
                Id = ID, 
                Name = "Spell Blending", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f7b6c8da-f08c-4e8b-9a5c-c45cd08af6bf"), Type = TextBlockType.Text, Text = "You theorize that spell slots are a shorthand for an underlying energy that powers all spellcasting, and you've found a way to tinker with the hierarchy of spell slots, combining them to fuel more powerful spells." };
            yield return new TextBlock { Id = Guid.Parse("ab06684f-444a-4dac-8c98-bfae91473769"), Type = TextBlockType.Text, Text = "When you make your daily preparations, you can trade two spell slots of the same level for a bonus spell slot of up to 2 levels higher than the traded spell slots. You can exchange as many spell slots as you have available. Bonus spell slots must be of a level you can normally cast, and each bonus spell slot must be of a different spell level. You can also trade any spell slot for two additional cantrips, though you cannot trade more than one spell slot at a time for additional cantrips in this way." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77fdcc71-cbcf-4b81-9678-49b386181bdb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 206
            };
        }
    }
}
