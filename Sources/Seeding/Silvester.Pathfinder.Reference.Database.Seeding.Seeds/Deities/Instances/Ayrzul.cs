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
    public class Ayrzul : Template
    {
        public static readonly Guid ID = Guid.Parse("9bffcd9a-4a31-4eb9-a921-d7b4445be3f9");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.ElementalLords.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Ayrzul",
                Edicts = "Use the strength of stone to protect yourself and your secrets, obscure your true motives, slowly poison others.",
                Anathema = "Remove a creature's petrified condition, make a fire larger or hotter than necessary.",
                Title = "The Fossilized King",
                AreasOfConcern = "Buried secrets, earth, and metal.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("83050cc9-9a36-47bb-b619-ff6a09be5db9"), Type = TextBlockType.Text, Text = "Lord of buried secrets, earth, and metal, the Fossilized King Ayrzul is a mystery even on thePlane of Earth. No one has seen the elemental lord of earth outside of his realm, the Blistering Labyrinth, and few know the truth of Ayrzul's nature or the form he takes when he appears. Some say he is an immense, undead crystalline dragon, an ancient genie wizard, or even a discarded splinter from some long-forgotten deity, shed before their primeval destruction. His power, motives, and origins are likewise the subjects of innumerable rumors. This speculation is all inconsequential to the Fossilized King; even the politics of his plane falls outside his notice. Instead, the lord of Earth spends his time plotting against his bitter rival,Ymeri, the elemental lord of fire." };
            yield return new TextBlock { Id = Guid.Parse("e1bb631c-9f9b-4f2f-b5cd-ae5a6240c4a5"), Type = TextBlockType.Text, Text = "Ayrzul's followers include xiomorns—Sairazul'schildren whom he has stolen—a handful ofmephitsand other elementals, and groups of humanoids on theMaterial Planewith an interest in the unseen hostility of the earth." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("5f41e199-281f-47aa-b6ca-680000d9f9c1"), Spells.Instances.Shockwave.ID);
            builder.GainSpecificSpell(Guid.Parse("d4c773e3-ecd9-4b6a-8130-09b7d0b744b1"), Spells.Instances.SummonElemental.ID);
            builder.GainSpecificSpell(Guid.Parse("56e1be25-6160-426a-99c7-50934bd501ca"), Spells.Instances.FleshToStone.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Morningstar.ID;
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
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Constitution.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Earth.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Secrecy.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("a33db0fc-38c3-4d4a-b286-a6d7572dc1cc"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
