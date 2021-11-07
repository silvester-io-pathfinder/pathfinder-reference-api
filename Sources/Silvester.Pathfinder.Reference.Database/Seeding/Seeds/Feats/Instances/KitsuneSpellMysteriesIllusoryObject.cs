using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KitsuneSpellMysteriesIllusoryObject : Template
    {
        public static readonly Guid ID = Guid.Parse("8f805370-5b11-46ae-baad-2c562751f572");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kitsune Spell Mysteries - Illusory Object",
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
            yield return new TextBlock { Id = Guid.Parse("1bec836b-f5a4-4e36-82e0-6f79d62381d8"), Type = TextBlockType.Text, Text = "You can cast (spell: illusory object) as a 1st-level divine innate spell once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("26522459-96f2-42f8-859f-23671a08bcb9"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
