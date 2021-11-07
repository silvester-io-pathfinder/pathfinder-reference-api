using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArchonMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("1672db0d-e095-4ec3-beb5-23944a906a76");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Archon Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("87c4c9a6-3932-49f5-8508-19b812b61b42"), Type = TextBlockType.Text, Text = "You can tap into the heavenly magic that is your birthright. You can cast (spell: continual flame) and (spell: shield other) each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("088b1ea7-05ad-4270-a8f4-de9218d91b4c"), Feats.Instances.DoubleSlice.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8137317-3c9a-44cd-a951-e3503b42c45d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
