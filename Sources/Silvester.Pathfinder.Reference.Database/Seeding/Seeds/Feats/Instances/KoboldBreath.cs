using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KoboldBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("67f8a722-02ab-40d3-9701-8e51b2713a1b");

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
            yield return new TextBlock { Id = Guid.Parse("096834bf-287c-4c9d-a1fc-2e0c27e6a956"), Type = TextBlockType.Text, Text = "You channel your draconic exemplar&#39;s power into a gout of energy that manifests as a 30-foot line or a 15-foot cone, dealing 1d4 damage. Each creature in the area must attempt a basic saving throw against the higher of your class DC or spell DC. You can&#39;t use this ability again for 1d4 rounds." };
            yield return new TextBlock { Id = Guid.Parse("fc8d4529-477a-4336-b0bd-259f0fa4e3b3"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, the damage increases by 1d4. The shape of the breath, the damage type, and the saving throw match those of your draconic exemplar. This ability has the trait associated with the type of damage it deals." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2dda6e5e-761b-40a6-8690-dcebbab6f680"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
