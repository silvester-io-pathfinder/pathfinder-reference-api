using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SurfaceCulture : Template
    {
        public static readonly Guid ID = Guid.Parse("baba5e0c-b02c-4809-907d-4c0eee483a2b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surface Culture",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("22679568-0429-4121-a574-35360629df7c"), Type = TextBlockType.Text, Text = "~ Access: any surface dwarf ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("bbc7a87a-39a1-4457-9299-55f7d5ec1485"), Type = TextBlockType.Text, Text = "Your interactions with other cultures on the surface have not only taught you about many other ancestries, but have also helped you realize the value of your own. You gain the trained proficiency rank in the Society skill (or another skill of your choice if you were already trained in Society), and you gain the (feat: Additional Lore) skill feat for the Lore corresponding to your culture (for instance, Ouat Lore or Pahmet Lore)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5b05f7a-cc76-4a06-926e-f9dbe8fb7e93"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
