using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RedirectingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("81fefc36-3e31-4d84-8768-331b1c93f96f");

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
            yield return new TextBlock { Id = Guid.Parse("6d4c4aed-4612-45fa-98f7-e479584350d4"), Type = TextBlockType.Text, Text = "Seeing your ally’s attack about to go astray, you fire your weapon to right its course. Discharge your firearm and roll a d20. Your ally uses this roll instead of their own, and the attack ignores bonuses the target would gain against the attack from lesser or standard cover." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05596146-f496-4447-8c52-36ca94f2827a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
