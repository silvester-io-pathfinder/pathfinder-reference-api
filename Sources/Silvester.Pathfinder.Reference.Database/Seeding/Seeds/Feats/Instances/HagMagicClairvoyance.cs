using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HagMagicClairvoyance : Template
    {
        public static readonly Guid ID = Guid.Parse("bb39cace-2bf6-4de2-8084-d7fb49a92154");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hag Magic - Clairvoyance",
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
            yield return new TextBlock { Id = Guid.Parse("d1b2426d-1ee3-452d-b0ce-77ce221e3e9d"), Type = TextBlockType.Text, Text = "You can cast (spell: clairvoyance) once per day as a 4th-level occult innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b3ee55d-d6f7-4801-8520-ef41c2decb1b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
