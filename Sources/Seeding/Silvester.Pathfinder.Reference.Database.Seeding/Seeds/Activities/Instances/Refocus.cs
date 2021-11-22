using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Activities.Instances
{
    public class Refocus : Template
    {
        public static readonly Guid ID = Guid.Parse("6007b710-10f5-474e-8703-5c43821fc7db");
        
        protected override Activity GetActivity()
        {
            return new Activity
            {
                Id = ID, 
                Name = "Refocus",
                Requirements = "You have a focus pool, and you have spent at least 1 Focus Point since you last regained any Focus Points."
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5e0c1af4-d1a0-4b22-b0c6-93b8dfdf830b"), Type = TextBlockType.Text, Text = "You spend 10 minutes performing deeds to restore your magical connection. This restores 1 Focus Point to your focus pool. The deeds you need to perform are specified in the class or ability that gives you your focus spells. These deeds can usually overlap with other tasks that relate to the source of your focus spells. For instance, a cleric with focus spells from a good deity can usually Refocus while tending the wounds of their allies, and a wizard of the illusionist school might be able to Refocus while attempting to Identify Magic of the illusion school." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Exploration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c01047b-a372-4088-9f47-3cbc8b1cdfcb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 300
            };
        }
    }
}
