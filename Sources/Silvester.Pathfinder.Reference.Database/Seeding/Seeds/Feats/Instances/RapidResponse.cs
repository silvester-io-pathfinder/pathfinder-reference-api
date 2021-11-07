using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RapidResponse : Template
    {
        public static readonly Guid ID = Guid.Parse("d707aa6e-79b5-42aa-a6fe-67614b135e32");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rapid Response",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally is reduced to 0 Hit Points.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("95d518dd-8a40-43bb-9c3f-9724e14f1c14"), Type = TextBlockType.Text, Text = "You work quickly and efficiently in times of danger to deliver needed assistance. You (action: Stride) towards the triggering ally. You gain a +10-foot circumstance bonus to your Speed during this movement." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a2e7867-0c19-4be0-8b52-7a0b68dafbb1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
