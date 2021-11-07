using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HealingGrace : Template
    {
        public static readonly Guid ID = Guid.Parse("1fcac2e9-5563-4fa0-91ea-22ebc4a7e5fa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Healing Grace",
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
            yield return new TextBlock { Id = Guid.Parse("6e685c23-213e-48ee-b116-f7172b852c0a"), Type = TextBlockType.Text, Text = "You gain fast healing equal to half your level. You can cast (spell: heal) once as an innate spell with a level equal to half your level rounded up." };
            yield return new TextBlock { Id = Guid.Parse("ad10aaec-8356-4b47-9ab3-83c9cf7ab381"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ Reduce all healing you would receive or grant with a spell by half your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af2beac4-c6e9-4a9f-b898-bb947beb0eec"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
