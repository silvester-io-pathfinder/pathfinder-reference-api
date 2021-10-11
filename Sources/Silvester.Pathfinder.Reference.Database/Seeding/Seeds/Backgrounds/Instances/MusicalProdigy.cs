using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class MusicalProdigy : Template
    {
        public static readonly Guid ID = Guid.Parse("fd60762c-229a-471d-b8f6-8756a09e7600");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Musical Prodigy",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("06904552-eed4-4e02-8818-cd9647c42ab3"), Type = TextBlockType.Text, Text = "Ever since you were young, you've been almost supernaturally skilled in a particular type of music. The people around you were sure you'd grow up to perform at royal courts or to become a world-famous composer, but you've chosen a life of adventure instead. You might have given up on those dreams to find your own meaning, or you might find that adventuring allows you to experience unfiltered emotions and exploits that you can translate into a wondrous symphony some day." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("26ed0a3e-ef8a-46e2-9515-363ec40e98d2"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("2d057baf-5a18-4451-aeb3-1c41e3a6ecea"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("16445f7a-9484-40cb-b496-8457d9ce1977"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("095b49c7-aeaf-4a91-ac23-7ea30a9c3374")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("8d2918fb-65a9-41af-b9fa-bdf5e55a6ac0"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Performance.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("a9bfac18-4300-44f9-bb18-8cbf14a9e290"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Music.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("619a5e97-3cfb-447c-9638-322cac40a95d"),
                FeatId = Feats.General.VirtuosicPerformerFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88881cae-2128-438a-bdd9-1d791e54d813"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 29
            };
        }
    }
}
