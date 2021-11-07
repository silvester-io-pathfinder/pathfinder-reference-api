using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MindblankMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("f126e8f0-75da-4797-957e-1694378138a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mindblank Mutagen",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c0c5590-77a6-4f7e-9fd5-2295dae7deee"), Type = TextBlockType.Text, Text = "With a minor adjustment of ratios in the formula for your serene mutagen, you gain mental protections. When you’re affected by a serene mutagen, detection, revelation, and scrying effects of 9th level or lower detect nothing from you or your possessions and auras. For instance, (spell: detect magic) would still detect other magic in the area, but not any magic on you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b82441ca-e3a3-4857-9d11-55a53de448ba"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
