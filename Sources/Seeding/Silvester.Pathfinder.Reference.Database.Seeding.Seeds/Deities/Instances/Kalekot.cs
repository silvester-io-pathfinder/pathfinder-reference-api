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
    public class Kalekot : Template
    {
        public static readonly Guid ID = Guid.Parse("59db52a0-8854-441d-a940-49442c3bb3ed");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "Kalekot",
                Edicts = "Spread fear in others, hide dangerous secrets, shock the self-righteous, kill the guilty to protect the innocent.",
                Anathema = "Abuse someone you have accepted power over, allow a victim to escape due to gloating, snivel before authority, shout.",
                Title = "The Winnower",
                AreasOfConcern = "Fear, silence, safekeeping, the reviled.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("8d06190b-95cb-4081-892f-2b2ef882de10"), Type = TextBlockType.Text, Text = "The guardian of deadly secrets and dangerous places, Kalekot is a bogeyman to most, murderer of the guilty and devourer of those who trespass. To those that society can't punish, Kalekot is executioner, striking from the shadows and leaving bodies to rot on the ground. To those lost at night, Kalekot is a silent follower, a guardian from danger. Those few who have glimpsed him describe a figure with withered skin and a snake's twisting spine. He always conceals his features behind an eyeless mask, its mouth filled with serpent's teeth, each fang the size of an elephant's tusk." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("e3331fc9-ce53-45dd-8afa-3bea51304989"), Spells.Instances.PassWithoutTrace.ID);
            builder.GainSpecificSpell(Guid.Parse("f29a8ab7-5057-4e0c-b18b-603a4039f2e8"), Spells.Instances.Paralyze.ID);
            builder.GainSpecificSpell(Guid.Parse("e16aff6c-2568-4e6b-9547-b1b544eabaa4"), Spells.Instances.PhantasmalKiller.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Dagger.ID;
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
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Death.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Nightmares.ID;
            yield return Domains.Instances.Secrecy.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("545ef79f-db17-4c4b-92e8-0d9dca9246ac"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 137
            };
        }
    }
}
