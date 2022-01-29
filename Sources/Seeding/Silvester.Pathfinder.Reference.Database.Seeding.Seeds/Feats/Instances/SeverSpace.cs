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
    public class SeverSpace : Template
    {
        public static readonly Guid ID = Guid.Parse("23b7e8de-cdae-48ad-be0d-876cf2171350");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sever Space",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7211fdf0-880b-4e30-ae72-fbcfa445617d"), Type = TextBlockType.Text, Text = $"You destroy the space between you and your targets, allowing you to strike with your melee weapons at great range. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the required weapon or unarmed attack. The attack gains an 80-foot reach for this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("3a36bfac-db0c-4acc-8453-e63dabd1631c"), Type = TextBlockType.Text, Text = $"After the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, regardless of whether it succeeded, the world rushes to fill the space you destroyed, bringing you and the target adjacent to each other. You can choose to teleport to the closest space adjacent to the target or to attempt to teleport the target adjacent to you. If you choose the target, they can negate the teleportation if they succeed at a Fortitude save against your class DC." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("54f176db-9c5b-4b11-a179-2c4d0d629538"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("78341561-c4c0-4dcd-9dd8-d54210876733"), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse("6fdd4d79-e8c5-407c-b61f-4336481eea1b"), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse("824b164b-5510-4da7-8240-b952845d9d07"), Traits.Instances.Teleportation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae84d8b1-e541-433f-9365-2551d82037d6"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
