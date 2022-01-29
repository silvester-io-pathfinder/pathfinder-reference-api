using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ThunderingDominance : Template
    {
        public static readonly Guid ID = Guid.Parse("605718cd-1099-4b94-b84f-af27321d7d71");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Thundering Dominance",
                Level = 2,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "Your companion or eidolon.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("35557c4c-2744-452e-acc1-39a0c65eb507"), Type = TextBlockType.Text, Text = "You shroud the target in a powerful predatory aura and amplify its vocalizations. It gains a +1 status bonus to Intimidation checks. Once during this spell's duration, it can take the Thundering Roar action." };
        }

        protected override IEnumerable<InlineAction> GetInlineActions()
        {
            yield return new InlineAction
            {
                Id = Guid.Parse("3146d899-5719-4d0a-8bf6-b199aa8a472b"),
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Name = "Thundering Roar",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("2131846d-cbcb-4cfa-9992-88cebf1bd433"), TraitId = Traits.Instances.Auditory.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("7faa468e-3ad5-47a5-9632-b59e803f8cfe"), TraitId = Traits.Instances.Concentrate.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("c133624f-b7c7-47b5-9f3e-8006e665d61f"), TraitId = Traits.Instances.Emotion.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("23c2071e-b058-4af6-b76f-1933889550d3"), TraitId = Traits.Instances.Enchantment.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("b29eabc7-4133-4e25-bb99-7023c5d8128b"), TraitId = Traits.Instances.Fear.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("0e2dcd4e-9811-4b2c-a4a2-cf1323e8d29f"), TraitId = Traits.Instances.Flourish.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("801666d3-c1a2-4acd-90dd-a05918573f81"), TraitId = Traits.Instances.Mental.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("04838bfc-4874-4ddd-8fb8-61998bacdc66"), TraitId = Traits.Instances.Sonic.ID },
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("09c40f51-0e68-454d-bfd9-4d968dbaf9ee"), Type = TextBlockType.Text, Text = "The target unleashes a powerful vocalization. Each enemy in a 10- foot emanation takes 4d8 sonic damage with a basic Will save against your spell DC. A creature that fails its Will save is also frightened 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("28ef02cd-d52c-4524-a1f9-652180259a61"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("205335a7-d280-4e74-8a19-a2a932d8bd01"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e39781f-6557-4514-a8be-9c393f5dd5b1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 136
            };
        }
    }
}
