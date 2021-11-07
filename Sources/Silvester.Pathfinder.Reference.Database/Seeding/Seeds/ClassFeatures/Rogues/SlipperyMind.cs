using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rogues
{
    public class SlipperyMind : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Slippery Mind", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You play mental games and employ cognitive tricks to throw off mind-altering effects. Your proficiency rank for Will saves increases to master. When you roll a success at a Will save, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse(""), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Will.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse(""), SavingThrowStats.Instances.Will.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 182
            };
        }
    }
}
