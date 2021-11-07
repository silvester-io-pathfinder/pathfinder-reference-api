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
    public class Barzahk : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.MonitorDemigods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Barzahk",
                Edicts = "Aid travelers and those who return from the dead, tend to roadside graves, find missing objects or people.",
                Anathema = "Celebrate specific calendar dates over others, avoid travel or change, freeze time for an object or creature.",
                Title = "The Passage",
                AreasOfConcern = "Compasses, travelers, and vigils.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Appearing as an enormous migratory bird—usually a corvid, but sometimes a songbird—draped in robes and carrying a tombstone lock and a giant bone key, Barzahk the Passage is the psychopomp usher who maintains the Dead Roads, the secret back routes between the planes and the mortal world. Among mortals, they are worshipped as a patron of compasses, travelers, and vigils. Barzahk is tasked with transporting the souls of those who die far from home to ensure that they reach their proper destination. Unfortunately, Barzahk wanders far and wide, and so they rarely attend to this duty. Thus his followers, both psychopomps and mortals, take it upon themselves to care for lost souls, both literal and figurative. Like their patron, followers of Barzahk are often migratory, helping those they find along the way." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Longstrider.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Knock.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Teleport.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Club.ID;
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
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Death.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Travel.ID;
            yield return Domains.Instances.Vigil.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
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
