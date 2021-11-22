using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Retrocognition : Template
    {
        public static readonly Guid ID = Guid.Parse("6c7cbf51-796d-4a50-b824-8c0a3acfbcaf");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Retrocognition",
                Level = 7,
                CastTime = "1 minute.",
                IsDismissable = true,
                Duration = "Sustained.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9a08bac0-8d90-43a0-a5f1-d5553a72266f"), Type = TextBlockType.Text, Text = "Opening your mind to occult echoes, you gain impressions from past events that occurred in your current location. Retrocognition reveals psychic impressions from events that occurred over the course of the last day throughout the first minute of the duration, followed by impressions from the next day back the next minute, and so on. These echoes don't play out like a vision but instead reveal impressions of emotions and metaphors that provide cryptic clues and details of the past. If you witness a traumatic or turbulent event through an impression, the spell ends unless you succeed at a Will save with a DC of at least 30 and possibly as much as 50, depending on the severity of the event. The GM determines whether an event is traumatic and chooses the DC." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c7d02ba6-e874-4ce6-ab4d-6b32c4adb5e4"),
                Level = "8th",
                Details =
                {
                     new TextBlock { Id = Guid.Parse("a7453ccb-887c-475e-80c3-7d4580ba8af6"), Type = TextBlockType.Text, Text = "You gain impressions of events that occurred over the previous year for each minute you concentrate, instead of the previous day, though the details diminish, making it harder to distinguish impressions from all but the most major events. " }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("667573af-011c-4b14-b628-df16fd97c194"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f07fee3d-9445-4809-b410-67362b6a918b"), Type = TextBlockType.Text, Text = "You gain impressions of events that occurred over the previous century for each minute you concentrate, instead of the previous day, though the details diminish, making it almost impossible to distinguish impressions from all but the most major events." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41ae2444-a50c-4455-af41-7560e5fb9a7b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 365
            };
        }
    }
}
