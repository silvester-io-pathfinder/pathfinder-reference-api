using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarBlue : Template
    {
        public static readonly Guid ID = Guid.Parse("71ca76bb-e0e1-4ed8-aa9b-9d0e63af8b54");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Blue",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e9ac93c-0161-453a-8213-058198f8e8c5"), Type = TextBlockType.Text, Text = $"Your scale color and appearance resembles that of a blue dragon." };
            yield return new TextBlock { Id = Guid.Parse("27509693-16e4-48d7-a887-42e59d44d5cc"), Type = TextBlockType.Text, Text = $"~ Breath Weapon Shape: Line" };
            yield return new TextBlock { Id = Guid.Parse("a0d77286-6d87-4eb6-9dba-377239d05d35"), Type = TextBlockType.Text, Text = $"~ Damage Type: Electricity" };
            yield return new TextBlock { Id = Guid.Parse("9c3c6921-8a37-410b-995f-e6d6f02abb5a"), Type = TextBlockType.Text, Text = $"~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e2c6430-8f5e-4211-991c-efdc290ac190"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
