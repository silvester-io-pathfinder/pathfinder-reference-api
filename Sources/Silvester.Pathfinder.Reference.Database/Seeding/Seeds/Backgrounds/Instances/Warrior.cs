using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Warrior : Template
    {
        public static readonly Guid ID = Guid.Parse("8db4cff6-1fe2-4152-800f-26bfb1596620");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Warrior",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("870c5ad8-f4a2-4762-a6a4-75507b21b614"), Type = TextBlockType.Text, Text = "In your younger days, you waded into battle as a mercenary, a warrior defending a nomadic people, or a member of a militia or army. You might have wanted to break out from the regimented structure of these forces, or you could have always been as independent a warrior as you are now." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("4d8703eb-1d1c-48e6-9ae7-52b534af6bc3"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("706b2f65-2e5d-4930-803e-e997a310d8cc"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("27998c26-2cc3-4fb3-b2b7-5e335db513e5"), StatId = Stats.Instances.Constitution.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("efc79615-a332-495a-a835-c6b60ba759df")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("e1d1f581-b9e8-4f30-a861-e39fb49838bc"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Intimidation.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("f730e212-441e-4df9-9e94-b61dab07ae92"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Warfare.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("cf395532-9b68-4832-b174-19b53bc0cdb7"),
                FeatId = Feats.General.IntimidatingGlareFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c002d8dc-ca50-4bca-a303-854137d9ea1b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 64
            };
        }
    }
}
