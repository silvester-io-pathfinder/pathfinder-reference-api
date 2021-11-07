using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class SharpEaredCatfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Sharp-Eared Catfolk"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You were born with big, expressive ears that move with your moods and perk up at any unexpected sound. You gain a +2 circumstance bonus to locate undetected creatures that you could hear within 30 feet with a Seek action. As long as you're aware of a creature via sound, once per round, your ears can help you Point Out the creature to all allies as a free action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificActionCircumstanceBonus(Guid.Parse(""), Actions.Instances.Seek.ID, bonus: 2, addendum: "Only applies to creatures within 30 feet that you could hear.");
            builder.Manual(Guid.Parse(""), "As long as you're aware of a creature via sound, once per round, your ears can help you Point Out the creature to all allies as a free action.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 17
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Catfolk.ID;
        }
    }
}
