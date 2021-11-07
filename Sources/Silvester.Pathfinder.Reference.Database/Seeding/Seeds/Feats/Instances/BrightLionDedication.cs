using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrightLionDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("1df78710-3ba8-46e6-aa00-5ecc62cef77b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bright Lion Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the Bright Lion archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("569eee13-bb7f-4e3b-bcd7-8545041d002f"), Type = TextBlockType.Text, Text = "~ Access: Bright Lion background" };
            yield return new TextBlock { Id = Guid.Parse("25edd4fa-c768-404f-acd1-6e76fbb8c6f6"), Type = TextBlockType.Text, Text = "You become trained in your choice of Deception or Diplomacy and in Mzali Lore; if you were already trained, you become an expert instead. You incorporate enough worship of Walkena in your daily life to avoid suspicion. You typically don’t need to (action: Lie) or (action: Impersonate) to pass yourself off as a worshipper of Walkena. Against careful inspection, you gain a +4 circumstance bonus to Deception checks specifically to pass yourself off as a version of yourself faithful to Walkena." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("65d1dc6b-19ab-4802-bb33-d20bcfe617bc"), "Member of the Bright Lions.");
            builder.WorshipSpecificDeity(Guid.Parse("6b236c18-20a6-4b7b-9f8b-d6fe9e0086a9"), Deities.Instances.Walkena.ID, isNegated: true);
            builder.HaveSpecificSkillProficiency(Guid.Parse("bc3ee3b8-afcf-4857-ac36-ddbc71784d78"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc2de4f2-44bf-4a0f-837c-1883fdb727b9"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
