using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InvisibilityCurtain : Template
    {
        public static readonly Guid ID = Guid.Parse("2d632681-7f73-415b-a2ac-724ea5660ebe");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Invisibility Curtain",
                Level = 4,
                Range = "120 feet.",
                Duration = "Sustained.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2757b8ed-cd73-4ef9-80c2-b17a72b271e1"), Type = TextBlockType.Text, Text = "You create a transparent invisible wall that makes any creatures on one side of the wall invisible to those on the other side. You choose which side of the wall provides invisibility to the creatures on that side when you cast the spell. You create either a 1-inch-thick wall in a straight line up to 60 feet long and 10 feet high or a 1-inch-thick, 10-foot-radius ring with the same height. The wall is intangible and stands vertically in either of the two forms. If you wish to do so, you can create the wall with a shorter length or height, or with a smaller radius. Any creature that crosses the wall becomes visible or invisible as appropriate, and it's visible if any portion of it is on the visible side of the wall. If a creature rendered invisible by the wall takes a hostile action, the spell ends after the hostile action is completed." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("575b254c-b0fe-4bc3-849d-987626464379"),
                Level = "7th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("df6a048b-956a-4653-81c8-6cdffc7328f7"), Type = TextBlockType.Text, Text = "The spell doesn't end if an invisible creature takes a hostile action." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1c206f5d-484f-41ee-84f2-204179526e58"), Traits.Instances.Illusion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3507a1d-c795-42b7-903f-404142a66428"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 112
            };
        }
    }
}
