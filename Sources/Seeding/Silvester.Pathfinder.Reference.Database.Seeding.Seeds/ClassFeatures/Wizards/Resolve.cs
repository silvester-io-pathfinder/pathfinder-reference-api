using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class Resolve : Template
    {
        public static readonly Guid ID = Guid.Parse("ece13059-8746-41fe-83d8-fb64ae7073dc");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Resolve", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ab4514fa-f676-4563-9874-ac6622547e7e"), Type = TextBlockType.Text, Text = "you've steeled your mind with resolve. Your proficiency rank for Will saves increases to master. When you roll a success at a Will save, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("4139b494-1f34-4d36-8fb0-1d80b1f792cd"), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Will.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("ea223c4c-73b3-44ea-95f5-310b827618a9"), SavingThrowStats.Instances.Will.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d6fb1a9-fc10-445a-a7a6-9074a569427d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 207
            };
        }
    }
}
