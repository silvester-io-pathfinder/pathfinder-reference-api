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
    public class Charon : Template
    {
        public static readonly Guid ID = Guid.Parse("82e599a1-f046-43fa-8a97-f49b91e58fd7");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Horsemen.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Charon",
                Edicts = "End all mortal life, exploit those who fear death.",
                Anathema = "Offer anything for free, extend mortal lifespans, grant true salvation to the doomed or dying.",
                Title = "The Boatman",
                AreasOfConcern = "Death.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("48168b1b-dc36-4425-a2d9-70e3b88ad17a"), Type = TextBlockType.Text, Text = "The First Horseman, eldest of his counterparts and the Boatman of the Styx, is a patient and cunning figure. Content to allow plans to take hold over time, Charon freely offers his power only to collect on his bargain decades or even centuries later. As the Horseman of Death, Charon concerns himself with miserable, pointless deaths that are devoid of any faith, mercy, or meaning, dragging those who perish in the depths of hopelessness and nihilism down into Abaddon and oblivion." };
            yield return new TextBlock { Id = Guid.Parse("a66ad2d6-ddad-4b9a-8376-528803568b63"), Type = TextBlockType.Text, Text = "Charon is the last surviving member of the original Horsemen who overthrew the First Daemon in their fit of jealous contempt. Holding knowledge from the earliest days of existence, he alone knows Abaddon's true history, but he keeps it to himself. This allows him to exploit opportunities with curious mortals, sweeping more souls into his dread kingdom." };
            yield return new TextBlock { Id = Guid.Parse("528e6a4d-8bfe-4c98-b798-9bad3478df6b"), Type = TextBlockType.Text, Text = "Charon appears as a tall, looming man dressed in a frayed cloak and gripping a lantern staff firmly in one hand, but it is widely believed that this form is a facade. His true face may be unknowable, hidden away at the end of the Styx within his sunken palace, the Drowning Court. Some theorize that this form is nothing more than a mouthpiece for a far more alien entity that lies beneath the waters of the Styx. Whatever the case, Charon is a timeless being whose bargains, promises, and bottomless hunger stretch back to the earliest days." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("eb0f7952-3ef0-45ac-85cf-2d0297c969b2"), Spells.Instances.GrimTendrils.ID);
            builder.GainSpecificSpell(Guid.Parse("a65ca97e-a076-4bae-b88d-d67069acce4a"), Spells.Instances.CrushingDespair.ID);
            builder.GainSpecificSpell(Guid.Parse("58088086-1e49-4cd4-9f5a-f1d8bcc68859"), Spells.Instances.Weird.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Staff.ID;
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
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Occultism.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Death.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Soul.ID;
            yield return Domains.Instances.Water.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("39f3dd43-b626-4281-876d-b6269c397a8f"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
