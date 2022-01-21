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
    public class Dranngvit : Template
    {
        public static readonly Guid ID = Guid.Parse("51513ec7-9816-4ee2-a1bd-494826d77de5");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DwarvenGods.ID,
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                Name = "Dranngvit",
                Edicts = "Help reclaim just debts, seek appropriate vengeance against transgressions.",
                Anathema = "Allow a slight to go unrecognized, avoid repaying a debt, force others into debts you know are unpayable.",
                Title = "The Debt Minder",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("257ba9ab-051f-472d-a853-f2f78271b15e"), Spells.Instances.Longstrider.ID);
            builder.GainSpecificSpell(Guid.Parse("72375755-6a94-4b0d-8c92-e899fccc357b"), Spells.Instances.Knock.ID);
            builder.GainSpecificSpell(Guid.Parse("c3dfcd36-040a-47ad-8577-60be52c5bcf6"), Spells.Instances.Passwall.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.LightPick.ID;
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
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Travel.ID;
            yield return Domains.Instances.Vigil.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("9494e888-79a0-4418-988d-e43aee8f9528"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
