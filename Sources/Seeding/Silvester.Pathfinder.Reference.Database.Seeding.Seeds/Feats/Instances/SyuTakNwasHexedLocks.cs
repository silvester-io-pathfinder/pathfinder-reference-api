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
    public class SyuTakNwasHexedLocks : Template
    {
        public static readonly Guid ID = Guid.Parse("8c5cab02-e10c-4cab-9a5d-4aec042c3f9d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Syu Tak-Nwa's Hexed Locks",
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
            yield return new TextBlock { Id = Guid.Parse("fad9e1dc-29d4-4b96-96da-c453060f72db"), Type = TextBlockType.Text, Text = $"Your hair unarmed attack gains the {ToMarkdownLink<Models.Entities.Trait>("reach", Traits.Instances.Reach.ID)} trait. You can deliver hexes through your hair. When you successfully cast a hex focus spell that requires 2 or more actions to cast and that doesn't require a spell attack roll, if your target is within your reach, as part of the spellcasting activity you can make a hair {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the foe before applying any effects of the hex. If this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} misses, the hex has no effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("84898dde-acab-41da-b8b9-00da060b8829"), Feats.Instances.LivingHair.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15f797e5-f4e9-42e6-b5c7-d8b137dbce3d"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
