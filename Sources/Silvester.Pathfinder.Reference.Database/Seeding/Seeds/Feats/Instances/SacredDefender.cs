using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SacredDefender : Template
    {
        public static readonly Guid ID = Guid.Parse("5f23cd28-6c7e-4bd3-9f97-9277f57993a0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sacred Defender",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c5d3c9d4-86a4-4c5c-80d0-45dd244798f0"), Type = TextBlockType.Text, Text = "You are a great warrior that can stand strong against the fiercest opponents to your cause. You gain resistance 10 to bludgeoning, piercing, and slashing damage caused by creatures and effects opposed to your tenets (evil creatures for tenets of good, good creatures for tenets of evil, and so on). In addition, creatures and effects that roll a natural 20 on an attack roll against you don’t improve their result by one degree of success." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2e49e72-2977-4229-a06d-10841527db63"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
