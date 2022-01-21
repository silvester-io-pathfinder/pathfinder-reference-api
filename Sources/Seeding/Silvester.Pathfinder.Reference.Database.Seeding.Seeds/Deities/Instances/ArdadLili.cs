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
    public class ArdadLili : Template
    {
        public static readonly Guid ID = Guid.Parse("b521d6cc-9feb-4581-9658-19d52ac243c5");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.QueensOfTheNight.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Ardad Lili",
                Edicts = "Manipulate others with false promises, aid women who have been unfairly maligned.",
                Anathema = "Give someone more than you receive from them, allow yourself to be swayed by lust.",
                Title = "The End of Innocence",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("e1b92894-1250-4538-980d-38b74dede61d"), Type = TextBlockType.Text, Text = "When mortals were young, before Asmodeus conquered Hell, Ardad Lili was already manipulating amorous and lustful mortals to swear fealty to her, amassing power from their souls. She fled the realm of Nirvana during the Exodus, taking up residence in Avernus and continuing to gather an army of damned souls and female devils who share her ambitions. The Serpent Muse has never forgotten the censures and cruel insults spewed by the other natives of Nirvana, and she seeks to someday rule not a layer of Hell, but a realm of the heavens. Herself a passionate being, she draws similarly passionate followers." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("ab8b6f30-540a-4d28-adab-c73b49de6d4d"), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse("567c1865-ea27-4ae7-aa3f-d53373e65240"), Spells.Instances.Enthrall.ID);
            builder.GainSpecificSpell(Guid.Parse("c19ed85e-a84c-4330-8170-4563d3eccd8a"), Spells.Instances.Suggestion.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Dagger.ID;
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
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Darkness.ID;
            yield return Domains.Instances.Passion.ID;
            yield return Domains.Instances.Wyrmkin.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("161c01bc-2d84-4e6b-aff7-8770d3d87b73"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 132
            };
        }
    }
}
