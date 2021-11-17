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
    public class Kazutal : Template
    {
        public static readonly Guid ID = Guid.Parse("b8e69e19-e60a-431f-bf83-7133b1f3afad");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Kazutal",
                Edicts = "Defend your people, provide for those who need you, oppose those who unjustly lord power over others, demonstrate devotion to things you love.",
                Anathema = "Own a slave, force a creature to act against its will, refuse to give aid to an ally, enforce an unjust law.",
                Title = "Mother Jaguar",
                AreasOfConcern = "Safety, liberty, and community.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("2119964b-c90b-409a-8b1e-f3249fb1a0ee"), Type = TextBlockType.Text, Text = "Kazutal, also known as Mother Jaguar or Lady Jaguar, is an old deity, revered for thousands of years on the continent of Arcadia. Ages ago, she was worshipped in the Razatlani Empire as a goddess of might and protection in war. After the catastrophe of Earthfall, however, her edge softened; those who struggled to put the world back together called upon her to protect their neighbors and came together under her guidance to build strong bonds of community and support." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("68dca661-3fb7-4ed1-9570-802515e385d7"), Spells.Instances.MageArmor.ID);
            builder.GainSpecificSpell(Guid.Parse("bb3ecf7d-afab-4051-b577-9d0514d22f84"), Spells.Instances.AnimalForm.ID);
            builder.GainSpecificSpell(Guid.Parse("c475bfa6-3d1a-4f0e-9917-475fe7a01688"), Spells.Instances.Stoneskin.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Machete.ID;
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
            
            return new DivineIntercession
            {
                Id = Guid.Parse("771561b5-7102-450a-ad9f-30a1864ceac6"),
                Description = "Mother Jaguar rewards those who uphold a sense of community and bestows punishments upon those who use her name and convictions to admonish or exclude perceived outsiders.",
                MinorBoon = "With Kazutal's blessing, food tastes richer. Any meal that you eat tastes delicious and has improved nutritional value. This doesn't protect you from anything dangerous in your food, but it also doesn't prevent you from tasting those dangerous elements of the food.",
                ModerateBoon = "You always seem to find safe shelter when you most need it. Once per day, you can cast rope trick as a divine innate spell.",
                MajorBoon = "Kazutal smiles upon those who seek to offer aid, no matter how meek or helpless they may be. Any time creatures attempt a check to Aid you, they can choose to automatically succeed. If a creature chooses to roll for the attempt and rolls a success, it gets a critical success instead, granting a +4 circumstance bonus even if it doesn't have legendary proficiency in that skill. You gain the same benefits when you attempt to Aid others.",
                MinorCurse = "Community opinion turns against you. Humanoids in your community who would normally start as indifferent toward you start as unfriendly instead.",
                ModerateCurse = "Your strength betrays you, preventing you from taking more than your fair share. You are enfeebled 2 and can't carry anything beyond the gear you are actively wearing or using.",
                MajorCurse = "You are cursed to depend upon others for your survival. You can't eat anything, drink anything, or use any gear or magic items unless they were willingly given to you by someone who rightfully owns them. Work-arounds like having an ally strip the gear from someone's corpse and then give it to you willingly automatically fail.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("d6a8dabe-1e60-48d4-9ba3-c250abd390d5"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 7
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Society.ID;
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
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("666e0099-586c-4294-8f4e-56a656d0ae75"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 64
            };
        }
    }
}
