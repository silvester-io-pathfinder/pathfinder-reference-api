using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class TwinJuggernauts : Template
    {
        public static readonly Guid ID = Guid.Parse("8d7ea446-89ae-4415-958e-3a51ec598b5e");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 11,
                Name = "Twin Juggernauts", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bb7451cb-88a9-477d-b493-df405152b2a1"), Type = TextBlockType.Text, Text = "You and your eidolon fight off physical hardship together with your shared life force. Your proficiency rank for Fortitude saves and your eidolon's proficiency rank for Fortitude saves increase to master. When you roll a success on a Fortitude save, you get a critical success instead. When your eidolon rolls a success on a Fortitude save, it gets a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("6745d6b5-60ea-4d24-92cd-e6e3828c02a9"), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("cab65afd-2c79-4a24-aebe-81c441d8d0f4"), SavingThrowStats.Instances.Fortitude.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8326b9fd-4ccf-479b-823c-1cd22be70d54"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 57
            };
        }
    }
}
