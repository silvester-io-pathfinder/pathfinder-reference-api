using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Constrict : Template
    {
        public static readonly Guid ID = Guid.Parse("da7d48ef-d1da-4104-badf-0724c1e48857");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Constrict",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9028021e-9c4a-4348-8754-c44758767e03"), Type = TextBlockType.Text, Text = "The snake deals 12 bludgeoning damage to the grabbed creature; the creature must attempt a basic Fortitude save. If the snake is a specialized animal companion, increase this damage to 20." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("075862c8-8524-4698-a798-f75ae9a659f0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
