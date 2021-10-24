using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class IncredibleMovement : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Incredible Movement", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You move like the wind. You gain a +10-foot status bonus to your Speed whenever you’re not wearing armor. The bonus increases by 5 feet for every 4 levels you have beyond 3rd." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddPrerequisites(Guid.Parse(""), prerequisites => 
            {
                prerequisites.HaveCurrentArmorCategory(Guid.Parse(""), ArmorCategories.Instances.Unarmored.ID);
            });

            builder.ModifySpeed(Guid.Parse(""), ModifierType.Add, 10)
                .AddPrerequisites(Guid.Parse(""), prerequisites => { prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 3); });

            builder.ModifySpeed(Guid.Parse(""), ModifierType.Add, 5)
                .AddPrerequisites(Guid.Parse(""), prerequisites => { prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 7); });

            builder.ModifySpeed(Guid.Parse(""), ModifierType.Add, 5)
                .AddPrerequisites(Guid.Parse(""), prerequisites => { prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 11); });

            builder.ModifySpeed(Guid.Parse(""), ModifierType.Add, 5)
                .AddPrerequisites(Guid.Parse(""), prerequisites => { prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 15); });

            builder.ModifySpeed(Guid.Parse(""), ModifierType.Add, 5)
                .AddPrerequisites(Guid.Parse(""), prerequisites => { prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 19); });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 156
            };
        }
    }
}
