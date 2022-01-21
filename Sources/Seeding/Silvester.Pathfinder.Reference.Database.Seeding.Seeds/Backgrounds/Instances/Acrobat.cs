using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Acrobat : Template
    {
        public static readonly Guid ID = Guid.Parse("f7a99adb-1eb1-4802-a00d-d19c0ecf87bf");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Acrobat",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9171095f-f771-42d7-a4dd-95f4f72c50c0"), Type = TextBlockType.Text, Text = "In a circus or on the streets, you earned your pay by performing as an acrobat. You might have turned to adventuring when the money dried up, or simply decided to put your skills to better use." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("2f57e5f3-9da4-4da3-8322-8179ccd8e0b0"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("34b3a368-f337-4bdb-8235-0d31b9e35b38"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("ad5372fb-bef1-4785-be4c-21c6cf73a3ea"), Stats.Instances.Dexterity.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("17570eb6-bb94-4864-8eac-4642de212b4e"));
            builder.GainSpecificSkillProficiency(Guid.Parse("75ad93d9-5d2a-4197-9dcc-01814465fcf1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("bc72d88b-4a61-41b8-a654-6387302ba9a5"), Proficiencies.Instances.Trained.ID, Lores.Instances.Circus.ID);
            builder.GainSpecificFeat(Guid.Parse("3119fbb0-58a6-4cac-b74e-a9c328e73ba1"), Feats.Instances.SteadyBalance.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2384ee7-6581-4872-b9d6-fe2e813fc332"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 60
            };
        }
    }
}
