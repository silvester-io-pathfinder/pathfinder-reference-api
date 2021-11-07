using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvokeDisaster : Template
    {
        public static readonly Guid ID = Guid.Parse("ad69144b-2285-4430-aa41-83b57cca6029");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Invoke Disaster",
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
            yield return new TextBlock { Id = Guid.Parse("f3f7789f-13c6-4f32-bb77-d777fb8bd34a"), Type = TextBlockType.Text, Text = "You can invoke nature’s fury upon your foes. You gain the (Spell: storm lord) order spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a6872e7e-d191-46ae-8c34-c2b2bf8b5a5d"), Feats.Instances.WindCaller.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("897c6348-e7c3-4151-a5cd-fff3a6914f24"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
