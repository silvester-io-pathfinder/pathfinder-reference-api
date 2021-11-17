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
    public class Mazludeh : Template
    {
        public static readonly Guid ID = Guid.Parse("593f5677-11b5-4a87-8ad5-9253358eebbf");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Mazludeh",
                Edicts = "Seek to improve yourself and your community, trust those you work with, encourage cooperation.",
                Anathema = "Betray another's trust, place conflict between ideological differences over people's lives.",
                Title = "Mother of Hearth and Wall",
                AreasOfConcern = "Balance, community, negotiation, and twilight.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("13ab7d89-08b8-4cff-a975-7748f83e8aae"), Type = TextBlockType.Text, Text = "Mazludeh was once one among manyempyreal lords, responsible for the domains of community stewardship and loving sacrifice. However, her actions during Earthfall and the Age of Darkness saved untold lives in Mwangi. Dismayed by the chaos and loss of life, Mazludeh spurred her fellow empyreal lords into action, forming a divine concordance that protected the Garundi nation of Holomog from devastation. Mazludeh's efforts elevated her to true divinity and the status of the matron goddess of the nation of Holomog. Now the goddess of negotiations and treaties, her followers often travel with merchants and ambassadors. She is also considered the diplomat to the other empyreal lords, able to pass on prayers to those most suited to answer them and persuade celestial beings to see to their fulfillment. Throughout the Mwangi, worshippers of Mazludeh have developed a reputation for being brave, empathetic, and fair even to their enemies." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("fcc3c6e1-48ce-4c8c-abe8-5abc050ad750"), Spells.Instances.ShareLore.ID);
            builder.GainSpecificSpell(Guid.Parse("c6031014-99e6-4b01-9284-3a7ac98bdf49"), Spells.Instances.ShapeStone.ID);
            builder.GainSpecificSpell(Guid.Parse("23cda454-cf2f-47d9-8f1c-475d3377c4f2"), Spells.Instances.WallOfStone.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.ShieldBoss.ID;
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
            yield return Domains.Instances.Cities.ID;
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Perfection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("0cc9f85c-607f-4aa2-aeb7-097de0e3e822"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 140
            };
        }
    }
}
