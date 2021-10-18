using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class DeityAndCause : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Deity and Cause", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Champions are divine servants of a deity. Choose a deity to follow; your alignment must be one allowed for followers of your deity. Actions fundamentally opposed to your deity’s ideals or alignment are anathema to your faith. A few examples of acts that would be considered anathema appear in each deity’s entry. You and your GM determine whether other acts are anathema." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have one of the following causes. Your cause must match your alignment exactly. Your cause determines your champion’s reaction, grants you a devotion spell, and defines part of your champion’s code." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainAnyDeityEffect { Id = Guid.Parse("") };
            yield return new GainSpecificCauseEffect { Id = Guid.Parse("") };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 106
            };
        }
    }
}
