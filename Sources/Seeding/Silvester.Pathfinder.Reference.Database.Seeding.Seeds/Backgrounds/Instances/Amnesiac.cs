using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Amnesiac : Template
    {
        public static readonly Guid ID = Guid.Parse("e765a1db-cc6e-40f2-a343-c24bdea4b9f7");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Amnesiac",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7e034843-ce02-46a1-967c-6447cc276c0b"), Type = TextBlockType.Text, Text = "Your background is.. well.. honestly, you can't remember! You might have inklings deep within your mind, undercurrents of unusual emotions or unexpected responses to certain people or situations, but ultimately you don't know who you once were. You might be adventuring specifically to help discover yourself. It's up to you and the GM how to handle the truth of your character's backstory. You could leave it to the GM so it's a secret, work together with the GM, or even choose to leave it undecided until later. In any case, you and your GM should determine a few noteworthy details about your character or their belongings to get the first clues to your past." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse("37b28056-f3d2-451d-a1d2-36b1f028dc91"));
            builder.GainAnyAbilityBoost(Guid.Parse("226d6030-32b5-44cf-a0f4-cffe805d53a3"));
            builder.GainAnyAbilityBoost(Guid.Parse("d4cd7a9a-13ae-40ce-800a-4a6c3f51466c"), isChosenByGameMaster: true);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f304cfa9-bdc2-448a-902b-cbf268f39d8c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 50
            };
        }
    }
}
