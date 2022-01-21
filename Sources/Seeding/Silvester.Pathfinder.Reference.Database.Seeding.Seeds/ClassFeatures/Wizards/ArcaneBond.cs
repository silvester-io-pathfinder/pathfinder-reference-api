using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class ArcaneBond : Template
    {
        public static readonly Guid ID = Guid.Parse("e41b4849-99e5-4c07-88ab-916970f7070f");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Arcane Bond", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c00174be-2201-4615-ae6b-15bfeec11e47"), Type = TextBlockType.Text, Text = "You place some of your magical power in a bonded item. Each day when you prepare your spells, you can designate a single item you own as your bonded item. This is typically an item associated with spellcasting, such as a wand, ring, or staff, but you are free to designate a weapon or other item. You gain the Drain Bonded Item free action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("a987f259-91ff-40dc-9470-dc05b87a64fe"), Feats.Instances.DrainBondedItem.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b0c8539f-4092-4329-b233-adc2a164fccb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 205
            };
        }
    }
}
