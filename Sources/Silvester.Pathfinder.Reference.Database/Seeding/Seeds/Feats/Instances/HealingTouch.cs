using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HealingTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("1dd516c6-07c9-4c27-ba04-b2a252b5ef99");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Healing Touch",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c7a29023-a622-4a83-9056-007fe59f3671"), Type = TextBlockType.Text, Text = "You gain the appropriate devotion spell for your cause. If you don’t already have one, you gain a focus pool of 1 Focus Point, which you can (action: Refocus) by praying or serving your deity. (For more on devotion spells, see page 107.)" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("20c193d6-5c9e-47a6-bfbb-774e11601129"), Feats.Instances.ChampionDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc2deacb-9ad5-44d4-8fd8-1a1c34803684"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
