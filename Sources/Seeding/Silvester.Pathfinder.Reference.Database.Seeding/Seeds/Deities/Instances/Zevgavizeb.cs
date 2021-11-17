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
    public class Zevgavizeb : Template
    {
        public static readonly Guid ID = Guid.Parse("1d7e5b24-e8f6-45e9-b3bf-7ff3e70c869f");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DemonLords.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Zevgavizeb",
                Edicts = "Expand your clutch's domain, dominate your enemies, demonstrate mastery over your crafts and environment, devour the weak.",
                Anathema = "Surrender in combat, express weakness in the face of adversity, show mercy to the weak.",
                Title = "The Beast of Gluttondark",
                AreasOfConcern = "Caverns, reptiles, and troglodytes.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("91d42bbd-bd20-4a33-937b-f878367b87b1"), Type = TextBlockType.Text, Text = ",Pathfinder #153: Life's Long Shadow pg. 67" };
            yield return new TextBlock { Id = Guid.Parse("be8785ca-b5c3-4f48-b94b-b1fe4203b259"), Type = TextBlockType.Text, Text = "The Beast of Gluttondark's sphere of influence encompasses caverns, reptiles, the strong, and all-consuming hunger. A primordial qlippoth-turned-demon lord, Zevgavizeb seems to care little for his followers, and so he is more often propitiated than worshipped." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("2f51db81-1893-47af-9c15-590d05800a7a"), Spells.Instances.MagicFang.ID);
            builder.GainSpecificSpell(Guid.Parse("d4835a0e-cd76-427a-a1cd-b3f79a35f7d5"), Spells.Instances.DinosaurForm.ID);
            builder.GainSpecificSpell(Guid.Parse("49b2d965-b8d2-4d62-85fe-82bb262e4474"), Spells.Instances.Earthquake.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.SpikedGauntlet.ID;
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
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Constitution.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Wyrmkin.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2af781d-2dbf-4fe0-b06e-f1d7a9f4873b"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
