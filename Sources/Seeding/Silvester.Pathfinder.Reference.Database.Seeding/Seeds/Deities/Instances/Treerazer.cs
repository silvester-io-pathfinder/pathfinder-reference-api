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
    public class Treerazer : Template
    {
        public static readonly Guid ID = Guid.Parse("f23d9052-c1ca-48e3-8846-e353a730f85d");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DemonLords.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Treerazer",
                Edicts = "Corrupt plant life with evil or fungal influences, slay elves, feast on rotten flesh or fungus.",
                Anathema = "Grant mercy to elves, plant trees, encourage natural plant growth.",
                Title = "Lord of the Blasted Tarn",
                AreasOfConcern = "Pollution and the corruption of nature.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("7a41bf76-68bf-443f-8369-a3fe1c687b4e"), Type = TextBlockType.Text, Text = "Treerazer, the Lord of the Blasted Tarn, is a nascent demon lord of pollution and the corruption of nature, believed by many to be an exiled servant or spawn ofCyth-V'sugwho was banished to Golarion after a failed attempt at supplanting the demon lord. Though Treerazer is a nascent demon lord, and thus lacks the power of a true demon lord, he is perhaps most noteworthy among those who have a stake in Golarion due to his physical presence within the Tanglebriar, a corrupted, fetid swamp that was once the southern edges of the elven nation of Kyonin. He is served by devoted cultists in and around Kyonin, though small pockets of believers can be found around Golarion working furtively to free him in hopes of gaining his favor upon his ascension. Treerazer's religious symbol is a bleeding dead tree that's been split in half." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("aa8fcd72-efa6-429d-a654-fce39756b5a3"), Spells.Instances.GrimTendrils.ID);
            builder.GainSpecificSpell(Guid.Parse("3a341b0b-ea0e-4249-a5c8-6d35411b9cfd"), Spells.Instances.WallOfThorns.ID);
            builder.GainSpecificSpell(Guid.Parse("bb552bf4-0372-46d2-8e20-50469c1313c8"), Spells.Instances.TanglingCreepers.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.BattleAxe.ID;
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
            yield return Skills.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Nightmares.ID;
            yield return Domains.Instances.Tyranny.ID;
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
                Id = Guid.Parse("fb17a2f1-2f74-4b92-b0b9-c808901ac9db"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 312
            };
        }
    }
}
