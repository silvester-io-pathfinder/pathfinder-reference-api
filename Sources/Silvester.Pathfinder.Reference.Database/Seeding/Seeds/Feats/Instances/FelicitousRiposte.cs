using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FelicitousRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("082bcd0a-84f7-4ba3-85db-f7a85edf419b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Felicitous Riposte",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c80a3d07-785c-48dd-b9a6-d88333509730"), Type = TextBlockType.Text, Text = "You take advantage of your foe’s openings with uncanny odds. When you make an (feat: Opportune Riposte), roll twice on the attack roll and take the better result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b924198a-af4c-408c-9a3f-b057a8459a0c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
