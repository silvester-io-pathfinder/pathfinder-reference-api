using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WildShape : Template
    {
        public static readonly Guid ID = Guid.Parse("7a0bed1b-6088-4360-8167-912416016702");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wild Shape",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c3a2ec0c-fbcd-4f0f-ba3d-5c28e80be875"), Type = TextBlockType.Text, Text = "You are one with the wild, always changing and adapting to meet any challenge. You gain the (Spell: wild shape) order spell, which lets you transform into a variety of forms that you can expand with druid feats." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("c844253a-27d7-49af-872f-867550db5ecb"), DruidicOrders.Instances.Wild.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d37a6ad-01ef-4956-baca-984e0a5c4595"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
