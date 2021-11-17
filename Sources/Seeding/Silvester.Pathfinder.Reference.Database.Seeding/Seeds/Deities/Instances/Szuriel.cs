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
    public class Szuriel : Template
    {
        public static readonly Guid ID = Guid.Parse("d2633e1f-5d71-4b1b-b1ed-29fd510f6818");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Horsemen.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Szuriel",
                Edicts = "End all mortal life through war, obliterate faith.",
                Anathema = "Show mercy to creatures who do not worship Szuriel, choose to marry or have children.",
                Title = "Angel of Desolation",
                AreasOfConcern = "War.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("06c0f345-51a2-41b5-b0a0-1dbdf7ce9e75"), Type = TextBlockType.Text, Text = "All Szuriel has ever known is war. In life she was first a paladin, then excommunicated from her church for heresy. In response, she slaughtered her way to power until she was crowned empress, then subsequently had every member of her former faith crucified. She went on to wage several brutal wars against neighboring kingdoms until an assassin's dagger found her heart. Sent to Abaddon, she rose quickly through the ranks of daemonkind, and when she saw weakness in the Horseman of War, she slew him in battle, claiming his title for herself." };
            yield return new TextBlock { Id = Guid.Parse("fc0dfd6a-3541-4dd8-be16-8868a2b82939"), Type = TextBlockType.Text, Text = "Szuriel appears as a tragic angel with beautiful golden hair, magnificent wings, and polished obsidian eyes that continuously weep blood. She resides in the Cinder Furnace, her corner of Abaddon where instruments of war are forged from the fires of burning souls. Szuriel commands one of the largest standing armies in all of existence, countless daemonic soldiers ready to wage war. All fear oblivion at the hands of Szuriel and her army. The Horseman of War is always happy to lend her powers, warriors, and devastating discoveries across the planes. So long as war continues, more souls are pulled into her ever-burning furnace." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("ce0a62e8-1217-4138-8b31-8a4a8e15c20a"), Spells.Instances.BurningHands.ID);
            builder.GainSpecificSpell(Guid.Parse("1f125a93-c916-48b9-8320-f0ddce198f8f"), Spells.Instances.Haste.ID);
            builder.GainSpecificSpell(Guid.Parse("9f8acdba-79a4-4ee7-ba09-bec3751ba3d8"), Spells.Instances.WeaponStorm.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Greatsword.ID;
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
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Constitution.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Ambition.ID;
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Fire.ID;
            yield return Domains.Instances.Might.ID;
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
                Id = Guid.Parse("a443d2cc-9776-4f83-b0af-40cc2e558da9"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
