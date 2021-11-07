using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationPerfectFortification : Template
    {
        public static readonly Guid ID = Guid.Parse("dbbab626-22cd-4ccc-aa87-86fb3ac07928");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Perfect Fortification",
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
            yield return new TextBlock { Id = Guid.Parse("3a624863-23f1-4728-83f9-fcf3a045632c"), Type = TextBlockType.Enumeration, Text = "*Power Suit Only**" };
            yield return new TextBlock { Id = Guid.Parse("0fdd7951-71f9-4559-9184-205368f937c8"), Type = TextBlockType.Text, Text = "You’ve outfitted your armor with such heavy fortifications that deadly attacks often lose their edge. Each time you’re critically hit while wearing the armor, attempt a DC 13 flat check. On a success, it becomes a normal hit. This isn’t cumulative with fortification runes or other abilities that reduce critical hits with a flat check. Additionally, you gain resistance 2 + half your level against precision damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4b68b18-2573-49ff-8cb9-2e1fde0758f7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
