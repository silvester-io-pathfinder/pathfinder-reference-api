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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("012ea429-2d2c-4d3a-aff8-10b220236562"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("73087fce-5280-4ede-83d1-c39a0809bb44"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("432a97a6-7e6f-4424-b87d-0cf3cdca4852"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("871d1903-6f1f-4cc3-a3c5-ac69e59c357e")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("c2ce259e-caba-4e2d-9485-da9e3dc19e32"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Society.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("92697af9-2d98-404e-8483-48f4c0fc9206"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Accounting.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("6df8f029-857d-4062-ab81-df2b0f3a768d"),
                FeatId = Feats.General.EyeForNumbersFeat.ID
            };
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
