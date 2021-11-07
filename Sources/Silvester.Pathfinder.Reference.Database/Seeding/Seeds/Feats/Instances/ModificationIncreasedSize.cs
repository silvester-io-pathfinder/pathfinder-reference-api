using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationIncreasedSize : Template
    {
        public static readonly Guid ID = Guid.Parse("6db5079f-c4f9-4c13-a5b6-2a1eba76dc89");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Increased Size",
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
            yield return new TextBlock { Id = Guid.Parse("c6c63b20-e4e0-42ad-810d-2e092d92629c"), Type = TextBlockType.Text, Text = "You built your construct innovation bigger than most. Your construct is Large. If you have this modification and your construct innovation becomes an advanced construct companion or otherwise gains the ability to become Large, you can immediately change increased size to a different initial construct modification." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fdd955f1-1b1b-4434-9555-4d8b02432dc7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
