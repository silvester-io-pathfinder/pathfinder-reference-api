using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class VineLeshy : Template
    {
        public static readonly Guid ID = Guid.Parse("f1b706ab-a12d-4142-9c40-8160a2d7b4b6");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Vine Leshy"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2c145c33-c7d4-4c46-9f5d-6b0cc830fed8"), Type = TextBlockType.Text, Text = "The prehensile vines woven into your body grant you unmatched skill at climbing. You do not need to have any hands free to Climb. Additionally, if you roll a success on an Athletics check to Climb, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("76354be0-38dc-47ab-8ccc-2faa48652210"), "You do not need to have any hands free to Climb.");
            builder.ImproveSpecificSkillSpecificSkillActionCheck(Guid.Parse("1fc31cd9-ccb4-4edb-a2db-5c60e4aee50e"), Skills.Instances.Athletics.ID, SkillActions.Instances.Climb.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3658e9e-160e-4c3d-aa09-5dc8bf7b996c"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 53
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Leshy.ID;
        }
    }
}
