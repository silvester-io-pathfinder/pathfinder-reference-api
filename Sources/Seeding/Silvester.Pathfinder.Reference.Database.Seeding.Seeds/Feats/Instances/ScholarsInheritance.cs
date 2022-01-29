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
    public class ScholarsInheritance : Template
    {
        public static readonly Guid ID = Guid.Parse("df9d5e28-257a-4106-b108-61e8deb6adf7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scholar's Inheritance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5cf07521-9ecd-4945-b1aa-5c858884d7d8"), Type = TextBlockType.Text, Text = $"Your parents devoted themselves to alchemical experiments involving elemental energy. You gain the trained proficiency rank in Crafting. If you would automatically become trained in Crafting (from your background or class, for example), you instead become trained in a skill of your choice. You also gain the {ToMarkdownLink<Models.Entities.Feat>("Alchemical Crafting", Feats.Instances.AlchemicalCrafting.ID)} skill feat." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Suli.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("154490bf-a98b-4f6e-bbd2-47dc009cb2c2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
