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
    public class ModificationAdvancedRangefinder : Template
    {
        public static readonly Guid ID = Guid.Parse("deaa2969-6ae7-4137-aa57-e4cbfe93c41e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Advanced Rangefinder",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6ddb5fe2-e0a4-4738-adae-564bab406227"), Type = TextBlockType.Enumeration, Text = $"*Ranged Only**" };
            yield return new TextBlock { Id = Guid.Parse("90c7388c-aedf-4ceb-a6da-b3a6a43b45c7"), Type = TextBlockType.Text, Text = $"A carefully tuned scope or targeting device makes your weapon especially good at hitting weak points. Your innovation gains the {ToMarkdownLink<Models.Entities.Trait>("backstabber", Traits.Instances.Backstabber.ID)} trait and increases its range increment by 10 feet." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e37ccc38-1df4-4fe9-906a-df138a482de3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
