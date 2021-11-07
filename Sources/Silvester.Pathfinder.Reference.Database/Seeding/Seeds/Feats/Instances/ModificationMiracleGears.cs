using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationMiracleGears : Template
    {
        public static readonly Guid ID = Guid.Parse("4cff276d-fe9c-4c3d-801d-063e9ce75377");

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
            yield return new TextBlock { Id = Guid.Parse("dc27bee1-87ff-4805-b385-79e6bed6a1f3"), Type = TextBlockType.Text, Text = "As you perfect your innovation’s cortex, it becomes much more intelligent. Its Intelligence modifier increases by 2, and it learns a language of your choice from among the languages you know. Your construct gains the ability to use actions that require greater Intelligence, like (action: Coerce) and (action: Decipher Writing). Finally, your construct becomes legendary in two Intelligence- or Charisma-based skills of your choice. You must have the (feat: marvelous gears | Modification - Marvelous Gears) modification to select this modification." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c7f93c0-0e52-423c-aae5-0140085d9245"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
