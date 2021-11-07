using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WaxedFeathers : Template
    {
        public static readonly Guid ID = Guid.Parse("a5889489-a4a7-4125-bc74-e2b5f2f43d1e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Waxed Feathers",
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
            yield return new TextBlock { Id = Guid.Parse("6c632b3f-c3ee-4739-9f29-fa3013608eca"), Type = TextBlockType.Text, Text = "Your feathers are coated in a waxy substance that repels water. You gain a +1 circumstance bonus to saving throws against effects that have the (trait: water) trait. So long as you’re in a dry place, you can spend one action to shake off any water that clings to your clothing and feathers to instantly become dry." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("62adcaa7-4f7b-4237-a444-809189ec696e"), Heritages.Instances.WavediverTengu.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c45b7b41-5bc4-4038-81f8-2406c2c27432"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
