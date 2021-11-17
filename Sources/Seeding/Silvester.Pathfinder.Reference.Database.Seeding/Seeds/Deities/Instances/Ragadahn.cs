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
    public class Ragadahn : Template
    {
        public static readonly Guid ID = Guid.Parse("66eb78d0-e276-4117-a4b5-f3333763b785");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Eldest.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Ragadahn",
                Edicts = "Draw spirals, seek primordial secrets, use poison, always carry water.",
                Anathema = "Suffer a linnorm's death curse, destroy a fossil.",
                Title = "The Water Lord",
                AreasOfConcern = "Oceans, linnorms, and sinuous spirals.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("5421160c-e5b0-423d-961c-becfb80df92e"), Type = TextBlockType.Text, Text = "As boastful as he is bestial, Ragadahn the Water Lord is the Eldest of oceans, linnorms, and sinuous spirals. He appears as a great serpentine dragon in the First World's seas, but he is widely traveled and takes other forms as needed to pursue both martial conquests and amorous affairs. He is widely believed to be the progenitor of all linnorms, and he claims to be the progenitor of all dragons. True dragons stridently contest this assertion, although they wisely decline to do so when in Ragadahn's majestic presence. Failure to deliver proper respect to the arrogant Ragadahn invites his legendary ire, and no supplicant can ever be too flattering for his tastes. Yet for all his tempestuous nature, he is wise, and he holds much otherwise lost and forgotten knowledge." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("4516dd51-3527-4c5c-916b-3c7a50dafb3b"), Spells.Instances.HydraulicPush.ID);
            builder.GainSpecificSpell(Guid.Parse("c77c9a27-76c2-4d95-b680-ba0d2f06b8ca"), Spells.Instances.FeetToFins.ID);
            builder.GainSpecificSpell(Guid.Parse("77a502c3-748a-4482-bc8c-4a2fb02c3960"), Spells.Instances.PurpleWormSting.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Whip.ID;
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
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Vigil.ID;
            yield return Domains.Instances.Water.ID;
            yield return Domains.Instances.Wyrmkin.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e7bf06a-066d-4dd0-a20c-79c7de36d467"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
