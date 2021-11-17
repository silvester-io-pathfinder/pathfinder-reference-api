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
    public class ChampionMastery : Template
    {
        public static readonly Guid ID = Guid.Parse("7961db4f-611f-479f-806f-7f4260a2db53");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Champion Mastery", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("38c41156-ae68-4f6c-8bcd-24e128d7052d"), Type = TextBlockType.Text, Text = "You�ve mastered your arsenal of champion techniques and divine spells. Your proficiency ranks for your champion class DC and for divine spell attack rolls and spell DCs increase to master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificClassDcProficiency(Guid.Parse("e2faf51f-6776-4b1c-b285-65d99cff8b7f"), Proficiencies.Instances.Master.ID);
            builder.GainSpecificSpellAttackProficiency(Guid.Parse("5e64938b-53e1-40dd-bb0f-5e29617ed48d"), Proficiencies.Instances.Master.ID);
            builder.GainSpecificSpellDcProficiency(Guid.Parse("74a97a1c-655c-42bb-8209-9206e4191b35"), Proficiencies.Instances.Master.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fdddb368-11ec-4337-b10c-39e6af61b797"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 109
            };
        }
    }
}
