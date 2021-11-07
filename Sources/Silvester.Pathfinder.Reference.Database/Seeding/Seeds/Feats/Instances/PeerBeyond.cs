using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PeerBeyond : Template
    {
        public static readonly Guid ID = Guid.Parse("79efe52f-2704-459d-aca3-79ae82e6f795");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Peer Beyond",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c4a390a5-a479-4a2e-9ad2-570da29f914b"), Type = TextBlockType.Text, Text = "You have uncanny insight into the way ghosts and haunts manifest, manipulate the mind, and rejuvenate. You gain a +2 circumstance bonus to saving throws against (trait: mental) effects caused by incorporeal undead and haunts, and you can roll a Spirit Lore or Haunt Lore check for initiative if you know that an incorporeal undead or a haunt is present." };
            yield return new TextBlock { Id = Guid.Parse("a3b95b92-a500-4cba-b880-d9587e862311"), Type = TextBlockType.Text, Text = "If you are present when a spirit or haunt is defeated, you instantly gain a flash of insight into how it can be permanently put to rest. Typically, this flash manifests as a vision that presents a quick scene closely linked to the source of the spirit or haunt&#39;s creation. Attempt a Spirit Lore or Haunt Lore check, respectively, with a DC appropriate for the spirit or haunt&#39;s level. On a success, you gain a hint about how to put the spirit to rest or permanently disable the haunt; on a critical success, you learn the exact method of doing so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1034dc86-665c-46b3-ba7c-35eedcd6b51b"), Feats.Instances.GhostHunterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03bc4ccf-eccb-4c16-a16f-61d8c72cb556"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
