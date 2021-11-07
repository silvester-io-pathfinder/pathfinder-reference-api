using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationEnhancedDamage : Template
    {
        public static readonly Guid ID = Guid.Parse("a76b1700-bd08-461b-9bc8-ce633209ebfc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Enhanced Damage",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f510e2f-41ce-4ddf-9988-33450285e832"), Type = TextBlockType.Text, Text = "You’ve made your innovation more powerful than other weapons of its kind. Increase your innovation’s weapon damage die by one step (d4 to d6, d6 to d8, d8 to d10, d10 to d12). As normal, you can’t increase your die by more than one size, so this modification isn’t cumulative with (feat: complex simplicity | Modification - Complex Simplicity)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("deba223f-0efe-4135-9d99-b0eac1473ea6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
