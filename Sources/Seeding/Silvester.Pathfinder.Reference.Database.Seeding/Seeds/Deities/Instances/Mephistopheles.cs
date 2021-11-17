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
    public class Mephistopheles : Template
    {
        public static readonly Guid ID = Guid.Parse("5563edc0-8286-493d-9f3e-14f3cdb9a673");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Archdevils.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Mephistopheles",
                Edicts = "Master laws and use them to your benefit, enable the desperate, excoriate others with veiled mockery.",
                Anathema = "Break a contract you made, get caught breaking the law.",
                Title = "The Crimson Son",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("fb8e8df8-bdea-479c-9bd9-75422abdd26a"), Type = TextBlockType.Text, Text = "The archdevil Mephistopheles was shaped of the ashes and fire of Hell itself to convey the plane's will. The lord of Caina, Hell's eighth layer, he is a conniving schemer and a brilliant politician, quick to offer insults both blatant and cloaked behind silvered words. A master of rule, law, and words, he is the creator of the renowned agreements known as infernal contracts, crafted to damn mortal souls through their own ambitions. He views mortals as nothing more than a source of power for the infernal realm, but he nevertheless has followers who share his affinity for the power of law and loophole." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("93344ea6-f2f4-4897-b257-75c3babaa224"), Spells.Instances.MessageRune.ID);
            builder.GainSpecificSpell(Guid.Parse("d049a0b3-13e2-4487-9dec-5e8b41fec051"), Spells.Instances.BlisteringInvective.ID);
            builder.GainSpecificSpell(Guid.Parse("4f4bdd35-46a2-430e-add3-2eabfe086ba4"), Spells.Instances.SubconsciousSuggestion.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Trident.ID;
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
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Glyph.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Secrecy.ID;
            yield return Domains.Instances.Tyranny.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("2d5408b3-2cd2-4ab0-b892-1aa1f15234b6"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
