using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class FarmHand : Template
    {
        public static readonly Guid ID = Guid.Parse("2df19a79-1c57-4780-910d-98bab87d5430");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Farm Hand",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("94f153aa-e76d-4c57-a2cd-ec4b032349e7"), Type = TextBlockType.Text, Text = "With a strong back and an understanding of seasonal cycles, you tilled the land and tended crops. Your farm could have been razed by invaders, you could have lost the family tying you to the land, or you might have simply tired of the drudgery, but at some point you became an adventurer." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("74b65571-9424-494c-95ee-418245eaeee9"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("1e484dc3-2bd6-47d5-9f7b-fdeff1622e8c"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("c0f61d7f-0333-41f0-a1d7-cd9cc9f53bfb"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("b8e0d29c-daf2-4967-b4e9-50167d90e441")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("ee37a994-5387-456f-a6e2-ff8a9012defc"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Athletics.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("6fcd6f44-84ab-404a-8339-a532c2ca2eab"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Farming.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("d9eb77e7-d7a8-497d-8040-cd1dd155b004"),
                FeatId = Feats.General.AssuranceFeat.ID,
                Restrictions = "The Assurance skill feat should relate to the Athletics skill."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e8ad112-4ff2-4e13-aade-3b63ace1e4c4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
