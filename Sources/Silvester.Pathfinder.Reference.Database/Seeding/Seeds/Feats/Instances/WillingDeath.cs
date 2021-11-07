using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WillingDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("39725dd0-2012-4b35-84c9-3b3ae9cbc2da");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Willing Death",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can select this feat only at 1st level, and you can't retrain into or out of this feat.",
                Trigger = "An ally within 30 feet takes damage that would otherwise reduce them to 0 Hit Points and give them the dying condition.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7e7449d0-0ee6-4252-a01e-38244fbe25ea"), Type = TextBlockType.Text, Text = "Once, you died because you valued someone else’s life above your own; just as then, you protect an ally by suffering in their stead. Reduce the damage the triggering ally would take by 1 + your level. You redirect this damage to yourself, but your immunities, weaknesses, resistances, and so on don’t apply. You aren’t subject to any conditions or other effects from whatever damaged your ally (such as poison from a venomous bite)—your ally is still subject to those effects even if you redirect all of the triggering damage to yourself. If the redirected damage prevents the ally from being reduced to 0 Hit Points, they remain conscious and don’t gain the dying condition." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f127429a-670b-429b-b951-91d560643b06"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
