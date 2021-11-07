using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BreathWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("7b4e29e4-bb72-438b-9bec-ecc5b2d8e99f");

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
            yield return new TextBlock { Id = Guid.Parse("3454b27d-8697-4a26-a4cb-3cce7ca85dd7"), Type = TextBlockType.Text, Text = "Your eidolon exhales a blast of destructive energy. Your eidolon deals 1d6 damage to all creatures in the area, with a basic Reflex save against your spell DC. The area and damage type of the Breath Weapon are chosen when the eidolon gains this ability. Your eidolon then can’t use their Breath Weapon again for the next 1d4 rounds." };
            yield return new TextBlock { Id = Guid.Parse("2c595376-220b-470d-8390-2d29d3be7974"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, the damage increases by 1d6." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db19d005-b4e9-4f13-909c-eceebcfe5037"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
