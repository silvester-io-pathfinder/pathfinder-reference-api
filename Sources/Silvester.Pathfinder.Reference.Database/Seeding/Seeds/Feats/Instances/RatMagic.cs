using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RatMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("463e74f6-58c9-4e26-b880-971b7438aa01");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rat Magic",
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
            yield return new TextBlock { Id = Guid.Parse("c6ed6376-6f07-4c0d-9e45-bc8672b8e149"), Type = TextBlockType.Text, Text = "There always seems to be a little rat around to carry messages for you. You can cast (spell: animal messenger) once per day as a primal innate spell. When you do, the animal that responds is always a rat. If there are no rats within range, the spell is lost." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d052b83-2b46-4e5c-9df0-f2f7389b95fb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
