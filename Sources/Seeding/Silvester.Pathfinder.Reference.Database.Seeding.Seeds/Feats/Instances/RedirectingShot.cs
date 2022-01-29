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
    public class RedirectingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("b7081750-4149-4341-ad87-da1abb37014b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Redirecting Shot",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally misses with a ranged attack that uses a thrown weapon or ammunition. The ally must be willing to accept your assistance, you must see the attack's target, and the attack's target must be within the first range increment of your firearm or crossbow.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2967633c-7ab9-46f1-bc0a-e283ad24d875"), Type = TextBlockType.Text, Text = $"Seeing your ally's attack about to go astray, you fire your weapon to right its course. Discharge your firearm and roll a d20. Your ally uses this roll instead of their own, and the attack ignores bonuses the target would gain against the attack from lesser or standard cover." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7e1eb96c-6792-4f3c-afa7-e6022d1727e0"), Traits.Instances.Fortune.ID);
            builder.Add(Guid.Parse("9eff0cb6-05f4-4ebf-97d9-5a70218ca0d1"), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f896c827-0669-40f9-ac65-1f799fa6964e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
