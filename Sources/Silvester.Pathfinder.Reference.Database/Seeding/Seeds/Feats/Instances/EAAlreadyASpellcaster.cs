using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EAAlreadyASpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("a712ffd6-b3ee-4f68-b8b5-93207b75c684");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "EA - Already a Spellcaster",
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
            yield return new TextBlock { Id = Guid.Parse("2853baa8-8117-4e18-86b6-e7c03013902f"), Type = TextBlockType.Text, Text = "You learn one additional cantrip from your spellcasting tradition. This cantrip must require a spell attack roll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0acc7084-7154-4ed8-b083-0f9e9b0ed07b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
