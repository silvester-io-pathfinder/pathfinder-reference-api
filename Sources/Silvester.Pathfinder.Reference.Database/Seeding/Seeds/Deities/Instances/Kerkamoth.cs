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
    public class Kerkamoth : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.MonitorDemigods.ID,
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                Name = "Kerkamoth",
                Edicts = "Clean cluttered spaces, embrace moments of silence.",
                Anathema = "Attempt to preserve something indefinitely, perform an act of wanton and significant destruction.",
                Title = "The Waiting Void",
                AreasOfConcern = "Emptiness, entropy, and stillness.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Also known as the Waiting Void, the unseen Kerkamoth is the primordial inevitable of emptiness, entropy, and stillness. Though many people view decay and entropy as manifestations of chaos, followers of Kerkamoth understand that in an orderly universe, the end of one cycle makes way for the beginning of a new cycle. These worshippers track such transitions and work to properly dispose of those things that have outlived their usefulness, whether it's cleaning a cluttered closet or demolishing an old building. Yet, Kerkamoth opposes those who destroy with abandon and no greater purpose, which often brings them in conflict with daemons, demons, and proteans. Though they favor areas of emptiness and silence to commune with their patron, worshippers of Kerkamoth recognize that these too cannot last forever, inevitably to be filled with new creations." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PenumbralShroud.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ShadowSiphon.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Disintegrate.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Warhammer.ID;
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
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Darkness.ID;
            yield return Domains.Instances.Decay.ID;
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Void.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
