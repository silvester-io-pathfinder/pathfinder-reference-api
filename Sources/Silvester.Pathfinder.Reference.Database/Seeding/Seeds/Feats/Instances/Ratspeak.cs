using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Ratspeak : Template
    {
        public static readonly Guid ID = Guid.Parse("868c4ad3-9c92-499f-841e-f7e402daccdf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ratspeak",
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
            yield return new TextBlock { Id = Guid.Parse("27ec2c5d-fb0e-42f1-a9e0-441e8813f0a6"), Type = TextBlockType.Text, Text = "To you, the squeaking of rats and other rodents makes a strange kind of sense. You can ask questions of, receive answers from, and use the Diplomacy skill with rodents, including beavers, mice, porcupines, rats, and squirrels, but not with other mammals, such as dogs or bats. The GM determines which animals count as rodents." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49bf2d3d-5459-4ef6-b517-4c5960066977"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
