using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UmbralGraft : Template
    {
        public static readonly Guid ID = Guid.Parse("c519a674-7f56-4b9d-9ee4-c85b66dcadc5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Umbral Graft",
                Level = 4,
                Duration = "3 rounds.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd80f2ed-d471-4424-b267-2a122a117a72"), Type = TextBlockType.Text, Text = "You reflect a spell into a shadowy version of itself, in the process depleting the power of the initial spell. During umbral graft's duration, you can use the Steal action to attempt to abscond with spells affecting a foe instead of stealing an item. You can also make one attempt to Steal as part of Casting umbral graft. If you succeed at your check to Steal a spell, randomly determine a spell affecting the foe that has a target entry. That spell ceases to affect the target, and you can either cause the spell to affect you or store it in your shadow. If your attempt to Steal was a critical success, you automatically steal the spell if its level is equal to or lower than umbral graft. If it was a success, you automatically steal it if its level is lower than umbral graft. If you succeeded, but the spell's level was too high to steal automatically, you must attempt a counteract check to see if you steal the spell. You know what the spell is as soon as you steal it. If you store it, you can transfer it to a willing creature as a single action that has the manipulate trait. The spell lasts for its remaining duration, to a maximum of 1 minute, and any time you keep it stored subtracts from its duration normally. The spell gains the shadow trait." };
            yield return new TextBlock { Id = Guid.Parse("ae040f08-4f92-4e82-bdf3-76df3fc6f281"), Type = TextBlockType.Text, Text = "You can't steal constant innate spells that are always active on a creature, such as a choral angel's constant tongues, or innate spells that have special restrictions that remove their ability to target other creatures, such as an imp�s invisibility. At the GM's discretion, you might not be able to steal innate spells with other unusual modifications to the base spell." };
            yield return new TextBlock { Id = Guid.Parse("2a9b900f-881b-4f50-8b8a-c03518e43721"), Type = TextBlockType.Text, Text = "As normal, you can Steal only from a target within your reach. Once you've stolen a spell, you can't attempt to Steal more spells, nor can you choose not to take a spell if you succeed at your Thievery check. When you cast umbral graft, any spells you stole with a previous umbral graft end even if their duration hasn't elapsed. If you're affected by both umbral graft and umbral extraction, you make the choice whether to steal a spell slot, an active spell, or an item each time you Steal." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
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
            builder.Add(Guid.Parse("ab864fa1-67ea-40cf-8cfe-9d3565eb559a"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("897a48d6-dc2f-4965-8dc2-e296330907bf"), Traits.Instances.Shadow.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad3dd07d-a53e-430a-96c8-9c88c12e836d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 137
            };
        }
    }
}
