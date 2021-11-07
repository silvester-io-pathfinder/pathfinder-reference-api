using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RatFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("9e554949-3195-4a69-a297-9b035cc56b29");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rat Familiar",
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
            yield return new TextBlock { Id = Guid.Parse("8e1bdad6-8730-413e-a401-080d3d1740ad"), Type = TextBlockType.Text, Text = "You have a pet rat that has become magically bonded to you. You gain a familiar which must be a rat. It still gets the benefits of familiar abilities, but its base form remains a rat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd1a2671-b271-446d-b942-68b59481796e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
