using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class DruidicOrder : Template
    {
        public static readonly Guid ID = Guid.Parse("4ffccbad-0041-4c13-9fcd-ba995284c7fa");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Druidic Order", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7dfcddc0-899a-4e73-a724-90c51e034e54"), Type = TextBlockType.Text, Text = "Upon becoming a druid, you align yourself with a druidic order, which grants you a class feat, an order spell (see below), and an additional trained skill tied to your order. While you'll always be a member of your initial order, it's not unheard of for a druid to request to study with other orders in search of greater understanding of the natural world, and PC druids are among the most likely to blend the powers of different orders." };
            yield return new TextBlock { Id = Guid.Parse("8c58c287-37ab-4956-8210-cc5c4079962b"), Type = TextBlockType.Text, Text = "Order spells are a type of focus spell. It costs 1 Focus Point to cast a focus spell, and you start with a focus pool of 1 Focus Point. You refill your focus pool during your daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the Refocus activity to commune with local nature spirits or otherwise tend to the wilderness in a way befitting your order." };
            yield return new TextBlock { Id = Guid.Parse("5ea63ce0-84f7-47bd-bd37-4bad7161ec38"), Type = TextBlockType.Text, Text = "Focus spells are automatically heightened to half your level rounded up, much like cantrips. Focus spells don't require spell slots to cast, and you can't cast them using spell slots. Selecting druid feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 points. The full rules for focus spells are found here." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyDruidicOrder(Guid.Parse("d12975b3-2dba-4b95-8f42-003be35e5c3b"));
            builder.GainFocusPoolPoint(Guid.Parse("6a6b9d0c-fd95-41f3-9e06-22710611d06f"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b39e8c58-5d77-4fd3-9930-ff4b126c7b23"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 131
            };
        }
    }
}
