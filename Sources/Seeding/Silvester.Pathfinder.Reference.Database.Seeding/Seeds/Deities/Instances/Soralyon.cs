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
    public class Soralyon : Template
    {
        public static readonly Guid ID = Guid.Parse("6f1fd592-c395-41a6-8013-e36b442f414c");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Soralyon",
                Edicts = "Study monuments, craft golems and artwork from stone, guard ancient sites.",
                Anathema = "Defile sacred buildings, knowingly unearth evil monuments, destroy historical artifacts.",
                Title = "The Mystic Angel",
                AreasOfConcern = "Guardians, monuments, and magic.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("b7758b92-febd-4c9f-bcac-8a4a3832f161"), Type = TextBlockType.Text, Text = "Guardians, monuments, and magic are the purview of the Mystic Angel. Soralyon believes that monuments and ruins are important links to the past. Guarding them against those who would defile or destroy them is of tremendous importance, lest people lose memories of who they are, where they came from, and what they have accomplished. As such, those who stand guard over monuments and ruins are blessed. Likewise, those who study monuments to the past and present with respect, or seek to preserve them for the future, are also blessed. Guardianship of others, but especially of those who study and preserve these relics to the past, is also of great importance to Soralyon. As magic is a valuable tool in guarding, studying, and preserving these monuments and people, Soralyon encourages the study of magic, preferably for use in learning or protection." };
            yield return new TextBlock { Id = Guid.Parse("cc0f3abc-5e68-45bf-8cf9-e3cdb08215f5"), Type = TextBlockType.Text, Text = "When the Mystic Angel appears to mortals he usually does so as a handsome being beautifully carved of smooth marble, the hues of which range the entire spectrum of the stone but tend toward those most common locally. Followers of Soralyon include archaeologists, historians, bodyguards, guardians, sculptors, curators, and arcane spellcasters." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("ac0d8476-6c60-4064-9e40-9765e8944542"), Spells.Instances.SummonConstruct.ID);
            builder.GainSpecificSpell(Guid.Parse("da798ec8-307d-4ee4-8387-dd8ee67fdc81"), Spells.Instances.MeldIntoStone.ID);
            builder.GainSpecificSpell(Guid.Parse("a55f11cf-490f-4216-ad12-ba97898632d1"), Spells.Instances.Stoneskin.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Pick.ID;
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
            yield return Skills.Instances.Arcana.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Earth.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("e784c810-5dc9-47e8-b428-e10d1ad96d28"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
