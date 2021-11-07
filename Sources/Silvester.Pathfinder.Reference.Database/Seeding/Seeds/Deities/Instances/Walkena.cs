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
    public class Walkena : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Walkena",
                Edicts = "Uphold Mzali's laws, tend to Walkena and obey his instructions, oppose exploitation of the Mwangi Expanse.",
                Anathema = "Consort or trade with non-Mwangi peoples, defy Walkena's orders.",
                Title = "The God-King",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = ",Gods & Magic pg. 130" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "In the city-state of Mzali in the Mwangi Expanse resides an undead being of immense power, a child-sized god-king. In the past, Walkena was a mortal descendant of the gods that ruled over Mzali in ancient times, one of the sun kings from an old empire and a golden age of the city. Ages later, his preserved body was found by members of the Council of Mwanyisa, who ruled Mzali at that time. Believing him to be an omen of the city's impending resurgence, the council took him to put him on display in Mzali. When an army from the Sargavan city of Kalabuto attacked the city, Walkena awoke—this time as an undead creature—and slew each of the invaders in a purging rain of fire." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.BurningHands.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Fireball.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WallOfFire.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Spear.ID;
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
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Sun.ID;
            yield return Domains.Instances.Tyranny.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 143
            };
        }
    }
}
