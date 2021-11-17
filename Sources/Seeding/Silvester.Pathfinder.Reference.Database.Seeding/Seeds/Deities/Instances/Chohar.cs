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
    public class Chohar : Template
    {
        public static readonly Guid ID = Guid.Parse("e4b8ad45-3191-4e35-97ba-dfef60f09132");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OldSunGods.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Chohar",
                Edicts = "Finish any and all tasks you accept, bring those who are cruel to justice, show pride in your home and your heritage.",
                Anathema = "Break your word, be cruel to the innocent, rebuke someone due to their homeland.",
                Title = "The Golden Lion",
                AreasOfConcern = "Justice, loyalty, and work.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("cb6d797e-8bed-4ab2-b6c3-016d8ef60cf3"), Type = TextBlockType.Text, Text = "The Lion God of justice, loyalty, and work. He is most commonly depicted as a golden lion with a sun for a mane. Some priests of Walkena claim that the child god is a descendant of Chohar, because of their shared love of justice—yet Walkena's justice is vindictive and cruel, while Chohar's is one of duty." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("783d7179-06c2-4788-b10e-23d3025fd728"), Spells.Instances.BurningHands.ID);
            builder.GainSpecificSpell(Guid.Parse("aae8a10e-76a3-4989-81f6-034866760576"), Spells.Instances.Fireball.ID);
            builder.GainSpecificSpell(Guid.Parse("d9f8f469-57ad-4fcf-abf3-bd6fc788903e"), Spells.Instances.FireShield.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Starknife.ID;
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
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Cities.ID;
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Fire.ID;
            yield return Domains.Instances.Sun.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9faeb47-6539-4a87-b837-391afdf980a0"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 100
            };
        }
    }
}
