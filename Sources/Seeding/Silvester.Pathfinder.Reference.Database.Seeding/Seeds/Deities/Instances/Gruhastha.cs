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
        public static readonly Guid ID = Guid.Parse("687bf74d-5ca7-4230-8e8b-01d40d58cf1e");

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
            
            yield return new TextBlock { Id = Guid.Parse("ca332e06-6948-4c35-8209-5b60a5be6dc4"), Type = TextBlockType.Text, Text = "Gruhastha the Keeper is a deity of understanding, peace, and the collective pursuit of enlightenment. The once-mortal nephew ofIroriis believed to have ascended to godhood himself after creating the holy bookAzvadeva Pujila, fully embodying all divine wisdom within the text. Originating in Vudra, the Keeper's faith has slowly gained popularity in the Inner Sea region, particularly in Jalmeray, where Irori already has a wide following. Gruhastha manifests as a human man with an idealized form, augmented with wings of red and green plumage and a golden mandala as a halo." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("b2d2689b-3050-4ac1-86a9-7fb9b013fc4e"), Spells.Instances.ShareLore.ID);
            builder.GainSpecificSpell(Guid.Parse("19f61db9-8fcd-41b1-bbc7-47a9fa03fb1c"), Spells.Instances.ComprehendLanguage.ID);
            builder.GainSpecificSpell(Guid.Parse("cbca25fb-d1a4-4632-a2e3-58cbf2a28ae0"), Spells.Instances.Hypercognition.ID);
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
                Id = Guid.Parse("0fcd1a6c-2774-470e-a2cc-42a539a1702b"),
                Description = "The Keeper encourages the search for knowledge and rewards those that travel their personal path of enlightenment, but he punishes those who interrupt these journeys or destroy knowledge.",
                MinorBoon = "Books fall open to insightful passages, and memories spring to mind when they are most needed. Once, when you fail a check to Recall Knowledge, you critically succeed instead. Gruhastha typically grants this boon for an extremely consequential attempt to Recall Knowledge, particularly when misinformation would have dire consequences.",
                ModerateBoon = "The Keeper speeds your path toward learning new talents. You become permanently trained in two additional skills of your choice. Additionally, you can select a skill you are already trained in and permanently increase your proficiency rank in that skill, following the usual rules for skill increases.",
                MajorBoon = "You are a divine inspiration to others around you. When attempting any checks to Recall Knowledge, you can roll twice and use the better result; this is a fortune effect. Additionally, allies within 60 feet gain a +2 status bonus to Will saves.",
                MinorCurse = "As you stray from the truth, dissonant notes seem to interrupt you whenever you speak. You take a –2 status penalty to all Deception checks.",
                ModerateCurse = "Enlightenment begins to elude you, leaving you at a loss for knowledge. Whenever you attempt a check to Recall Knowledge, you use a result one degree of success worse than the result you rolled.",
                MajorCurse = "The written word turns against you, blurring into illegibility. You are incapable of reading anything or making out symbols of any sort, including the words on scrolls, spellbooks, or magic items.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("43dbaf46-f1b5-437f-ada0-896727edfaf2"),
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
                Id = Guid.Parse("28db8e26-a734-482b-896d-af977cb89aeb"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 62
            };
        }
    }
}
