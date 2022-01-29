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
    public class MasterScrollCache : Template
    {
        public static readonly Guid ID = Guid.Parse("1ac2ea6f-f13d-4379-8a7f-9f756e7d0cb4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Scroll Cache",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("85a79b4f-d8de-4a97-a051-3a6eecada7dd"), Type = TextBlockType.Text, Text = $"Your scroll collection is incredible, brimming with eldritch power, and you can prepare far more of them than an ordinary scroll trickster. In addition to your daily scrolls from the {ToMarkdownLink<Models.Entities.Feat>("Basic", Feats.Instances.BasicScrollCache.ID)} and {ToMarkdownLink<Models.Entities.Feat>("Expert Scroll Caches", Feats.Instances.ExpertScrollCache.ID)}, add a single scroll with a 6th-level spell. At 20th level, add a scroll with a 7th-level spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0fc24a86-60cc-4615-8618-71e97dc9c8c2"), Feats.Instances.ExpertScrollCache.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("080e9dea-6f20-4ab3-a79d-446db69080ae"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cde97c78-c1a7-4412-abec-9bfdd75948ce"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
