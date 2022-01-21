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
    public class DivineAlly : Template
    {
        public static readonly Guid ID = Guid.Parse("a418632c-5ca5-4fb2-be95-c48deee7647c");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Divine Ally", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e49e4856-edb2-4712-ba07-cabb85ef3b5c"), Type = TextBlockType.Text, Text = "Your devotion attracts a spirit of your deity�s alignment. Once you choose an ally, your choice can�t be changed." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyDivineAlly(Guid.Parse("52c2dcd0-bc80-4086-8b82-10d56d2a04ba"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39405492-d369-4086-bf01-167a1d24fb39"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
