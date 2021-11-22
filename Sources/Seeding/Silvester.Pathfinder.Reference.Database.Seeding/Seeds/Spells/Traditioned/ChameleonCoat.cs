using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ChameleonCoat : Template
    {
        public static readonly Guid ID = Guid.Parse("fb8c796d-469a-460f-a597-a8cd12c20861");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Chameleon Coat",
                Level = 5,
                Range = "15 feet.",
                Duration = "10 minutes.",
                Targets = "Up to 8 creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f6ef7b51-e38a-4533-92be-8e77327fad5f"), Type = TextBlockType.Text, Text = "You shift the colors of the targets' outermost layer of clothing and gear to be closer to their environment when they remain still. Creatures affected by the spell gain a +3 status bonus to Stealth checks to Hide. The changed color granted by the spell always shifts to match the environment, even if there are drastic changes. If any piece of gear or clothing affected by the spell is removed from a creature, the spell ends for that creature." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("92cf4324-c91d-4bf0-95a2-d33a08aa0295"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6a93d6cc-d697-4ea8-bd9f-ee45cbad4869"), Type = TextBlockType.Text, Text = "If a creature affected by this spell rolls a critical failure on its Stealth check to Sneak within 30 feet of a creature that would spot it, it instead only fails its check, as the spell mildly hypnotizes the spotter." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("4b6cdd84-8976-4ccc-aaf6-8a17d3fc724c"),
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("34226823-f8fd-47bf-a612-200c43ad00d3"), Type = TextBlockType.Text, Text = "As 6th level, and the status bonus is +4." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86eb3022-edfd-4e05-b900-7a7e8cb3c00b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 216
            };
        }
    }
}
