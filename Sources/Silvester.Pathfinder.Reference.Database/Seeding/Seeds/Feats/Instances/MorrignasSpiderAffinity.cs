using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MorrignasSpiderAffinity : Template
    {
        public static readonly Guid ID = Guid.Parse("5e203b1a-6b3e-4977-bb41-9b05944ea9f0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Morrigna's Spider Affinity",
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
            yield return new TextBlock { Id = Guid.Parse("e17db388-0c63-4aa5-8a23-4604e6bde64f"), Type = TextBlockType.Text, Text = "Much like morrignas, you feel an affinity for spiders. You can cast (spell: animal messenger) (spiders only), (spell: speak with animals) (spiders only), and (spell: spider climb) each once per day as 2nd-level divine innate spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c826008e-d639-49f8-9de3-edb446f2983f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
