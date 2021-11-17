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
    public class Zura : Template
    {
        public static readonly Guid ID = Guid.Parse("359f7f36-605b-4b3a-9692-72a30ac5c469");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DemonLords.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Zura",
                Edicts = "Drink blood, seek vampirism, cause bleed damage.",
                Anathema = "Expose vampires, heal a bloody wound without drinking blood from it first.",
                Title = "The Vampire Queen",
                AreasOfConcern = "Blood, cannibalism, and vampires.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("7657c957-e702-4a73-bc84-3c885f93db52"), Type = TextBlockType.Text, Text = "Zura, the Vampire Queen, is the demon lord of blood, cannibalism, and vampires. According to legend, she is the reincarnated form of an Azlanti queen who indulged in blood rites and acts of cannibalism in a quest for eternal life. After death, she was reborn as a unique vampiric succubus who quickly ascended to the status of demon lord. Though many of her cults died out with the Azlanti empire, Zura is still worshipped by vampires and those aspiring to become vampires, particularly within Cheliax and Ustalav, as well as among the drow of the Darklands." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("9b2f0ccc-8fe1-487c-a287-38c2659bc72e"), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse("e5400908-baac-4624-ac40-1b4814d34efb"), Spells.Instances.GaseousForm.ID);
            builder.GainSpecificSpell(Guid.Parse("3b5515d3-8149-4a41-861c-1f71243a6c59"), Spells.Instances.Dominate.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Rapier.ID;
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
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Delirium.ID;
            yield return Domains.Instances.Indulgence.ID;
            yield return Domains.Instances.Nightmares.ID;
            yield return Domains.Instances.Undeath.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("87f9caea-a198-4450-a2a4-33b42555293d"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
