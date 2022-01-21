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
    public class GutsyHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("4ce3660b-c78a-4eb5-b487-e234132f4f34");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Gutsy Halfling"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d0a9899d-b69b-4de8-b96b-7eb15e4e4981"), Type = TextBlockType.Text, Text = "Your family line is known for keeping a level head and staving off fear when the chips were down, making them wise leaders and sometimes even heroes. When you roll a success on a saving throw against an emotion effect, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ImproveSpecificTraitAnySavingThrow(Guid.Parse("0a5fc8b7-eaba-47ae-a351-11167b5d4f40"), Traits.Instances.Emotion.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9abf1211-e4fa-4fcb-844a-219b972f4d30"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 51
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Halfling.ID;
        }
    }
}
