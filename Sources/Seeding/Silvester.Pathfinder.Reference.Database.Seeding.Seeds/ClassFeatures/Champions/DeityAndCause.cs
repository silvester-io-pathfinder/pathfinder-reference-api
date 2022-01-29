using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class DeityAndCause : Template
    {
        public static readonly Guid ID = Guid.Parse("58d7212d-2745-4d20-9982-ab46c6f496ec");

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
            yield return new TextBlock { Id = Guid.Parse("5230fe6c-0d16-4673-887f-6035f10191c0"), Type = TextBlockType.Text, Text = "Champions are divine servants of a deity. Choose a deity to follow; your alignment must be one allowed for followers of your deity. Actions fundamentally opposed to your deity's ideals or alignment are anathema to your faith. A few examples of acts that would be considered anathema appear in each deity's entry. You and your GM determine whether other acts are anathema." };
            yield return new TextBlock { Id = Guid.Parse("3e331b5a-88af-4685-84ee-cc7237a31584"), Type = TextBlockType.Text, Text = "You have one of the following causes. Your cause must match your alignment exactly. Your cause determines your champion's reaction, grants you a devotion spell, and defines part of your champion's code." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyDeity(Guid.Parse("f9c101dd-5881-4f3b-8f25-e9d5adb1c493"));
            builder.GainAnyCause(Guid.Parse("212c8feb-dec6-4807-b315-64ce4c174a9b"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("78f35346-86b7-4172-bef0-d4355b123a4d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 106
            };
        }
    }
}
