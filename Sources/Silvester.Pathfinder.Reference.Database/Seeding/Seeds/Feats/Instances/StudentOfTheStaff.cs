using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StudentOfTheStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("7106e6eb-69fb-4299-8aee-9919c8f48b5f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Student of the Staff",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70b2359e-4942-416b-97b0-0da16adfad6c"), Type = TextBlockType.Text, Text = "You’ve studied the staff extensively to learn the hidden capabilities of your chosen weapon. When you critically succeed at an attack roll using a staff, you apply the critical specialization effect of the club group. While you’re in (feat: Arcane Cascade) stance, your staff gains the (trait: deadly d6) trait, with the damage from the deadly die being the same damage type as the extra damage from (feat: Arcane Cascade)." };
            yield return new TextBlock { Id = Guid.Parse("76778368-4d77-4aef-8cd3-b9240237b1e3"), Type = TextBlockType.Text, Text = "In addition, you can place property runes into a magic staff you prepare, even though a magic staff can’t typically hold property runes. You must first inscribe the property runes into your (item: spellbook), using the same process as transferring a rune (Core Rulebook 580). The rune takes the form of a specialized diagram in your (item: spellbook), occupying one page. You can’t inscribe runes that can’t be placed on a non-magical staff, nor can you inscribe the (item: shifting | Shifting Runestone) rune. When you prepare a staff, you can impart any number of property runes from your (item: spellbook) into the staff, up to the limit imposed by the staff’s weapon potency rune." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f627c183-1938-4eef-bbd6-62e2c8c68830"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("9f22ab88-d092-4eb7-87e9-d86532f8ccbf"), HybridStudies.Instances.TwistingTree.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b89f0b77-e0aa-4076-b926-15bfbcd34cab"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
