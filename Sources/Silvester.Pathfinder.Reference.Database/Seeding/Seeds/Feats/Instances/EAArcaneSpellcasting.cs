using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EAArcaneSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("bd2d96ca-a228-409c-a8d3-50b53dce4f2f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "EA - Arcane Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("dc02a2ca-f5fc-47d6-9747-e12dcea27cf5"), Type = TextBlockType.Text, Text = "You’re trained in arcane spell attack rolls and spell DCs. Your key spellcasting ability is Charisma. Add an arcane cantrip that requires a spell attack roll to your spell repertoire." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3077f5b8-89cf-430c-befa-056266d7cbe2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
