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
    public class Ydajisk : Template
    {
        public static readonly Guid ID = Guid.Parse("f31ec4d3-e7a2-4a99-9a32-0a9fef2a7e31");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.MonitorDemigods.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "Ydajisk",
                Edicts = "Create using words, chronicle languages and prevent them from dying, help language evolve.",
                Anathema = "Ban or discourage a language, explain a secret language or slang to outsiders, destroy literary works.",
                Title = "Mother of Tongues",
                AreasOfConcern = "Language evolution, lost words, and slang.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("e3344171-d20b-4192-8c1e-9d0eb440e058"), Type = TextBlockType.Text, Text = "The protean lord of language evolution, lost words, and slang, Ydajisk manifests as a protean with six arms and a cobra's hood, surrounded by a cloud of drifting sounds, symbols, shapes, and myriad other sensory experiences that shift endlessly in and out of existence. Closer inspection reveals that their body is made from interlacing strands of poetic protean script. Ydajisk is also called the Mother of Tongues, though like all proteans, their gender changes as they will. Followers of Ydajisk are wanderers, reviving dead languages from ancient ruins, chronicling the dying tongues of cultures in decline, and discovering or inventing new words. All such knowledge acquired by agents of the Mother of Tongues passes into Ydajisk's realm, the Library of Stolen Words, where it is transcribed into books or stored in magical containers, alongside scrolls and tomes considered long lost by mortal scholars." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("a3473ffc-42f0-402a-a041-7899680cb0a8"), Spells.Instances.MessageRune.ID);
            builder.GainSpecificSpell(Guid.Parse("5dfcf8bd-151f-4c8a-a534-340e6192be00"), Spells.Instances.BlisteringInvective.ID);
            builder.GainSpecificSpell(Guid.Parse("78b180cf-1560-4d11-b8c6-e7c2ededf4be"), Spells.Instances.Glibness.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Greatclub.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            
            yield return UnarmedWeapons.Instances.Jaws.ID;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Society.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Glyph.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Trickery.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("4cd81b8b-5748-455d-a7ba-3f6bad7e2342"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
