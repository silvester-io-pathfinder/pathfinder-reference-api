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
        public static readonly Guid ID = Guid.Parse("e724f1b6-d3fe-4c96-b487-f9bdef144194");

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
            
            yield return new TextBlock { Id = Guid.Parse("2902f723-1d91-4dd6-acb6-46cec7f417cc"), Type = TextBlockType.Text, Text = "Appearing as an enormous migratory bird—usually a corvid, but sometimes a songbird—draped in robes and carrying a tombstone lock and a giant bone key, Barzahk the Passage is the psychopomp usher who maintains the Dead Roads, the secret back routes between the planes and the mortal world. Among mortals, they are worshipped as a patron of compasses, travelers, and vigils. Barzahk is tasked with transporting the souls of those who die far from home to ensure that they reach their proper destination. Unfortunately, Barzahk wanders far and wide, and so they rarely attend to this duty. Thus his followers, both psychopomps and mortals, take it upon themselves to care for lost souls, both literal and figurative. Like their patron, followers of Barzahk are often migratory, helping those they find along the way." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("4b46beb4-c3a4-4fc6-ae3f-ea90f7682816"), Spells.Instances.Longstrider.ID);
            builder.GainSpecificSpell(Guid.Parse("a7ce1e38-2734-40c3-806f-25d99c7bbe41"), Spells.Instances.Knock.ID);
            builder.GainSpecificSpell(Guid.Parse("a38e4562-2703-44b8-ae0c-ee4d802b6bbc"), Spells.Instances.Teleport.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Club.ID;
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
                Id = Guid.Parse("5728c932-421f-4310-aea4-bf9fe3a65293"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
