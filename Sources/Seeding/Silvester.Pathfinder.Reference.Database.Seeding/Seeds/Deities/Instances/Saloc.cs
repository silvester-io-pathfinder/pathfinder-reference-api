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
    public class Saloc : Template
    {
        public static readonly Guid ID = Guid.Parse("07895c43-c956-4c91-bd90-7bf2dcd78f9d");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.MonitorDemigods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Saloc",
                Edicts = "Help creatures grow and find purpose, offer second chances to failures, study different perspectives on ethics.",
                Anathema = "Manipulate or remove a creature's emotions with magic, spread nihilism or hopelessness.",
                Title = "The Minder of Immortals",
                AreasOfConcern = "Agency, bronze, and education.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("e35ebaed-d62e-4e13-b276-844a4545aac2"), Type = TextBlockType.Text, Text = "Ruler of the planar metropolis of Spire's Edge in the Boneyard, the psychopomp usher Saloc is humanoid, but their face is devoid of features save stag horns, and two golden rings lined with eyes constantly rotate about their body. As a defense counsel in Pharasma's court, the Minder of Immortals argues that a person's intentions should be considered in equal part to the consequences of their actions when deciding their soul's afterlife. Saloc has even been known to resurrect condemned souls to give them a second chance to prove themselves. Mortals revere Saloc as the patron of agency, bronze, and education. These followers are people who seek to improve themselves or others, including both students and teachers. Some seek to earn their freedom from earthly prisons, while others wish to change their ways to avoid punishment in the hereafter." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("01c83092-d605-4cde-94c4-99b88c7a2a9e"), Spells.Instances.ShareLore.ID);
            builder.GainSpecificSpell(Guid.Parse("aab848d9-7efa-41c2-a19c-07e9b02eb3b0"), Spells.Instances.Hypercognition.ID);
            builder.GainSpecificSpell(Guid.Parse("339d28b8-e26e-4abc-9d57-8922222d9b91"), Spells.Instances.DreamingPotential.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Guisarme.ID;
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
            yield return Skills.Instances.Diplomacy.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Death.ID;
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Knowledge.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("846e284b-5c79-408e-aa0e-8b57c0e52374"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
