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
    public class BindingOath : Template
    {
        public static readonly Guid ID = Guid.Parse("8c28159d-cc9c-4ddb-8062-726fbdfd6ab1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Binding Oath",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day (resetting at sunset)"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a04aacb5-3806-4fc2-8ab3-d40b2c2bb1a1"), Type = TextBlockType.Text, Text = $"You bind yourself by speaking an oath. Supernatural power flows through and around you as you speak it, and all those present to hear it intrinsically know that it binds you, preventing you from willingly acting against your declared oath or ignoring promises made as part of the oath. Thaumaturges use this ability to earn trust from others and lend weight to their promises, allowing them to more easily offer an oath or promise as part of a bargain. The oath doesn't prevent unwilling violations and can't be used to try to circumvent mind-control magic, confusion, or similar situations where you perform an action not entirely of your own volition. You gain a +1 circumstance bonus to {ToMarkdownLink<Models.Entities.SkillAction>("Request", SkillActions.Instances.Request.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Coerce", SkillActions.Instances.Coerce.ID)} creatures aware of your oath if you invoke it as part of a promise you make, due to the fact that the creatures know you must try to keep that promise." };
            yield return new TextBlock { Id = Guid.Parse("2eeab3eb-c56c-4c97-87d2-74ad6736c6f5"), Type = TextBlockType.Text, Text = $"If you have expert proficiency in Arcana, Nature, Occultism, or Religion, you can swear a binding oath two times per day; if you have master proficiency in one of these skills, three times; and if you have legendary proficiency, as many times as you like." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb3bbdcc-1dcd-4559-b9ea-b35920374c46"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
