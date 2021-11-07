using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeechClipper : Template
    {
        public static readonly Guid ID = Guid.Parse("360d339b-6001-4ae2-bb50-2da90cc62c35");

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
            yield return new TextBlock { Id = Guid.Parse("97e12c0a-7d0e-4cc7-9f2c-30e50106ad79"), Type = TextBlockType.Text, Text = "You are trained to capture deserters, or “leeches.” If you critically hit a foe with a weapon from the flail weapon group, you can wrap the weapon around the target’s legs and then drop it, causing the foe to take a -10-foot circumstance penalty to their Speeds until they or their allies disentangle the weapon, which takes a total of 2 (Action: Interact) actions." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95ce6677-5c05-481d-b62b-0d01534843b6"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
