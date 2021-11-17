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
    public class Ragathiel : Template
    {
        public static readonly Guid ID = Guid.Parse("10ec0a6a-5105-4d7b-9364-522f9ef7711d");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Ragathiel",
                Edicts = "Avenge the wronged, destroy evildoers, lead the charge in battle.",
                Anathema = "Cower from combat, forgive those who have irreparably sinned, leave allies unwillingly in darkness.",
                Title = "General of Vengeance",
                AreasOfConcern = "Chivalry, duty, and vengeance.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("2113542d-a37d-49c9-8985-89e80400d11b"), Type = TextBlockType.Text, Text = "The General of Vengeance presides over chivalry, duty, and vengeance, acting as the quintessential knight. Born of the archdevil Dispater and Feronia, a neutral demigoddess of fire, Ragathiel struggles to overcome the reputation of his parentage, and he understands the struggle to be accepted, to be trusted, and to fight against his own nature for the sake of good. He represents strength in battle, wrath upon the wicked, absolution or vengeance for the wronged, leadership when needed, and virtue and duty to the innocent. He expects his followers to destroy fiends when they find them and to work toward truly earning the trust and acceptance of those around them. Those who follow him lead by shining example and can be found on the front lines of battle or any conflict against evil they can find." };
            yield return new TextBlock { Id = Guid.Parse("7b09d736-8326-4369-9387-d8df4e24416a"), Type = TextBlockType.Text, Text = "The General of Vengeance appears as a massive giant, standing more than 20 feet tall, clad in golden plate armor that shines with its own light and carrying a sword that burns with holy fire. Five flaming wings stretch from his back, three on his left and two on his right—the sixth was lost, torn out by his father in a fit of fury. Followers of Ragathiel include crusaders, knights, soldiers, the falsely accused, the marginalized, and the wronged." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("ef7508cb-f6fd-40d7-8644-e252aed0aa6d"), Spells.Instances.TrueStrike.ID);
            builder.GainSpecificSpell(Guid.Parse("24700ff9-bfb3-4af1-ad56-8614550d82c4"), Spells.Instances.Haste.ID);
            builder.GainSpecificSpell(Guid.Parse("6de530ce-e39d-40c5-b318-3d5e15c9c6ea"), Spells.Instances.FireShield.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.BastardSword.ID;
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
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Duty.ID;
            yield return Domains.Instances.Fire.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("94f18c05-c71f-4b2b-a2b2-410f7751b098"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}