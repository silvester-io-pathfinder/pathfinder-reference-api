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
            builder.Add(Guid.Parse(""), Traits.Instances.Aasimar.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Exploration.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Teleportation.ID);

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
