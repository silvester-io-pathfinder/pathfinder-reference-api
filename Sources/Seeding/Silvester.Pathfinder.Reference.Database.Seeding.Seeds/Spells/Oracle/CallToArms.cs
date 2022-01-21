using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CallToArms : Template
    {
        public static readonly Guid ID = Guid.Parse("bb25bf00-0614-4a04-838d-0d3a53149a13");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Call to Arms",
                Level = 1,
                Area = "20-foot emanation.",
                Trigger = "You are about to roll for initiative.",
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70688af2-20e4-487a-ac58-8c908ac3cb6f"), Type = TextBlockType.Text, Text = "You cry out a call to arms, inspiring your allies to enter the fray. Each ally in the area gains a +2 status bonus to their initiative roll and gains temporary Hit Points equal to the spell's level; these temporary Hit Points last for the spell's duration." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a9b788d7-6183-41ad-8b02-231d9732a9bb"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0229de67-af33-469f-ae28-434bb544870c"), Type = TextBlockType.Text, Text = "The bonus increases to +3." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("baba742d-9871-4c96-9dc6-154101706231"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("efed7397-c6e5-4c7f-b039-4c8e9041e6cf"), Type = TextBlockType.Text, Text = "The bonus increases to +4." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("6ef61e06-3001-4f0c-a9c7-0247a821ba9f"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("38088d0c-dd7d-49ab-ae01-9a45a7948577"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("ea2e50d2-9801-4fc7-b2f9-da88103bdbf5"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("7c15ded2-914a-4f47-8154-ae955540fd47"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("1a1680cc-9db7-496c-bd88-6450920522d8"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("00a7fdb7-4a9a-4a5a-aa67-efe79ab78be7"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("57513ec5-5317-457a-9b5d-ecd6d7c6f990"), Traits.Instances.Oracle.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a5557a4-658f-4dc1-b8a2-0e8dd96ed371"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 230
            };
        }
    }
}
