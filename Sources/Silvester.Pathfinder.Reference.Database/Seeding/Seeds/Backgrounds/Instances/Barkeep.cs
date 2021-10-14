using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Barkeep : Template
    {
        public static readonly Guid ID = Guid.Parse("22e6e5d5-2489-4d75-ab44-8eed23e5cf9b");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Barkeep",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5c99fef7-4af0-4120-9fc2-f83c2565d5e4"), Type = TextBlockType.Text, Text = "You have five specialties: hefting barrels, drinking, polishing steins, drinking, and drinking. You worked in a bar, where you learned how to hold your liquor and rowdily socialize." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("b1cf2e96-633f-44d2-b3e4-835b3120f13d"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("127f4366-2b8e-48d9-ba2d-2d637bf8d532"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("a6af9285-e130-4747-9a8a-3a86b382737a"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("8d5e91e3-0d06-4317-ae26-08fec3f10ea9")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("b3aca7f2-a0e6-4807-afd3-3d601f4471e2"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Diplomacy.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("7e35e28f-e325-4dd4-9aaf-4578146135a8"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Alcohol.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("1e416c1d-85d8-45b4-add5-0c038ce39eaa"),
                FeatId = Feats.General.HobnobberFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90739f5b-2a98-4011-92d3-571d04dcabdb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 60
            };
        }
    }
}
