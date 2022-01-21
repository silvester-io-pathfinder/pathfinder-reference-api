using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class Draxie : Template
    {
        public static readonly Guid ID = Guid.Parse("3e18dc2e-6699-42b7-890a-d0c75915d791");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Draxie"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e82e850f-529b-40bd-93ab-8449519340a9"), Type = TextBlockType.Text, Text = "You are kin to faerie dragons, tracing your heritage back to the death of the mightiest faerie dragon in the First World. You gain touch telepathy, allowing you to communicate silently and purely mentally with any creature you're touching, as long as you share a language." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificAbility(Guid.Parse("4d9ab12a-5dfe-469d-9f5d-067aea710308"), Abilities.Instances.Telepathy.ID, "Touch.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3809dc3-8392-4a94-952a-05691456c4b8"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 129
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Sprite.ID;
        }
    }
}
