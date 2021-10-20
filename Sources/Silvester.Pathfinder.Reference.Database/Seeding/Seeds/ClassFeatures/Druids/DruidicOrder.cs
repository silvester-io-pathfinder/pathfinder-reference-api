using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class DruidicOrder : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Upon becoming a druid, you align yourself with a druidic order, which grants you a class feat, an order spell (see below), and an additional trained skill tied to your order. While you'll always be a member of your initial order, it's not unheard of for a druid to request to study with other orders in search of greater understanding of the natural world, and PC druids are among the most likely to blend the powers of different orders." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Order spells are a type of focus spell. It costs 1 Focus Point to cast a focus spell, and you start with a focus pool of 1 Focus Point. You refill your focus pool during your daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the Refocus activity to commune with local nature spirits or otherwise tend to the wilderness in a way befitting your order." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Focus spells are automatically heightened to half your level rounded up, much like cantrips. Focus spells don't require spell slots to cast, and you can't cast them using spell slots. Selecting druid feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 points. The full rules for focus spells are found here." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainAnyDruidicOrderEffect { Id = Guid.Parse("") };
            yield return new GainFocusPoolPointEffect { Id = Guid.Parse("") };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 131
            };
        }
    }
}
