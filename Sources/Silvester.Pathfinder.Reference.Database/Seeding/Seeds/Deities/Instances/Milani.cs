using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities.Instances
{
    public class Milani : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "Milani",
                Edicts = "Confront oppression in all its forms, defend the common folk, overcome despair to seize victory.",
                Anathema = "Abandon those in need, enslave or oppress others, harm the innocent through direct or inadvertent action.",
                Title = "The Everbloom",
                AreasOfConcern = "Devotion, hope, and uprisings.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Milani is the patron mother of those who war against oppression, rewarding those willing to sacrifice their lives and use whatever tools are available to fight for those who cannot defend themselves, especially people who have been captured or enslaved. Throughout Golarion, Milani is also known as the Everbloom, as the symbol of her church is a beautiful rose growing from blood-soaked soil." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MageArmor.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Enthrall.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FireShield.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Morningstar.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            
            return new DivineIntercession
            {
                Id = Guid.Parse(""),
                Description = "The Everbloom rewards those who put the needs of others first, especially when combating oppressive forces, and she doesn’t hesitate to impede any who enslave others or persecute the defenseless. ",
                MinorBoon = "Once, when you roll a failure on a Deception or Stealth check to protect an uprising from discovery, you critically succeed instead. Milani typically grants this boon for extremely significant checks on which the uprising's survival hinges.",
                ModerateBoon = "When you use it to protect others, your shield blooms with roses brimming with razor-sharp thorns. You gain the Shield Warden feat, even if you don't meet its prerequisites. If you already had that feat, if your shield takes damage from a melee Strike in defense of your ally, the attacker takes piercing damage equal to half the shield's Hardness.",
                MajorBoon = "You gain +4 status bonus to checks to Request during attempts to satisfy one of Milani's edicts. Once per day, you can sound a battle cry that grants creatures within a 30-foot emanation the effects of freedom of movement and affects all doors, locks, containers, and other bindings used to restrain or imprison others with the effects of the knock spell.",
                MinorCurse = "A magical wreath of thorny, bloodred roses endlessly grows from your scalp, no matter how much you try to remove it. You gain weakness 5 to piercing damage.",
                ModerateCurse = "Ropes, chains, manacles, and other equipment used to bind or constrain become blazing hot in your hands, bursting into flame or melting as if engulfed in a forge. When you attempt to hold such an item, you take 2d6 fire damage and the item is destroyed.",
                MajorCurse = "Small wounds bleed more than seems physically possible. Whenever you take slashing or piercing damage, you also take persistent bleed damage equal to the level of the creature or effect that inflicted the damage.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 7
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Society.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 66
            };
        }
    }
}
