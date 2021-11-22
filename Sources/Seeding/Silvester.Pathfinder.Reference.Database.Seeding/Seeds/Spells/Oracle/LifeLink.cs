using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LifeLink : Template
    {
        public static readonly Guid ID = Guid.Parse("bd9dd966-305f-4fc5-a945-28fd2984fe85");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Life Link",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature other than you.",
                IsDismissable = true,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a2c47671-4eb9-4517-96d0-ee6c29733604"), Type = TextBlockType.Text, Text = "You forge a connection of life energy between you and your target, distributing harm between both of you. When you first Cast the Spell, the target recovers 1d4 Hit Points. The first time each round that the target takes damage, reduce the damage it takes by 3 (to a minimum of 0 damage). You lose 3 Hit Points each time, or the total damage dealt, if less than 3; this damage ignores any immunities or resistances you have and can't otherwise be mitigated in any way." };
            yield return new TextBlock { Id = Guid.Parse("52e27b81-075b-4a02-8061-90fba5e7358c"), Type = TextBlockType.Text, Text = "The spell ends immediately if you fall unconscious. You can Dismiss the spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("995b8dba-8717-44e9-a60f-4c4da0b7856b"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b55a9757-2158-4c48-a569-f6748dc77ccf"), Type = TextBlockType.Text, Text = "You can target 2 creatures other than you. Increase the initial healing to 3d4 and the maximum damage reduced and Hit Points lost to 5." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("31cd04aa-eb48-4d22-91bf-fdf8d61f8158"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6f98201e-13fe-4843-b696-33c1a34c834a"), Type = TextBlockType.Text, Text = "You can target 3 creatures other than you. Increase the initial healing to 6d4 and the maximum damage reduced and Hit Points lost to 10." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("134b55c1-a356-443b-8c1f-ceffc2418922"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("daca25b8-3978-4d58-b365-ee32d635ee77"), Type = TextBlockType.Text, Text = "You can target 4 creatures other than you. Increase the initial healing to 9d4 and the maximum damage reduced and Hit Points lost to 15." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Oracle.ID;
            yield return Traits.Instances.Positive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ede2061-ed74-49b1-ae78-d65d285b5b84"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 232
            };
        }
    }
}
