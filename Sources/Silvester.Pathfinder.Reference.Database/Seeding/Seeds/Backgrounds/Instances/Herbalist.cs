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
    public class Herbalist : Template
    {
        public static readonly Guid ID = Guid.Parse("34b36070-ff49-4d02-924e-67d7459e5007");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Herbalist",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a4c2b312-60d0-461e-911d-9118d0deba87"), Type = TextBlockType.Text, Text = "As a formally trained apothecary or a rural practitioner of folk medicine, you learned the healing properties of various herbs. You're adept at collecting the right natural cures in all sorts of environments and preparing them properly." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("562642a5-3026-4e29-a332-8e27ad74589b"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("a88faf6c-bf8a-4d85-addc-f57515e85a05"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("443ca611-c591-4e68-824c-cfa7bca0f9c0"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("ef717988-2cf1-4cf2-b2d4-e76b033803fb")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("54474ca5-e512-49e0-b959-536a29281ac8"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Nature.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("dbad3416-10bb-4b31-94f5-761312b4cc3e"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Herbalism.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("019f52a4-070c-43d6-b626-10dd561590b4"),
                FeatId = Feats.General.NaturalMedicineFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f209f713-7e88-40a4-90ce-6b279884784a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
