using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellCombination : Template
    {
        public static readonly Guid ID = Guid.Parse("9d4b87ed-d99d-43e1-b0c1-c72a78723a87");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spell Combination",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a2f77769-61da-493b-bdd7-84680a8588f3"), Type = TextBlockType.Text, Text = "You can merge spells, producing multiple effects with a single casting. One slot of each level of spell you can cast, except 2nd level and 1st level, becomes a spell combination slot (this doesn't apply to cantrips). When you prepare your spells, you can fill a combination slot with a combination of two spells. Each spell in the combination must be 2 or more spell levels below the slot's level, and both must target only one creature or object or have the option to target only one creature or object. Each spell in the combination must also have the same means of determining whether it has an effect – both spells must require a ranged spell attack roll, require the same type of saving throw, or automatically affect the target." };
            yield return new TextBlock { Id = Guid.Parse("62fb7fc3-5a2e-4250-bfe7-2b599dc4223c"), Type = TextBlockType.Text, Text = "When you cast a combined spell, it affects only one target, even if the component spells normally affect more than one. If any spell in the combination has further restrictions (such as targeting only living creatures), you must abide by all restrictions. The combined spell uses the shorter of the component spells' ranges. Resolve a combined spell as if were a single spell, but apply the effects of both component spells. For example, if the spell's target succeeded at the save against a combined spell, it would apply the success effect of each spell, and if it critically failed, it would apply the critical failure effect of both spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31640cc5-8494-48ab-9db9-be60901a4bd5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
