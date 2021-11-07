using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StudentOfTheStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("ac7b56c6-6fb2-417e-b966-4efdd3659f43");

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
            yield return new TextBlock { Id = Guid.Parse("8af2fd82-fa3a-402c-ad7d-18916a1bfcbf"), Type = TextBlockType.Text, Text = "You’ve studied the staff extensively to learn the hidden capabilities of your chosen weapon. When you critically succeed at an attack roll using a staff, you apply the critical specialization effect of the club group. While you’re in (feat: Arcane Cascade) stance, your staff gains the (trait: deadly d6) trait, with the damage from the deadly die being the same damage type as the extra damage from (feat: Arcane Cascade)." };
            yield return new TextBlock { Id = Guid.Parse("318b7ff0-96a1-4c50-b09b-9f6d2b9c4a93"), Type = TextBlockType.Text, Text = "In addition, you can place property runes into a magic staff you prepare, even though a magic staff can’t typically hold property runes. You must first inscribe the property runes into your (item: spellbook), using the same process as transferring a rune (Core Rulebook 580). The rune takes the form of a specialized diagram in your (item: spellbook), occupying one page. You can’t inscribe runes that can’t be placed on a non-magical staff, nor can you inscribe the (item: shifting | Shifting Runestone) rune. When you prepare a staff, you can impart any number of property runes from your (item: spellbook) into the staff, up to the limit imposed by the staff’s weapon potency rune." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("970bb252-f242-42fb-9118-75515adc2e9e"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("99a22d5e-c54a-4ef6-aec3-2165658e0237"), HybridStudies.Instances.TwistingTree.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75318f95-36c7-442b-ad5c-f31494f9a16e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
