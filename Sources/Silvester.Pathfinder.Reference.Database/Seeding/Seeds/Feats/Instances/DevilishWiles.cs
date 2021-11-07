using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DevilishWiles : Template
    {
        public static readonly Guid ID = Guid.Parse("9091959f-cb51-4443-9fd4-8bd425b54411");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Devilish Wiles",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e225bd0a-bb09-4246-83c1-31bc0a4aead5"), Type = TextBlockType.Text, Text = "Traditionally, fiends are exceptionally good at persuading people to do things, even when their targets know it’s a bad idea. You’re also rather good at it, compelling the weak and weak-willed to your bidding. You can cast (spell: charm) once per day as a 1st-level divine innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("779a9a9e-ee6d-4e19-b38c-475f6bb3193a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
