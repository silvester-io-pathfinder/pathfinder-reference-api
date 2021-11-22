using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BreathWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("ff93f5f0-bd79-4f3e-bc0b-3a5dc8e654bf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Breath Weapon",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6bb6fcdb-930a-4c28-976f-9753361454ab"), Type = TextBlockType.Text, Text = "Your eidolon exhales a blast of destructive energy. Your eidolon deals 1d6 damage to all creatures in the area, with a basic Reflex save against your spell DC. The area and damage type of the Breath Weapon are chosen when the eidolon gains this ability. Your eidolon then can't use their Breath Weapon again for the next 1d4 rounds." };
            yield return new TextBlock { Id = Guid.Parse("af73bb3b-9ab0-4750-b207-b4050335ecd3"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, the damage increases by 1d6." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c447d857-33f4-4dac-a44e-f69beeca4184"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
