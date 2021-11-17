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
    public class CosmicCaravan : Template
    {
        public static readonly Guid ID = Guid.Parse("99b886b5-1518-4588-b551-3235681e4036");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Pantheons.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "Cosmic Caravan",
                Edicts = "Spend time stargazing or meditating in moonlight, aid those who live in regions where Zon-Kuthon (or other religions that espouse the night as a bastion for evil) hold sway, help the desperate or forlorn to see potential for a better life in the future, travel with no particular destination in mind.",
                Anathema = "Portray the night as a time of evil, destroy astronomical or astrological equipment, spend the night in the same place twice in a row.",
                
                AreasOfConcern = "Constellations, fortune telling, the night, hope for a better tomorrow.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("93ec83c9-1ed6-4d00-b62b-5f342cee4e35"), Type = TextBlockType.Text, Text = "The Cosmic Caravan is known to astronomers and astrologers alike as a collection of constellations in the sky, said to travel forever in a circle around the star Cynosure. The association of a diverse array of gods and demigods thematically linked with the stars and the spaces between is a relatively new faith that first rose to prominence in western Avistan, particularly in Varisia, Nidal, and Ravounel. The deities worshiped by the faithful of the Cosmic Caravan include:Desna,Groetus, andSarenrae; the empyreal lordsAshava,Black Butterfly, andPulura; the elven godKetephys; and the outer godYog-Sothoth. This faith has been gaining ground particularly in Nidal, where the worship of the night is overwhelmingly associated withZon-Kuthon, and a rising number of Cosmic Caravan worshipers seek to oppose or, one day, even overthrow the Midnight Lord's theocracy to reclaim the night from the implications that all who dwell in the dark are evil." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("41403824-b5fe-4bb9-8bbd-84a17a08cfd5"), Spells.Instances.ObjectReading.ID);
            builder.GainSpecificSpell(Guid.Parse("55945a7b-9d1c-4a3b-8a6d-0967730fb384"), Spells.Instances.Glitterdust.ID);
            builder.GainSpecificSpell(Guid.Parse("1d47f278-2aeb-4e88-a2e3-a398bde2fff3"), Spells.Instances.BlanketOfStars.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
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
            yield return Skills.Instances.Occultism.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Darkness.ID;
            yield return Domains.Instances.Fate.ID;
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Moon.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("ffde6590-a1fa-4faa-91ba-91c64d783dd1"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = 5
            };
        }
    }
}
