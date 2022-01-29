using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PeerBeyond : Template
    {
        public static readonly Guid ID = Guid.Parse("3145eec1-47db-4d5e-b7b0-6dbb6f271b56");

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
            yield return new TextBlock { Id = Guid.Parse("67b9a8c3-c1de-4a01-abed-169445e79810"), Type = TextBlockType.Text, Text = $"You have uncanny insight into the way ghosts and haunts manifest, manipulate the mind, and rejuvenate. You gain a +2 circumstance bonus to saving throws against {ToMarkdownLink<Models.Entities.Trait>("mental", Traits.Instances.Mental.ID)} effects caused by incorporeal undead and haunts, and you can roll a Spirit Lore or Haunt Lore check for initiative if you know that an incorporeal undead or a haunt is present." };
            yield return new TextBlock { Id = Guid.Parse("ebaaf748-a7d8-452e-9a81-45f10db9bcc2"), Type = TextBlockType.Text, Text = $"If you are present when a spirit or haunt is defeated, you instantly gain a flash of insight into how it can be permanently put to rest. Typically, this flash manifests as a vision that presents a quick scene closely linked to the source of the spirit or haunt's creation. Attempt a Spirit Lore or Haunt Lore check, respectively, with a DC appropriate for the spirit or haunt's level. On a success, you gain a hint about how to put the spirit to rest or permanently disable the haunt; on a critical success, you learn the exact method of doing so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3d764f98-e646-44ff-a702-97079baacba6"), Feats.Instances.GhostHunterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c99ebf00-92ef-4d73-ba7e-2ca6b56e5942"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
