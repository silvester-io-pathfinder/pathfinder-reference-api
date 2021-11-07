using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EAOccultSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("ece364f8-3576-483a-aea2-e24cf009cfa3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "EA - Occult Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("5c6189c9-b649-4ca6-a194-c0b3782529bc"), Type = TextBlockType.Text, Text = "You’re trained in occult spell attack rolls and spell DCs. Your key spellcasting ability is Charisma. Add an occult cantrip that requires a spell attack roll to your spell repertoire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa432d3a-ec3c-4501-9a65-7e514702a1dc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
