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
        public static readonly Guid ID = Guid.Parse("");

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
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Treerazer, the Lord of the Blasted Tarn, is a nascent demon lord of pollution and the corruption of nature, believed by many to be an exiled servant or spawn ofCyth-V'sugwho was banished to Golarion after a failed attempt at supplanting the demon lord. Though Treerazer is a nascent demon lord, and thus lacks the power of a true demon lord, he is perhaps most noteworthy among those who have a stake in Golarion due to his physical presence within the Tanglebriar, a corrupted, fetid swamp that was once the southern edges of the elven nation of Kyonin. He is served by devoted cultists in and around Kyonin, though small pockets of believers can be found around Golarion working furtively to free him in hopes of gaining his favor upon his ascension. Treerazer's religious symbol is a bleeding dead tree that's been split in half." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GrimTendrils.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WallOfThorns.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TanglingCreepers.ID);
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 312
            };
        }
    }
}
