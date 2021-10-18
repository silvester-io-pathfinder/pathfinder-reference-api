using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Sailor : Template
    {
        public static readonly Guid ID = Guid.Parse("a2df4965-424b-44e6-9993-737c1630645b");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Sailor",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f1067b4a-f067-417e-a26a-2514df0b039d"), Type = TextBlockType.Text, Text = "You heard the call of the sea from a young age. Perhaps you signed onto a merchant's vessel, joined the navy, or even fell in with a crew of pirates and scalawags." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("e33d5706-3a8f-4934-8ef4-f77278a15c2b"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("8f4936ec-e265-4470-b7b0-4a3a5d8fd75b"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("5baa1c8b-8161-494e-a3dc-25c05c0b8f2c"), StatId = Stats.Instances.Dexterity.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("ed8fe697-89d1-43d1-b1a1-2cd08df85aa4")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("0646a7c1-7c66-4358-9f86-3d1bd71175a2"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Athletics.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("ca20b481-4ad7-4d97-801e-87fc3c61fac1"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Sailing.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("93db73b4-b46d-4a20-83f4-c057e80dd0a8"),
                FeatId = Feats.General.UnderwaterMarauderFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("573aa7b3-aa70-4223-876a-02f9a68c905c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 63
            };
        }
    }
}
