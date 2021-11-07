using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatchTheDetails : Template
    {
        public static readonly Guid ID = Guid.Parse("393fd192-1674-4934-92e1-20f41d7d4fbb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Catch the Details",
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
            yield return new TextBlock { Id = Guid.Parse("a713945a-a0f5-47a9-9955-17c60b91d12e"), Type = TextBlockType.Text, Text = "You are quick at recognizing broad details about people and things around you. You are trained in Society and gain the (feat: Eye for Numbers) skill feat. If you would automatically become trained in Society (from your background or class, for example), you instead become trained in a skill of your choice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9cc56f2-9189-4c5b-8f29-bcc0b9ccbb75"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
