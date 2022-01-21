using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TimeJump : Template
    {
        public static readonly Guid ID = Guid.Parse("d49d2e2f-5a31-4290-bdd0-616d268ce294");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Time Jump",
                Level = 3,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad9e6af7-4f0d-4a60-91e8-a9f73b686ba1"), Type = TextBlockType.Text, Text = "You leap forward a few seconds in time, appearing across the battlefield in the blink of an eye. You gain 2 actions, each of which must be used to Leap, Stand, Step, or Stride. If you have an appropriate Speed, you can add Burrow, Climb, Fly, or Swim to this list." };
            yield return new TextBlock { Id = Guid.Parse("521f5275-138f-41e3-834c-e40fa09786dd"), Type = TextBlockType.Text, Text = "While you take these actions, time pauses. All other creatures are completely unaware of your actions, can�t speak, and can�t use any actions that would be triggered by your movement. While you�re taking these actions, you can�t take any other actions, including any that would be triggered by the move actions. Once the actions are complete, time starts again, and to onlookers, you seem to have suddenly teleported across the distance you traveled. Leaping forward through time is disorienting, so if you use time jump again within 1 minute of using the spell, you become stupefied 4 for 1 minute." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("687a8245-698c-4066-b3f7-de51d0a98a7a"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e4e282e-e4bb-446c-ae9f-6df6e9aa8d48"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 136
            };
        }
    }
}
