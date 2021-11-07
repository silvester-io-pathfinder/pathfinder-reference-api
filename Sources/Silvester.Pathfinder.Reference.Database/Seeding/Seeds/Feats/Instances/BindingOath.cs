using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BindingOath : Template
    {
        public static readonly Guid ID = Guid.Parse("56a40a65-880e-4aa3-a756-f08d260c7465");

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
            yield return new TextBlock { Id = Guid.Parse("85b8aeed-3608-4083-93a4-cf48a5c0a018"), Type = TextBlockType.Text, Text = "You bind yourself by speaking an oath. Supernatural power flows through and around you as you speak it, and all those present to hear it intrinsically know that it binds you, preventing you from willingly acting against your declared oath or ignoring promises made as part of the oath. Thaumaturges use this ability to earn trust from others and lend weight to their promises, allowing them to more easily offer an oath or promise as part of a bargain. The oath doesn’t prevent unwilling violations and can’t be used to try to circumvent mind-control magic, confusion, or similar situations where you perform an action not entirely of your own volition. You gain a +1 circumstance bonus to (action: Request) or (action: Coerce) creatures aware of your oath if you invoke it as part of a promise you make, due to the fact that the creatures know you must try to keep that promise." };
            yield return new TextBlock { Id = Guid.Parse("5673bac5-c914-4420-bd61-16a081001f81"), Type = TextBlockType.Text, Text = "If you have expert proficiency in Arcana, Nature, Occultism, or Religion, you can swear a binding oath two times per day; if you have master proficiency in one of these skills, three times; and if you have legendary proficiency, as many times as you like." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f4dc711b-4e18-4a46-8ced-f43e6afac0c8"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
