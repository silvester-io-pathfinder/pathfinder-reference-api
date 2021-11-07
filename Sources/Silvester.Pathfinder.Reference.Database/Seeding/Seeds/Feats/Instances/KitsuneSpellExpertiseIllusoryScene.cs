using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KitsuneSpellExpertiseIllusoryScene : Template
    {
        public static readonly Guid ID = Guid.Parse("928feeb2-81dd-4ffe-9c23-6d1880196e3f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kitsune Spell Expertise - Illusory Scene",
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
            yield return new TextBlock { Id = Guid.Parse("4478af3a-b405-4d0c-8bd6-f4dc8ec69afa"), Type = TextBlockType.Text, Text = "You can cast (spell: illusory scene) as a 5th-level divine innate spell once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13011280-d7be-4ecf-ad41-37cc37a720d2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
