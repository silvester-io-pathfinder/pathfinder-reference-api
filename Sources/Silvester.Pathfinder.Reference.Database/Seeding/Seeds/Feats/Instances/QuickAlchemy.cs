using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickAlchemy : Template
    {
        public static readonly Guid ID = Guid.Parse("c333837a-3ed8-4866-ba14-7b0b23d17755");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Alchemy",
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
            yield return new TextBlock { Id = Guid.Parse("88de13ea-3ec1-4773-868e-a2867557a82f"), Type = TextBlockType.Text, Text = "You gain the (feat:lvl--1: Quick Alchemy) action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("218319ef-9820-4513-bade-6d6ed146dda2"), Feats.Instances.AlchemistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e47bd0c1-7f87-487a-8d92-a27d17b404a0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
