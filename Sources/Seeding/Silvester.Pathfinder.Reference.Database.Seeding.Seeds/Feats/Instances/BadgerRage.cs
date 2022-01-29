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
    public class BadgerRage : Template
    {
        public static readonly Guid ID = Guid.Parse("aaf39d39-ed57-4cde-b49b-7905fcd8f894");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Badger Rage",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("afbe2ac9-74d2-40ac-a601-05dee9b89039"), Type = TextBlockType.Text, Text = $"The badger enters a state of pure rage that lasts for 1 minute, until there are no enemies it can perceive, or until it falls unconscious, whichever comes first. It can't voluntarily stop raging. While raging, the badger is affected in the following ways." };
            yield return new TextBlock { Id = Guid.Parse("578a0231-8db3-4e25-b034-4a0179828681"), Type = TextBlockType.Enumeration, Text = $" : It deals 4 additional damage with its jaws attack and 2 additional damage with its claw attack." };
            yield return new TextBlock { Id = Guid.Parse("c5f084c9-1389-4a63-b021-7cdaa069e1ad"), Type = TextBlockType.Enumeration, Text = $" : It takes a -1 penalty to AC." };
            yield return new TextBlock { Id = Guid.Parse("3b816f89-ed29-458b-a031-7e5e96460906"), Type = TextBlockType.Enumeration, Text = $" : It can't use actions that have the {ToMarkdownLink<Models.Entities.Trait>("concentrate", Traits.Instances.Concentrate.ID)} trait unless they also have the {ToMarkdownLink<Models.Entities.Trait>("rage", Traits.Instances.Rage.ID)} trait. Though, the animal companion can {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} even while raging." };
            yield return new TextBlock { Id = Guid.Parse("64ae855d-c041-4563-b3fc-801a39449d41"), Type = TextBlockType.Text, Text = $"After it has stopped raging, it can't use Badger Rage again for 1 minute." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4304e9cd-5b14-435f-a187-991c3a3c253e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
