using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BeastmastersTrance : Template
    {
        public static readonly Guid ID = Guid.Parse("c38bf576-b996-42e9-a96d-b2ea2aa43979");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beastmaster's Trance",
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
            yield return new TextBlock { Id = Guid.Parse("b04aad40-91d5-40f9-8e43-566d0c15b3e0"), Type = TextBlockType.Text, Text = "You can enter a trance that allows you to briefly inhabit the body of one of your animal companions and share its senses. You gain the focus spell (spell: beastmaster trance). Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("712be6da-aacb-4c2b-8d63-2d7bf0c348a9"), Feats.Instances.BeastmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d644a52-a759-41a2-a149-db47985cd02c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
