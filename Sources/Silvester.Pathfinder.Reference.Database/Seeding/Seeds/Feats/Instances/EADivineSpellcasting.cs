using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EADivineSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("5bc536e6-d4d0-44a7-8238-26bfc907bbfd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "EA - Divine Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("65a17235-561d-40ac-b45a-2bca8d44a2ff"), Type = TextBlockType.Text, Text = "You’re trained in divine spell attack rolls and spell DCs. Your key spellcasting ability is Charisma. Add a divine cantrip that requires a spell attack roll to your spell repertoire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75c79c67-be38-487e-b89b-39548b1efb56"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
