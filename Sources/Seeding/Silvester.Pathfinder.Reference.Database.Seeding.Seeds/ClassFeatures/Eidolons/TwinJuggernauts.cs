using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Eidolons
{
    public class TwinJuggernauts : Template
    {
        public static readonly Guid ID = Guid.Parse("914e34f6-2269-4c1c-b5bd-b022f9acbc68");

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
            yield return new TextBlock { Id = Guid.Parse("b0326a6d-17d7-4836-80d8-533e0dae1a09"), Type = TextBlockType.Text, Text = "You and your eidolon fight off physical hardship together with your shared life force. Your proficiency rank for Fortitude saves and your eidolon's proficiency rank for Fortitude saves increase to master. When you roll a success on a Fortitude save, you get a critical success instead. When your eidolon rolls a success on a Fortitude save, it gets a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("4c2d68a4-1402-4f89-b432-17f5f8e54037"), Proficiencies.Instances.Master.ID, SavingThrowStats.Instances.Fortitude.ID);
            builder.ImproveSpecificSavingThrow(Guid.Parse("9f3893ae-c150-40b2-89c7-7869ce15b87f"), SavingThrowStats.Instances.Fortitude.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb20285b-bad4-450f-9e34-3eac8b7dd455"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 57
            };
        }
    }
}
