using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DeceiversCloak : Template
    {
        public static readonly Guid ID = Guid.Parse("09588bf2-d5cc-40d1-ae56-868479d5f64a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Deceiver's Cloak",
                Level = 3,
                IsDismissable = true,
                Duration = "Sustained.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dafce631-7753-4a98-ad17-af73f22969f7"), Type = TextBlockType.Text, Text = "You wrap yourself in a cloak of illusion, appearing as another creature of the same body shape with roughly similar height and weight as yourself. This has the effects of a 3rd-level illusory disguise." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("01bc942c-8749-4a7f-b7e9-d7f96056b6c8"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f5418938-855c-41e5-a7aa-2a29b50edbb1"), Type = TextBlockType.Text, Text = "You can appear as any creature of the same size, even with a completely different body shape." }
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
            builder.Add(Guid.Parse("5653d852-5f28-4592-b8f7-4c8583f0e76f"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("304da908-0f0e-43fb-9b41-4ba0bbf3ca02"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("4f82d059-6288-42fd-91f8-9028cd96691c"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("c3719249-54e9-4bf3-bd48-acef8f833dff"), Traits.Instances.Witch.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9a2516a-b8e8-43d5-a9c9-8a693c605b62"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 238
            };
        }
    }
}
