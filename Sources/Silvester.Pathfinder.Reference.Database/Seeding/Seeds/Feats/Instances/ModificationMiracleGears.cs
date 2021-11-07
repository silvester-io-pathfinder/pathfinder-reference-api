using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationMiracleGears : Template
    {
        public static readonly Guid ID = Guid.Parse("43220d9e-efc9-4662-aa47-45b6bf699a31");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Miracle Gears",
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
            yield return new TextBlock { Id = Guid.Parse("2a08ec3a-cea0-4c4e-8748-126649ce1069"), Type = TextBlockType.Text, Text = "As you perfect your innovation’s cortex, it becomes much more intelligent. Its Intelligence modifier increases by 2, and it learns a language of your choice from among the languages you know. Your construct gains the ability to use actions that require greater Intelligence, like (action: Coerce) and (action: Decipher Writing). Finally, your construct becomes legendary in two Intelligence- or Charisma-based skills of your choice. You must have the (feat: marvelous gears | Modification - Marvelous Gears) modification to select this modification." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4c1db20-ae5e-4fda-95a8-0b8e970de894"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
