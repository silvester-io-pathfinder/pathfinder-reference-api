using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KoboldBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("38ba6e54-faf5-446f-a918-166084faa05d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kobold Breath",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d00d697f-e6b6-4345-8639-5110bcaea47b"), Type = TextBlockType.Text, Text = "You channel your draconic exemplar's power into a gout of energy that manifests as a 30-foot line or a 15-foot cone, dealing 1d4 damage. Each creature in the area must attempt a basic saving throw against the higher of your class DC or spell DC. You can't use this ability again for 1d4 rounds." };
            yield return new TextBlock { Id = Guid.Parse("3151956b-3876-4d29-bd68-34e7baee05bf"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, the damage increases by 1d4. The shape of the breath, the damage type, and the saving throw match those of your draconic exemplar. This ability has the trait associated with the type of damage it deals." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f65007cb-fb7a-4b3f-a7d4-9cc399a55aba"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
