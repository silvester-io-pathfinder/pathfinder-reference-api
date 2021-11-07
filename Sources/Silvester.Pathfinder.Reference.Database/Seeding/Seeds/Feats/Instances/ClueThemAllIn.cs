using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClueThemAllIn : Template
    {
        public static readonly Guid ID = Guid.Parse("8fd56c7f-1f3e-4f50-87a1-dfda7b2fe37d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clue Them All In",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aaba6306-4ae9-4104-9a58-4694fe58275e"), Type = TextBlockType.Text, Text = "You can clue in all your allies at once. When you use the (feat: Clue In) reaction, any of your allies who are attempting the same check to investigate a lead receive the circumstance bonus from (feat: Clue In). If you use this ability during an encounter, they must attempt their check within 1 round of when you (feat: Clued them In | Clue In)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e4e403dd-ab6f-43d7-a72e-c80f0742aa33"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
