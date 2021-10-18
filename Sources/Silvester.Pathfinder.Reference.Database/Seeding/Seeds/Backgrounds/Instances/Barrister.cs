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
    public class Barrister : Template
    {
        public static readonly Guid ID = Guid.Parse("0d797e80-7909-4763-b5a9-6a3210198a14");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Barrister",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8c5eed0a-95e8-43e2-bbbd-a36634652b80"), Type = TextBlockType.Text, Text = "Piles of legal manuals, stern teachers, and experience in the courtroom have instructed you in legal matters. You're capable of mounting a prosecution or defense in court, and you tend to keep abreast of local laws, as you never can tell when you might need to know them on short notice." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("6821b7c0-9f25-4752-af7c-85a17d36f245"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("c1d01ef0-3566-420d-99d2-dcd82be6f9c5"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("e191d9c8-2070-43de-aca1-a1aa31e0f887"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("eee4d9a8-1796-4721-9f47-3fec542cf80e")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("8cd38388-5fa6-499e-9afd-eba7ce4d8ada"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Diplomacy.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("af95ceb4-8c9a-4251-8f7b-2c92de521bd8"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Legal.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("cb7a61d5-172d-447b-927b-c3b3a750cc46"),
                FeatId = Feats.General.GroupImpressionFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("328a6a3e-72bc-4fd6-9eb2-086604cb0344"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 60
            };
        }
    }
}
