using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Bookkeeper : Template
    {
        public static readonly Guid ID = Guid.Parse("f230a6e8-e0b8-4dfd-bcaa-c3a592126708");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Bookkeeper",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c07e09c4-e3da-4d32-b5f9-43bd5aa46575"), Type = TextBlockType.Text, Text = "You ran the numbers on a large farm, for a merchant's endeavors, or with a major guild in the city. You kept track of expenses, payroll, profits, and anything else that had to do with money, for better or worse. If better, you might be adventuring to learn how others ply this trade. If worse, you may be fleeing from impending consequences, in the hope that no one finds you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("e764dca7-89f3-486a-a919-9950e8a1feb9"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("b870fc9d-5bb1-48f8-a05d-5fbdf3f4e3dc"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("09dca11d-f9ad-4230-808a-f7cb880bba41"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("c2aa991c-616c-491e-824a-d3e17c085239"));
            builder.GainSpecificSkillProficiency(Guid.Parse("9b6ac58e-4cf5-492e-a50c-26a9212ec10f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("5547e8a0-045a-46cd-a2f5-351b42a0de3b"), Proficiencies.Instances.Trained.ID, Lores.Instances.Accounting.ID);
            builder.GainSpecificFeat(Guid.Parse("1c04dc17-8f3a-47f2-84d3-46ce6a2c85b9"), Feats.Instances.EyeForNumbers.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49011032-1a37-4b2d-bbf1-71d5b631522a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 48
            };
        }
    }
}
