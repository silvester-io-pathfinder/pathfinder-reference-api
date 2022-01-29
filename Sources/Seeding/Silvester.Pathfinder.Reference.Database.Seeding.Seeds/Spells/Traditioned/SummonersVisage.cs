using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonersVisage : Template
    {
        public static readonly Guid ID = Guid.Parse("e5748afe-e7ad-41e0-a25f-90377288c45e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summoner's Visage",
                Level = 2,
                Range = "Touch.",
                Duration = "10 minutes.",
                Targets = "Your eidolon.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b921b4e5-2b2f-488d-a672-57ef4e67b0cb"), Type = TextBlockType.Text, Text = "You transform your eidolon into your identical twin. Assuming you are a humanoid, the eidolon gains the humanoid trait in addition to its other traits while it's in this form, as well as any other trait related to your form (such as elf or gnome). Your eidolon gains a +4 status bonus to Deception checks to Impersonate you and can add its level to such checks even if it's untrained." };
            yield return new TextBlock { Id = Guid.Parse("1b762fcf-57f2-422d-9fb8-4d4ac2638c30"), Type = TextBlockType.Text, Text = "Although your eidolon looks like you, it doesn't gain any new abilities, and its statistics don't change in any way - the transformation is purely cosmetic. If this transformation reduces your eidolon's size, the eidolon loses any other effects of its larger size, such as any increase to reach. Your eidolon can still use gear only if it has the eidolon trait, which allows eidolons to use it. Any such eidolon items the eidolon was wearing change size and shape, if necessary, and its effects remain active." };
            yield return new TextBlock { Id = Guid.Parse("b40788a6-a1c5-4a6f-92fd-6d0b1b14897f"), Type = TextBlockType.Text, Text = "You can Dismiss the spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("09c45e71-352c-4c03-a92f-bcaa93d45273"),
                Level = "4th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("c288023c-c58b-43ed-a14d-2a60a4727c1f"), Type = TextBlockType.Text, Text = "The duration increases to 1 hour." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2f362d17-9145-468e-973c-e3c66f601fa4"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("1c5f8940-13ba-4171-aa6e-406fa1c37198"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9efacc2b-2fa2-4951-81e2-b10687503fd6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 135
            };
        }
    }
}
