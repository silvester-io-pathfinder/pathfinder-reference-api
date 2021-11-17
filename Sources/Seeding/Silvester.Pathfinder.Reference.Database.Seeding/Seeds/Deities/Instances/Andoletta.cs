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
    public class Andoletta : Template
    {
        public static readonly Guid ID = Guid.Parse("2936778a-2777-4844-95d1-4a598bfe5256");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Andoletta",
                Edicts = "Respect elders, instill good virtues in children, seek and allow redemption.",
                Anathema = "Hold a grudge, mock the dead, pass judgment hastily or carelessly.",
                Title = "Grandmother Crow",
                AreasOfConcern = "Consolation, respect, and security.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("0838f088-c54d-4cb4-9665-7bf1f06f52a5"), Type = TextBlockType.Text, Text = "Called Grandmother Crow, Andoletta represents consolation, respect, and security. Andoletta makes a clear distinction between guilt and innocence: there is no in-between. For those falsely accused or who show signs of redemption, she offers a path back to the light. That path is never an easy one, but it is one worth walking, and she stands beside those who make the trek. For the truly wicked and those who show no remorse, she has no mercy. For these reasons, her likeness is often found in courts, where she can watch over and ensure fairness to those accused of crimes. Andoletta also places great value on respect for the dead and the protection of children. To offer solace to the bereaved is true kindness and compassion. Children are slates with tremendous potential for good—if they can be guided and kept safe from evil." };
            yield return new TextBlock { Id = Guid.Parse("3e718be1-e99b-4f82-ad10-f3b6dfb7b9c1"), Type = TextBlockType.Text, Text = "When she appears to mortals, Grandmother Crow does so as an older woman, gray-haired, wrinkled, and with keen, knowing eyes. She carries a walking stick and wears a cape of black crow feathers across her shoulders, giving the appearance of large, folded wings. Those who appeal to Andoletta include elders, the conflicted, the bereaved, the falsely accused, investigators, and judges." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("a769cb51-5eee-4926-bf1b-accf9efd8f4b"), Spells.Instances.Shillelagh.ID);
            builder.GainSpecificSpell(Guid.Parse("bf5846d9-41bd-404d-ae06-35edf248c1a6"), Spells.Instances.AerialForm.ID);
            builder.GainSpecificSpell(Guid.Parse("ed812730-72ca-4990-a621-bb1602588c2d"), Spells.Instances.CollectiveTransposition.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Staff.ID;
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
            yield return Skills.Instances.Society.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Protection.ID;
            yield return Domains.Instances.Sorrow.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("b57ae822-82cd-4a4f-8eec-aedce37f27e8"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}