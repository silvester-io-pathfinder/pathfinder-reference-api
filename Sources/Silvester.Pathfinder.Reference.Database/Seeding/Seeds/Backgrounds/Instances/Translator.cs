using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Translator : Template
    {
        public static readonly Guid ID = Guid.Parse("28e4cebf-f091-48d1-982f-5e25f154655b");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Translator",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5e84ab99-bcf9-4b52-ac9d-783f38685840"), Type = TextBlockType.Text, Text = "In your youth, you learned to transcribe books and translate scrolls to preserve knowledge or perhaps to aid wealthy merchants and politicians. Whether you set out to make your own fortune or are drawn to decipher the strangest codes, your linguistic training will guide your discoveries." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("3e76e2f5-66b2-42a3-b8f3-c157f12e3b12"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("5d87e585-3acb-49c8-93e4-04e0035ca561"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("41eef96e-42e3-4f4b-b82a-f9b6a1a0f6f3"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("4731684d-4304-4cda-859e-66bc9dfccfd8")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("271b0a1c-29ea-4586-a4a7-711411d7ed24"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Society.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("fce83b45-2a7e-49e3-857b-2309853ad038"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Scribing.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("8a722dd9-6514-43f2-9d9f-6763e882ad5c"),
                FeatId = Feats.General.MultilingualFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0fa367ec-2b5f-45dc-933b-cb7ebe83542b"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 6
            };
        }
    }
}
