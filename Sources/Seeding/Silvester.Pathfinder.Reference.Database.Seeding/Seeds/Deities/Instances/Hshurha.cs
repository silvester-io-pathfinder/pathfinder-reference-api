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
    public class Hshurha : Template
    {
        public static readonly Guid ID = Guid.Parse("c29182bf-334b-4b2f-8e2f-990f0fc86f51");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.ElementalLords.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Hshurha",
                Edicts = "Revel in formlessness and freedom, humiliate terrestrial creatures, kill foes via falling or hazards from high winds.",
                Anathema = "Deny a flying creature the ability to fly, walk on the earth if you could easily travel otherwise.",
                Title = "Duchess of All Winds",
                AreasOfConcern = "Air, last breaths, and windstorms.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("4c590f47-934f-4310-b112-93478a80f934"), Type = TextBlockType.Text, Text = "Hshurha, Duchess of All Winds, is the elemental lord of air, last breaths, and windstorms. She rules thePlane of Airfrom her translucent palace, Verglas Precessional, surrounded by her court of air elementals, planar dignitaries, and favored guests. The Duchess is naturally invisible, and her true form—if she even has such a thing—is a mystery. Cruel and tyrannical, Hshurha enjoys toying with outsiders in her realm, and she is known to be especially vicious toward creatures with solid forms. She creates and destroys magnificent ice and dust sculptures according to her tumultuous whims, and her machinations often seem convoluted and nonsensical, even to her inner circle. Most on the plane both respect and fear her." };
            yield return new TextBlock { Id = Guid.Parse("87b3bb5b-e61e-4335-913c-77a0f01948fd"), Type = TextBlockType.Text, Text = "The lord of air is worshipped byair elementalsas a mother goddess, byinvisible stalkers, and by cultists who enjoy catering to capricious whims and unpredictable storms. Despite her cool peace with djinn, some believe she consorts withefreetor uses her invisible stalkers to weaken the djinn's hold on her plane." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("36700e93-73dd-4a7a-80c1-4e1ef9f69d84"), Spells.Instances.GustOfWind.ID);
            builder.GainSpecificSpell(Guid.Parse("852d96e5-be5a-4c87-9c05-1b89c0b90827"), Spells.Instances.SummonElemental.ID);
            builder.GainSpecificSpell(Guid.Parse("5be32b81-ff32-4082-a7f5-2f4b4ed694c3"), Spells.Instances.GaseousForm.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            
            yield return RangedWeapons.Instances.Longbow.ID;
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
            yield return Skills.Instances.Stealth.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Dexterity.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Air.ID;
            yield return Domains.Instances.Cold.ID;
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Dust.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("040143d1-56e7-4cf5-8bd0-937c19ed70f9"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
