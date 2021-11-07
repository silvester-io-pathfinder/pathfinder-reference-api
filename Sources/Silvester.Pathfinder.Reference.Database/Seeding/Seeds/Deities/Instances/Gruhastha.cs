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
    public class Gruhastha : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.VudraniGods.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Gruhastha",
                Edicts = "Work toward collective transcendence, expose and root out malicious lies, challenge oppression through education, protect knowledge, seek truth.",
                Anathema = "Deny a sincere student education, destroy knowledge, disrespect the traditions of those around you, willfully spread ignorance or wrong information.",
                Title = "The Keeper",
                AreasOfConcern = "Enlightenment, the Vudrani holy book.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Gruhastha the Keeper is a deity of understanding, peace, and the collective pursuit of enlightenment. The once-mortal nephew ofIroriis believed to have ascended to godhood himself after creating the holy bookAzvadeva Pujila, fully embodying all divine wisdom within the text. Originating in Vudra, the Keeper's faith has slowly gained popularity in the Inner Sea region, particularly in Jalmeray, where Irori already has a wide following. Gruhastha manifests as a human man with an idealized form, augmented with wings of red and green plumage and a golden mandala as a halo." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ShareLore.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ComprehendLanguage.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Hypercognition.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            
            yield return RangedWeapons.Instances.Shortbow.ID;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            
            return new DivineIntercession
            {
                Id = Guid.Parse(""),
                Description = "The Keeper encourages the search for knowledge and rewards those that travel their personal path of enlightenment, but he punishes those who interrupt these journeys or destroy knowledge.",
                MinorBoon = "Books fall open to insightful passages, and memories spring to mind when they are most needed. Once, when you fail a check to Recall Knowledge, you critically succeed instead. Gruhastha typically grants this boon for an extremely consequential attempt to Recall Knowledge, particularly when misinformation would have dire consequences.",
                ModerateBoon = "The Keeper speeds your path toward learning new talents. You become permanently trained in two additional skills of your choice. Additionally, you can select a skill you are already trained in and permanently increase your proficiency rank in that skill, following the usual rules for skill increases.",
                MajorBoon = "You are a divine inspiration to others around you. When attempting any checks to Recall Knowledge, you can roll twice and use the better result; this is a fortune effect. Additionally, allies within 60 feet gain a +2 status bonus to Will saves.",
                MinorCurse = "As you stray from the truth, dissonant notes seem to interrupt you whenever you speak. You take a –2 status penalty to all Deception checks.",
                ModerateCurse = "Enlightenment begins to elude you, leaving you at a loss for knowledge. Whenever you attempt a check to Recall Knowledge, you use a result one degree of success worse than the result you rolled.",
                MajorCurse = "The written word turns against you, blurring into illegibility. You are incapable of reading anything or making out symbols of any sort, including the words on scrolls, spellbooks, or magic items.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 6
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Society.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Glyph.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Perfection.ID;
            yield return Domains.Instances.Truth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 62
            };
        }
    }
}
