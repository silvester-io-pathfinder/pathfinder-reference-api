using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EerieCompression : Template
    {
        public static readonly Guid ID = Guid.Parse("e414fdce-fe80-411b-8f1a-c26a67260b94");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eerie Compression",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("341be5f6-d21f-4fba-a2e3-8a4313aa7c6b"), Type = TextBlockType.Text, Text = "Your limbs and even your torso can collapse in on themselves, allowing you to fit through tight spaces as though you were a Small creature. You can move at full Speed while (action: Squeezing | Squeeze)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ced6e542-58cd-4ddd-916f-e178ce6bdfc3"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
