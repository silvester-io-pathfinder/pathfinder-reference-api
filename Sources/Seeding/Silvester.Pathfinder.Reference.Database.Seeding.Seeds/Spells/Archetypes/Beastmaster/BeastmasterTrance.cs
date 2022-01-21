using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BeastmasterTrance : Template
    {
        public static readonly Guid ID = Guid.Parse("5d1921cf-8780-49a5-bd3c-2eb117c45499");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Beastmaster Trance",
                Level = 3,
                Range = "1 mile.",
                Duration = "Sustained up to 1 minute.",
                Targets = "One of your animal companions you can preceive.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5db1ffd0-1e7e-4c1e-af65-73fa30e83fec"), Type = TextBlockType.Text, Text = "You enter a magical trance that allows you to perceive through the senses of the target companion. You attempt Perception checks using your own Perception, but you have any special senses the target has, such as low-light vision or darkvision. This spell grants no special method of communication with the chosen animal, so it follows any instructions you gave it before you entered the trance and, failing that, it does as it wishes." };
            yield return new TextBlock { Id = Guid.Parse("9764ff2a-32ab-4c23-ae3c-b2352b334fa7"), Type = TextBlockType.Text, Text = "For the duration of the trance, your own senses are muted, though you can still communicate. This lack of awareness makes you flat-footed. You can't take actions with the attack or move traits." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("879c5833-a7a1-4059-ae04-2d365da92549"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("cc5331c9-cff8-4ebb-a61e-2c658de054d2"), Type = TextBlockType.Text, Text = "Increase the range to 100 miles and the duration to sustained up to 10 minutes. The target can hear you through the spell, allowing you to Command the Animal or use other actions that have the auditory trait." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("06a82fbb-4a37-435b-9f2c-fd07e473c399"),
                Level = "8th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("a31c95c4-13dc-4301-a8d8-104a7f0f4ab7"), Type = TextBlockType.Text, Text = "Increase the range to planetary and the duration to sustained up to 1 hour. You can communicate telepathically with the target for the duration of the trance." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("063cf07a-ab9e-4a48-bc7f-fbec76500f72"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("9742b7c1-c856-4ccb-bf36-d46735d0dfc5"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("69a9b0d9-eb68-44a8-abf7-7ad47343e198"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("d4d5d2ce-cf61-4455-8226-24bbbcce8164"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0fa35e0-bd37-4ed5-a831-7d129f555962"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 161
            };
        }
    }
}
