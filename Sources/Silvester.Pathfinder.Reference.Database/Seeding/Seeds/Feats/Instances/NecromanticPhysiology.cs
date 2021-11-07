using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NecromanticPhysiology : Template
    {
        public static readonly Guid ID = Guid.Parse("2534c561-44dc-48ef-b936-8bf0c4228a5c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Necromantic Physiology",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b1c83fd8-2426-4678-b50b-364c51369563"), Type = TextBlockType.Text, Text = "Your unusual physiology has developed in a way that makes it difficult for parasites and other infestations to prey upon you. You gain a +2 circumstance bonus to saves against diseases." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae19a4df-10af-4e12-a2db-ca54f2cf9b0b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
