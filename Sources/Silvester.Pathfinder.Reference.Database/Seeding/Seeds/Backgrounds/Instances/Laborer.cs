using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Laborer : Template
    {
        public static readonly Guid ID = Guid.Parse("fc6fa118-2f62-4600-87de-ff881236b29f");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Laborer",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0b058dfd-f5e0-45c1-aaf7-5dd51f8394d6"), Type = TextBlockType.Text, Text = "You�ve spent years performing arduous physical labor. It was a difficult life, but you somehow survived. You may have embraced adventuring as an easier method to make your way in the world, or you might adventure under someone else�s command." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("050aa7ba-125d-4983-a59d-c8dee32af979"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("80f59d8e-d7cf-4b77-b728-32b96909b7b5"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("bdde0f2c-94d4-41e0-9972-6df78d5349ef"), StatId = Stats.Instances.Constitution.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("d94fbaf8-3262-41f7-8ede-4ad245206b5a")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("30119159-2206-4255-96ee-4bc09dc225b0"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Athletics.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("61c6ac36-4267-40a2-af66-df2528a94b7a"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Labor.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("a7ddff7c-5997-4036-be17-6ff507a6b479"),
                FeatId = Feats.General.HeftyHaulerFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6562c03-1505-4aab-9a62-ddc77450c696"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
