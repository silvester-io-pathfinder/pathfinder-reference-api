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
        public static readonly Guid ID = Guid.Parse("");

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
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Korada, the Open Hand of Harmony, is concerned with foresight, forgiveness, and peace. In particular, he believes that although the tireless fight against wickedness is admirable, the ultimate triumph over evil will come in the form of redemption rather than destruction. Korada's dedication to peace is such that he and his followers refuse to cause harm to their attackers, instead using their martial skills only to defend themselves. Many Koradans seek greater wisdom through study or meditation in hopes of better understanding their foes so as to guide them toward redemption. This dedication to self-awareness, philosophy, and introspection is said to have allowed Korada greater insight into the workings of the universe, granting him the great gift of foresight. Korada rarely acts on his visions, however, believing the struggle that comes with true change is always worthwhile, whether or not such a change is successful." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The Open Hand of Harmony takes the form of a lithe, athletic man donning simple robes. He is covered in sparse, light-brown fur and has three monkey tails that constantly writhe behind him, much like the dancing flames of a powerful fire. Most of Korada's followers are those who have lived imbalanced lives or faced persistent violence as they seek to find peace in their life and within themselves. Many of the evil individuals redeemed by Koradans soon become followers themselves." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Soothe.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Slow.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ResilientSphere.ID);
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
