using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MarshalDiplomacy : Template
    {
        public static readonly Guid ID = Guid.Parse("bd8535a4-ea7f-4de2-bf0c-62ca1174b05f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Marshal - Diplomacy",
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
            yield return new TextBlock { Id = Guid.Parse("9c945689-e0de-4414-ac84-aee6e6bc19cd"), Type = TextBlockType.Text, Text = "You become trained in Diplomacy or become an expert if you were already trained in it." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47d08379-b14f-4d97-b4a2-400f588222e0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
