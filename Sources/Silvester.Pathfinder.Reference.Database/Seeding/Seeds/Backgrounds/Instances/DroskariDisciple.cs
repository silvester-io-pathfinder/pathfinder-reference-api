using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class DroskariDisciple : Template
    {
        public static readonly Guid ID = Guid.Parse("99c9ba97-c42f-478d-aee1-2dffd37194ed");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Droskari Disciple",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("058cc227-1a31-4500-825d-dcdb2079b171"), Type = TextBlockType.Text, Text = "You grew up in the church of the Dark Smith, where you learned the value of hard work and achieving vocational mastery." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("742eca96-5ccf-4b58-ab45-9585c9f34408"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("e3f98617-fa16-46e1-b179-4eeea2a2c95b"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("3166830e-5f89-449b-ae35-a9428dc13cdc"), StatId = Stats.Instances.Intelligence.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("2653def8-1c50-4ad2-8734-b2cca68e137b")
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("3c3982f9-d3ba-4c58-b707-df67416096ec"),
                FeatId = Feats.General.SkillTrainingFeat.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("8006903f-d56d-44a7-aecf-e5efa6a3fdd1"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Droskar.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f386e3dd-7014-4530-b0ac-225b3c2b2cad"),
                SourceId = Sources.Instances.Pathfinder148.ID,
                Page = 65
            };
        }
    }
}
