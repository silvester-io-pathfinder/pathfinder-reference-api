using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShadowJump : Template
    {
        public static readonly Guid ID = Guid.Parse("b51833e5-8a11-4ee5-a24a-73250cd8a1d3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shadow Jump",
                Level = 5,
                Range = "120 feet.",
                Requirements = "You are in dim light or darkness.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4f074ce0-0d5f-499c-a77d-a98c19a8b82d"), Type = TextBlockType.Text, Text = "You instantly transport yourself from one shadow to another. Teleport yourself and any items you're wearing and holding from your current space to a clear space you can see that's in dim light or darkness and within range. You can transport your familiar with this spell, but if shadow jump would bring any other creature with you - even if you're carrying the creature in an extradimensional container - the spell is disrupted." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("45a4c97a-d219-410d-8dd8-3e238748fa3e"),
                Level = "8th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("768296b0-7b8f-4df3-9793-8af4b4f651f6"), Type = TextBlockType.Text, Text = "When you arrive at your destination, you can become invisible until the end of your next turn or until you are no longer in an area of dim light or darkness, whichever comes first. The invisibility is an illusion effect." }
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
            builder.Add(Guid.Parse("8282d19f-9fab-47df-b846-965797bef07d"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("29447260-4582-48fb-a80a-98faf13ddf86"), Traits.Instances.Shadow.ID);
            builder.Add(Guid.Parse("b1d2887a-7130-423d-91e6-277877345599"), Traits.Instances.Teleportation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1635305b-7e74-4670-ac79-c983817c8a78"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 193
            };
        }
    }
}
