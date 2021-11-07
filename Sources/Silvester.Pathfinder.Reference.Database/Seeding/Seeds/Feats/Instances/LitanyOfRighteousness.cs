using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LitanyOfRighteousness : Template
    {
        public static readonly Guid ID = Guid.Parse("dfe2d2cb-b171-4b58-a6d7-3d28c60c5c41");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Litany of Righteousness",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0fce5e93-61bc-4400-bf3d-564ea0c234fe"), Type = TextBlockType.Text, Text = "You call upon righteousness to expose an evil foe’s weakness. You can cast the (spell: litany of righteousness) devotion spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("a1d480c5-0d59-47f0-9f6f-7d0f4cd14891"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b15f516-d661-480d-9629-f8cf6560a80d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
