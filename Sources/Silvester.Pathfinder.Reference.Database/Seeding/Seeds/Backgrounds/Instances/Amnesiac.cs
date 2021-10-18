using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("e1d7514f-efce-4e2a-8517-09949a2d9d38")
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("bea20cd3-1348-4fdf-aa3f-a523d731aebd")
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("22cef4ec-31ce-462b-af32-715516875930"),
                IsChosenByGameMaster = true
            };
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
