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
        public static readonly Guid ID = Guid.Parse("");

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
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "All Szuriel has ever known is war. In life she was first a paladin, then excommunicated from her church for heresy. In response, she slaughtered her way to power until she was crowned empress, then subsequently had every member of her former faith crucified. She went on to wage several brutal wars against neighboring kingdoms until an assassin's dagger found her heart. Sent to Abaddon, she rose quickly through the ranks of daemonkind, and when she saw weakness in the Horseman of War, she slew him in battle, claiming his title for herself." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Szuriel appears as a tragic angel with beautiful golden hair, magnificent wings, and polished obsidian eyes that continuously weep blood. She resides in the Cinder Furnace, her corner of Abaddon where instruments of war are forged from the fires of burning souls. Szuriel commands one of the largest standing armies in all of existence, countless daemonic soldiers ready to wage war. All fear oblivion at the hands of Szuriel and her army. The Horseman of War is always happy to lend her powers, warriors, and devastating discoveries across the planes. So long as war continues, more souls are pulled into her ever-burning furnace." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.BurningHands.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Haste.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WeaponStorm.ID);
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
