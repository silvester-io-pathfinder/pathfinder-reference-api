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
    public class PerfectShot : Template
    {
        public static readonly Guid ID = Guid.Parse("1516d927-4439-4f08-add2-34e64affa19d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perfect Shot",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1b4055f-ef4a-4fd8-a059-06ae31400b4a"), Type = TextBlockType.Text, Text = $"After watching the motions of combat with incredible intensity and precision, you fire at your prey at the perfect moment to deliver maximum pain. Make a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the required weapon against your hunted prey. If you hit, the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} deals maximum damage. After the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, your turn ends." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("3d18c7c4-7b88-45cd-a278-59efca24b8aa"), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse("4677dc23-1924-4ad1-b21e-d5988e07f744"), Traits.Instances.Ranger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1cf5cf31-d0ba-43d5-8d22-7492a1c354c7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
