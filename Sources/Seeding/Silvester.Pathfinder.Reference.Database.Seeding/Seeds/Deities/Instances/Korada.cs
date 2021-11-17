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
    public class Korada : Template
    {
        public static readonly Guid ID = Guid.Parse("36186425-cc72-41d2-b454-23d52a6977df");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Korada",
                Edicts = "Forgive those who have wronged you, embrace a peaceful mindset, seek and allow redemption.",
                Anathema = "Cause lethal harm to a creature, deny a repentant creature an opportunity for redemption, ask a retired warrior to fight.",
                Title = "The Open Hand of Harmony",
                AreasOfConcern = "Foresight, forgiveness, and peace.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("e01a56d1-0b45-4f16-a1e9-189b4617f57e"), Type = TextBlockType.Text, Text = "Korada, the Open Hand of Harmony, is concerned with foresight, forgiveness, and peace. In particular, he believes that although the tireless fight against wickedness is admirable, the ultimate triumph over evil will come in the form of redemption rather than destruction. Korada's dedication to peace is such that he and his followers refuse to cause harm to their attackers, instead using their martial skills only to defend themselves. Many Koradans seek greater wisdom through study or meditation in hopes of better understanding their foes so as to guide them toward redemption. This dedication to self-awareness, philosophy, and introspection is said to have allowed Korada greater insight into the workings of the universe, granting him the great gift of foresight. Korada rarely acts on his visions, however, believing the struggle that comes with true change is always worthwhile, whether or not such a change is successful." };
            yield return new TextBlock { Id = Guid.Parse("fc9b1e53-d33c-4f2d-98a0-6907f6f30e74"), Type = TextBlockType.Text, Text = "The Open Hand of Harmony takes the form of a lithe, athletic man donning simple robes. He is covered in sparse, light-brown fur and has three monkey tails that constantly writhe behind him, much like the dancing flames of a powerful fire. Most of Korada's followers are those who have lived imbalanced lives or faced persistent violence as they seek to find peace in their life and within themselves. Many of the evil individuals redeemed by Koradans soon become followers themselves." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("dff27cb2-9f43-4793-aace-c24195324449"), Spells.Instances.Soothe.ID);
            builder.GainSpecificSpell(Guid.Parse("7752b006-2bae-46b9-8048-4709027dd976"), Spells.Instances.Slow.ID);
            builder.GainSpecificSpell(Guid.Parse("8870ba33-cf21-482b-b9e2-5ce491d4c738"), Spells.Instances.ResilientSphere.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Fist.ID;
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
            yield return Skills.Instances.Diplomacy.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("74db0aec-7bbd-4428-85d4-bfcf862cd0e3"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
