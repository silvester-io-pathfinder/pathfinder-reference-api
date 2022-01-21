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
    public class CountRanalc : Template
    {
        public static readonly Guid ID = Guid.Parse("b3a208d5-cdfb-4bcf-9489-b7ca0a9a3224");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Eldest.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "Count Ranalc",
                Edicts = "Work in shadows, hide your nature and motives, plot betrayals or revenge for betrayals.",
                Anathema = "Ask for forgiveness, create permanent or long-lasting sources of light.",
                Title = "The Traitor",
                AreasOfConcern = "Exiles, shadows, betrayal, and the betrayed.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("22d282fe-216a-4664-aaae-a0c19d197eaf"), Type = TextBlockType.Text, Text = "Once the lord of darkness and of the chaos of creation, Count Ranalc was cast out long ago by the other Eldest and titled “the Traitor,” though the Eldest are not forthcoming about what heinous treachery Ranalc committed, and many among his worshippers claim that he was the one who was betrayed. In his new home in a remote corner of the Shadow Plane, Ranalc embraced his banishment and became the patron of exiles, shadows, betrayal, and the betrayed. Ranalc had long held a fascination with the world of Golarion, and he was alternately both friend and foil to the powerful archwizard Nex. On the day Nex besieged the city of Absalom with shadowy beings—beings certainly drawn from Ranalc's domain—the Eldest vanished from reality. Although he continues to grant spells to his devout worshippers, Ranalc has otherwise wholly disappeared. Theories about his disappearance abound, although they are as obscure and as self-contradictory as the enigmatic Eldest ever was." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("197c7421-064c-4535-92dd-04bc0765a005"), Spells.Instances.PenumbralShroud.ID);
            builder.GainSpecificSpell(Guid.Parse("bede9b6f-58ce-4c51-b11c-eb9be1788ae5"), Spells.Instances.PrivateSanctum.ID);
            builder.GainSpecificSpell(Guid.Parse("acdd3788-66e3-4008-8742-4ee951be55d4"), Spells.Instances.ShadowWalk.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Rapier.ID;
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
            yield return Skills.Instances.Stealth.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Confidence.ID;
            yield return Domains.Instances.Darkness.ID;
            yield return Domains.Instances.Sorrow.ID;
            yield return Domains.Instances.Travel.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a9a1e83-0bd0-4bd9-8a12-a42f9405ee30"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
