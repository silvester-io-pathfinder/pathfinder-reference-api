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
    public class FlameJump : Template
    {
        public static readonly Guid ID = Guid.Parse("d789c1d2-e3dc-4078-8fe5-c202101384eb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flame Jump",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("60e12cd6-9826-4287-9c73-620b342992e3"), Type = TextBlockType.Text, Text = $"Your peri lineage has opened your mind to fire's raw, purging essence. You can spend 1 minute in focused preparation, then enter a fire your size or larger to instantly teleport to any fire that is your size or larger up to 5 miles away. You take no damage from entering or exiting fires when using this ability. Once you enter the fire, you instantly know the rough locations of other large fires within range and can exit from the original fire, if you prefer. You can't carry {ToMarkdownLink<Models.Entities.Trait>("extradimensional", Traits.Instances.Extradimensional.ID)} spaces with you when you teleport; if you attempt to do so, the activity fails." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("46b4a23e-8ef2-4096-a91b-41e972e884eb"), Feats.Instances.Emberkin.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e2479779-2be7-4e39-9c64-3b5d18ad502e"), Traits.Instances.Aasimar.ID);
            builder.Add(Guid.Parse("7c66886e-f8aa-49cc-ac30-587421a8e7e2"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("ce2c6f8b-db39-43e5-9680-e58739b30a65"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("19ff208a-4221-431b-91d5-7a4184cf2d76"), Traits.Instances.Exploration.ID);
            builder.Add(Guid.Parse("017f6686-e3d6-4aaf-b4cd-b9b3a368215f"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("1f56841e-1b96-4e33-86b9-01c273ba00af"), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse("a10aa929-0c18-4bbd-b4a7-ba89e5c4788e"), Traits.Instances.Teleportation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d63f6cdb-a96c-4177-bb14-bab41e72584c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
