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
    public class Winglets : Template
    {
        public static readonly Guid ID = Guid.Parse("b8b70031-c180-4896-a68b-4fd2f0afaaff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Winglets",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1a16eff5-e365-4736-83c8-15bd08a34589"), Type = TextBlockType.Text, Text = $"You're among the few kobolds who grow a set of draconic wings later in life. The wings are initially small and weak; while not enough for full flight, a strong flap allows you to jump further. When {ToMarkdownLink<Models.Entities.Action>("Leaping", Actions.Instances.Leap.ID)} horizontally, you move an additional 5 feet (this additional distance isn't cumulative with the increased {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} distance from the {ToMarkdownLink<Models.Entities.Feat>("Powerful Leap", Feats.Instances.PowerfulLeap.ID)} feat). You don't automatically fail your checks to {ToMarkdownLink<Models.Entities.SkillAction>("High Jump", SkillActions.Instances.HighJump.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Long Jump", SkillActions.Instances.LongJump.ID)} if you don't {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} at least 10 feet first. In addition, when you attempt a {ToMarkdownLink<Models.Entities.SkillAction>("Long Jump", SkillActions.Instances.LongJump.ID)}, you can jump a distance up to 10 feet higher than you normally would based on the result of your Athletics check, though you still can't jump farther than your Speed." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("2a842138-f1e2-466a-b439-9f2f326a2c51"), Traits.Instances.Kobold.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65bf03a6-eb4e-4034-91c4-7a3c492584f1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
