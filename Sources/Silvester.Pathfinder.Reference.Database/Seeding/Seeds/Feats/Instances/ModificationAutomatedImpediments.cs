using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationAutomatedImpediments : Template
    {
        public static readonly Guid ID = Guid.Parse("52dc0e39-6ccb-4fa2-888a-d8cd65dbd5c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Automated Impediments",
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
            yield return new TextBlock { Id = Guid.Parse("a7bbe682-be2b-45e3-a83b-f314a6e78530"), Type = TextBlockType.Text, Text = "Your armor uses electromagnetic fields, subharmonic distortions, or other techniques to make it difficult for those close to you to move unless you allow it. While wearing your armor, all spaces adjacent to you are difficult terrain for your enemies." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3df90a85-d67f-4bbd-b481-b77aed3a1cdf"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
