using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class FortuneTeller : Template
    {
        public static readonly Guid ID = Guid.Parse("767109ae-2517-4a86-b871-aa6a45869a44");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Fortune Teller",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2814ad24-21f3-4620-af19-c1c2fe448924"), Type = TextBlockType.Text, Text = "The strands of fate are clear to you, as you have learned many traditional forms by which laypeople can divine the future. You might have used these skills to guide your community, or simply to make money. But even the slightest peek into these practices connects you to the occult mysteries of the universe." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("06200adb-34a4-4e4d-9d06-3655674514ff"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("84a1dc56-4161-4e3a-b37d-c5c8ef72aff3"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("ba510dd7-c59b-4f87-8776-f5d8fcfb048e"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("d347d1d5-bc78-4517-8100-92159ed43231")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("4a784f8a-43ea-40c5-b15b-2307023bf640"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Occultism.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("2b5912ce-2c21-4095-af39-4736405a8089"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.FortuneTelling.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("21644ca4-a5d2-440e-9354-c2cf5733c349"),
                FeatId = Feats.General.OddityIdentificationFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc9677df-f829-4d5c-a881-0d2382666a61"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
