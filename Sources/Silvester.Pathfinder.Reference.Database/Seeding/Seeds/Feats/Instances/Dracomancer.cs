using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Dracomancer : Template
    {
        public static readonly Guid ID = Guid.Parse("f789089b-6ecc-4f69-aef4-482a8210840e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dracomancer",
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
            yield return new TextBlock { Id = Guid.Parse("dd78733d-daff-4df3-b6d6-b2e218d39abf"), Type = TextBlockType.Text, Text = "Your inborn arcane power manifests as your exemplar&#39;s most time-honored spells. Choose one 1st-level spell and one 2nd-level spell from those listed for a dragon spellcaster of your draconic exemplar&#39;s type (such as (spell: alarm), (spell: blur), (spell: invisibility), and (spell: true strike) for a black dragon exemplar). You can cast each of these spells once per day as arcane innate spells. You gain the trained proficiency rank in arcane spell attack rolls and spell DCs, and your key spellcasting ability is Charisma." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f414166f-3122-4807-b7da-20a9208429ef"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
