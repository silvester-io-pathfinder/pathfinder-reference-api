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
    public class Angazhan : Template
    {
        public static readonly Guid ID = Guid.Parse("44885d44-d52d-4fc0-9729-e9aee3f4fdb1");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DemonLords.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Angazhan",
                Edicts = "Commit acts of brutal violence, test yourself against nature, make animals more dangerous.",
                Anathema = "Cower from fights, allow yourself to be resurrected instead of reincarnated.",
                Title = "The Ravenous King",
                AreasOfConcern = "Apes, jungles, tyrants.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("9a33fa7c-cdb5-41dd-bd39-786a23e30e36"), Type = TextBlockType.Text, Text = ",Gods & Magic pg. 124" };
            yield return new TextBlock { Id = Guid.Parse("0d0fc75c-55a4-46b3-b7c8-da2cfa39580a"), Type = TextBlockType.Text, Text = "Angazhan is a name well known in the Mwangi Expanse, and for good reason. Called the Ravenous King and Demon Lord of Beasts, he appears as an enormous and terrifying red-furred ape with six long fingers on each hand, massive and clawed. His red eyes, twisted horns, and viciously sharp fangs give him a demonic appearance. His followers range fromgnolltocharau-kastonalfeshnee demonsthat number in the thousands." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("5e0df598-1d6d-4331-b2f3-463b283f06e9"), Spells.Instances.MagicFang.ID);
            builder.GainSpecificSpell(Guid.Parse("54d01624-1d0a-4348-a8ec-a7b41d9e0af6"), Spells.Instances.AnimalForm.ID);
            builder.GainSpecificSpell(Guid.Parse("da32824d-198e-4d1d-89bc-24562016ba49"), Spells.Instances.MoonFrenzy.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Fist.ID;
            yield return Items.MeleeWeapons.Instances.Spear.ID;
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
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Tyranny.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("25c47429-f29d-45d6-8b57-8a32c115415c"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 133
            };
        }
    }
}
