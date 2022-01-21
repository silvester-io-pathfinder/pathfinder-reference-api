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
    public class Dagon : Template
    {
        public static readonly Guid ID = Guid.Parse("38979af6-17f7-4c0f-99ca-538868ff700a");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DemonLords.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Dagon",
                Edicts = "Swim underwater, improve your own strength, encourage the spread of dangerous sea monsters.",
                Anathema = "Break a sworn oath, settle in a land-locked area, share Dagon's secrets with outsiders.",
                Title = "The Shadow in the Sea",
                AreasOfConcern = "Deformity, the sea, and sea monsters.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("ce7ff2e4-d03c-46b1-8b58-90b50e3bddee"), Type = TextBlockType.Text, Text = "Dagon, the Shadow in the Sea, is the demon lord of deformity, the sea, and sea monsters. He holds court in an infinite ocean covered in disconcerting islands and deep-sea trenches filled with incomprehensible sunken cities. He appears as a massive creature with the lower body of an eel, a head reminiscent of deep-sea predators, and four thrashing tentacles in place of arms. Dagon began as a qlippoth, and no mortal understands his transformation into a demon lord, though it earned him the enmity of his former kin. Dagon is primarily worshipped by boggards, sahuagin, skum, and marsh giants, though desperate or depraved coastal villages have been known to pledge themselves to the demon lord." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("ec1d1c6d-47af-4dd6-bcdf-c93d009ca2f2"), Spells.Instances.HydraulicPush.ID);
            builder.GainSpecificSpell(Guid.Parse("ef1ea8a5-fcce-4cbd-a2ea-7df89e9119c3"), Spells.Instances.FeetToFins.ID);
            builder.GainSpecificSpell(Guid.Parse("316c4094-1a1a-454b-8bc4-ab57609b97fd"), Spells.Instances.ChainLightning.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Trident.ID;
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
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Water.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("499902d6-9e5d-44be-9ac6-ae0394f7497b"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
