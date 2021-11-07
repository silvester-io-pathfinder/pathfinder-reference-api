using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AasimarsMercy : Template
    {
        public static readonly Guid ID = Guid.Parse("491dd67b-1fa4-4990-b037-f03b667c9e9a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aasimar's Mercy",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e8f6a46d-b17b-499d-a7e4-af0f0904d1b5"), Type = TextBlockType.Text, Text = "Your celestial powers allow you to remove lesser afflictions with ease. Each day, you can cast two 4th-level divine innate spells. You can choose from the following spells each time you cast: (spell: remove curse), (spell: remove disease), and (spell: neutralize poison)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d65689e-39fa-4fdb-8952-fff4be47764f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
