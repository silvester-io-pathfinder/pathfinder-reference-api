using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StrandStrider : Template
    {
        public static readonly Guid ID = Guid.Parse("177a94c4-2710-42cb-8785-ff0832f90f7f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Strand Strider",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a8c89572-4f39-4916-a14f-12d05232b95d"), Type = TextBlockType.Text, Text = "Your eight legs serve you well when climbing walls and webs alike. You gain a climb speed of 25 feet in your spider shape." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91fda4a4-4066-440a-973f-d6e8bac8e331"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
