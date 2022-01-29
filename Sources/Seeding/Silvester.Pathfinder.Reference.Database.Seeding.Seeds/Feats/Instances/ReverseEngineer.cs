using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReverseEngineer : Template
    {
        public static readonly Guid ID = Guid.Parse("501f77aa-4973-4880-8f0f-6674d408598a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reverse Engineer",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("19124f9f-d206-4cca-8611-671f798a3c02"), Type = TextBlockType.Text, Text = $"You are incredibly skilled at reverse engineering items to learn their formulas, or disassembling them just to disable them. You gain a +2 circumstance bonus to Crafting checks to reverse engineer a formula from an item. If you get a critical success on your Crafting check, you can opt to both create the formula and reassemble the original item at the same time, leaving you with the formula and the item instead of the formula and raw materials equal to half the item's value. Furthermore, you can use Crafting instead of Thievery to {ToMarkdownLink<Models.Entities.SkillAction>("Disable a Device", SkillActions.Instances.DisableADevice.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Pick a Lock", SkillActions.Instances.PickALock.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0e7e9baf-7a4a-43eb-92d5-bb7edd88e957"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Inventor.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6448a4cc-b04c-4ac3-9b2e-453ca7f31bab"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
