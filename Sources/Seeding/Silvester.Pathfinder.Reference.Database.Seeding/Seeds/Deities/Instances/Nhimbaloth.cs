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
    public class Nhimbaloth : Template
    {
        public static readonly Guid ID = Guid.Parse("7b03f25f-7592-4d3b-942e-0f29dc73101b");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OuterGodsAndGreatOldOnes.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Nhimbaloth",
                Edicts = "Create.",
                Anathema = "None.",
                Title = "The Empty Death",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("6242d5be-1da7-48b0-955f-8c5431a04777"), Type = TextBlockType.Text, Text = ",Gods & Magic pg. 130" };
            yield return new TextBlock { Id = Guid.Parse("558c0096-94bb-4f03-8760-33887ba8fa79"), Type = TextBlockType.Text, Text = "An especially reclusive Outer God who hunts along the shores of the River of Souls, Nhimbaloth is a shapeless entity known as the Empty Death. She preys on those who hunt souls as they travel down the river, but she devours both hunter and soul indiscriminately; those she consumes have no afterlife or potential for resurrection. They are forever gone, and forever nothing." };
            yield return new TextBlock { Id = Guid.Parse("74a30a62-dfd8-4b10-beed-9fb95cc53593"), Type = TextBlockType.Text, Text = "Nhimbaloth is said to see through will-o'-wisps, and her trace is left behind in a symmetrical pattern of seven divots along the shoreline, said to be her fingerprints. Faceless undead haunt the places where she has passed, and plant and animal life in the area is especially hostile to the living. One place where she has particular influence is within the Mushfens of southern Varisia, where will-o'-wisp oracles sap the drive and reason from their victims and leave them wandering in a vacuous stupor through the blasted swamp." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("59d37a5a-1037-4aab-915a-411642bea250"), Spells.Instances.GrimTendrils.ID);
            builder.GainSpecificSpell(Guid.Parse("98dcea09-231e-4d41-a4e0-bf56e87269e7"), Spells.Instances.Entangle.ID);
            builder.GainSpecificSpell(Guid.Parse("7987cbc6-4b40-482c-aa53-7098bd5eee59"), Spells.Instances.Cloudkill.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Flail.ID;
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
            yield return Skills.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Decay.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Undeath.ID;
            yield return Domains.Instances.Void.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("5cb45731-8049-407f-8e6b-2745fe2b968a"),
                SourceId = Sources.Instances.Pathfinder165.ID,
                Page = 65
            };
        }
    }
}
