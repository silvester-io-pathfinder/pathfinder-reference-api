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
    public class DemonsHair : Template
    {
        public static readonly Guid ID = Guid.Parse("0c655d47-8ac9-4bca-ae16-93f1df15dd1a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Demon's Hair",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your hair already has the (trait: reach) trait, it instead gains the (trait: sweep) trait.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1c09d6e8-711c-4c5e-95a0-1baddf6cea62"), Type = TextBlockType.Text, Text = $"Your hair constantly wriggles and writhes like that of your rival, Syu Tak-nwa. Your damage die of your hair unarmed {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} increases by one step and it gains the {ToMarkdownLink<Models.Entities.Trait>("reach", Traits.Instances.Reach.ID)} and {ToMarkdownLink<Models.Entities.Trait>("versatile slashing", Traits.Instances.Versatile.ID)} traits. Your familiar assumes partial control over your hair; as long as your familiar is alive and within 30 feet, you are permanently quickened, and you can use the extra action only to make a hair {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. You can deliver hexes through your hair. When you successfully cast a non-cantrip hex that requires 2 or more actions to cast and that doesn't require a spell attack roll, if your target is within your reach, as part of the spellcasting activity you can make a hair {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against them before applying any effects of the hex. If this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} misses, the hex has no effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("612a31bf-eb8b-4b0f-b41c-e7680eda8e6f"), Feats.Instances.LivingHair.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("da3a46c5-718d-43e4-82c3-4eadb7a0f0ae"), Traits.Instances.Witch.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61347d94-fe28-4cf9-a48f-f478cc4024d1"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
