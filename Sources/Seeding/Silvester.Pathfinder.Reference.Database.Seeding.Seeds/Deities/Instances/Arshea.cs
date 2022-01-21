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
    public class Arshea : Template
    {
        public static readonly Guid ID = Guid.Parse("900a7574-15d2-48aa-a277-94efd6db2285");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Arshea",
                Edicts = "Inspire passion, comfort and free the repressed, seek your true self and desires.",
                Anathema = "Judge another based on sexual desires or gender roles, harm another in pursuit of passion.",
                Title = "Spirit of Abandon",
                AreasOfConcern = "Freedom, physical beauty, and sexuality.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("212cf146-b0aa-4f66-b994-820b1ab5c000"), Type = TextBlockType.Text, Text = "Appearing in art more than any of the other empyreal lords, the Spirit of Abandon represents freedom, physical beauty, and sexuality. More than anything else, freedom is what matters to Arshea. For many this is most commonly seen as freedom for sexual expression, but Arshea represents the freedom to experience all that is good in the world, be it an ideology or a specific emotional or physical expression. So long as it doesn't harm others, Arshea believes creatures should do, think, and feel as they will. They encourage their followers to try new things, to think in new ways, and to wear new forms." };
            yield return new TextBlock { Id = Guid.Parse("55ac2e10-a7d5-4e5a-9ab3-94d00504ecfe"), Type = TextBlockType.Text, Text = "When appearing to mortals, the Spirit of Abandon most commonly appears in that person's own body so the person may see how beautiful and perfect their own form is—after all, if a divine being has chosen to wear it, it must be perfect. For people who don't fit in the body they currently wear, Arshea often appears in the form reflected in their heart and soul. Followers of Arshea are a varied lot, from artists to explorers, and from lovers to those who fight against repression." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("5291e667-ab18-45d8-89af-67dc43464014"), Spells.Instances.MageArmor.ID);
            builder.GainSpecificSpell(Guid.Parse("22bfe7c4-8855-482d-8df2-ad29f33a3779"), Spells.Instances.HumanoidForm.ID);
            builder.GainSpecificSpell(Guid.Parse("a8e51de2-f25e-453b-877d-d53626251bd6"), Spells.Instances.DreamingPotential.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Flail.ID;
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
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Confidence.ID;
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Passion.ID;
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
                Id = Guid.Parse("a9e336cb-7d35-4640-9640-5dc9523e7bd0"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
