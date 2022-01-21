using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SongOfMarching : Template
    {
        public static readonly Guid ID = Guid.Parse("bb2135a7-3976-496d-80d4-7e4043c4c336");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Song of Marching",
                Level = 3,
                Area = "60-foot emanation.",
                IsDismissable = true,
                Duration = "Sustained up to 1 hour.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("166f8df4-8f51-435a-ae56-ad90536b8fd9"), Type = TextBlockType.Text, Text = "You maintain a brisk performance that keeps allies on the move. You and your allies in the area can Hustle for the spell's duration, even though you are also Sustaining the Spell. You and your allies then become temporarily immune for 1 day." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d7d17b90-0a4e-46cf-960a-7d80ce19f257"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ae70f517-2c4f-46c5-be3a-e829f0e094a9"), Type = TextBlockType.Text, Text = "You can Sustain the Spell for up to 2 hours." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("f6e407b5-5c3b-408c-a8a8-0a64e863c495"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("14fcb480-34c1-406b-a067-e56fb3f4d4b5"), Type = TextBlockType.Text, Text = "You can Sustain the Spell for up to 4 hours." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("d4da4957-a080-494d-8777-8fa72307e5ca"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("31a0235e-2c4b-4985-9307-ec0fb47c140b"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("8ad19d05-8787-4cbc-843e-c597336b12db"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("e98662a6-6c4c-4664-82e6-a18f70d51f45"), Traits.Instances.Composition.ID);
            builder.Add(Guid.Parse("6fc55324-087d-42f8-b901-b934dc6dea6b"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("91cb2d26-d1bd-4b89-80ab-4688864db334"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9ae57e4-f01f-4e02-80e7-7fdbc7e8fe0c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 228
            };
        }
    }
}
