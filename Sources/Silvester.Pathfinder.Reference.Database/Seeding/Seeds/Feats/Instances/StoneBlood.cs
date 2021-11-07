using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StoneBlood : Template
    {
        public static readonly Guid ID = Guid.Parse("331fd93d-887f-4068-9b39-1fd8287b115f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stone Blood",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa1b66a2-219a-4ff3-90e1-6bd431c9ae0c"), Type = TextBlockType.Text, Text = "You can selectively stop your bleeding with ease. Reduce the DC of flat checks to stop persistent bleed damage you have from 15 to 10, and you can use a single action that has the (trait: concentrate) trait to gain an early flat check without physically binding the wounds. You recover naturally from the drained condition twice as quickly as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("14d2e704-0a99-4310-acf2-fb1edb6e14f3"), Feats.Instances.KaStoneRitual.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("74eb2ce7-f7de-44ea-9f1b-d12d4b7bb877"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
