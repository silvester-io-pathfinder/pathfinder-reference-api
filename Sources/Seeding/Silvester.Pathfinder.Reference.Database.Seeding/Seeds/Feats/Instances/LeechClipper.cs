using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeechClipper : Template
    {
        public static readonly Guid ID = Guid.Parse("8a05e6dd-c7e5-4081-930e-ed5b74792794");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Leech-Clipper",
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
            yield return new TextBlock { Id = Guid.Parse("89a99564-6b60-4ee9-b4c3-8fbdfebaffe2"), Type = TextBlockType.Text, Text = "You are trained to capture deserters, or “leeches.” If you critically hit a foe with a weapon from the flail weapon group, you can wrap the weapon around the target's legs and then drop it, causing the foe to take a -10-foot circumstance penalty to their Speeds until they or their allies disentangle the weapon, which takes a total of 2 (Action: Interact) actions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("495d33d0-f58f-4937-b8dc-ed81dd82409f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
