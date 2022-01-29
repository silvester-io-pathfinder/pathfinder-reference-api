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
    public class ZephyrGuardDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("ff9da9a0-eeb5-4f9e-8bcc-8b7bb7d76005");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Zephyr Guard Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the Zephyr Guard archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c698b6be-7738-4213-bda1-0ee751bcbb09"), Type = TextBlockType.Text, Text = $"~ Access: You are from Katapesh." };
            yield return new TextBlock { Id = Guid.Parse("305e51b1-15da-4a7b-b46b-9b316184f9a6"), Type = TextBlockType.Text, Text = $"As a Zephyr Guard, you're always vigilant against crime and threats to the city's safety. You gain a +1 circumstance bonus to Perception checks against attempts to {ToMarkdownLink<Models.Entities.SkillAction>("Palm an Object", SkillActions.Instances.PalmAnObject.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Steal", SkillActions.Instances.Steal.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Conceal an Object", SkillActions.Instances.ConcealAnObject.ID)} (including if you're {ToMarkdownLink<Models.Entities.Action>("Seeking", Actions.Instances.Seek.ID)} concealed objects). You become trained in Society and Katapesh Lore; if you were already trained, you become an expert instead." };
            yield return new TextBlock { Id = Guid.Parse("68db6dc2-5095-4ee4-9119-54d42f49a613"), Type = TextBlockType.Text, Text = $"__(If you are already trained in Society or Katapesh Lore, override the proficiency on your character sheet.)__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("7f56e30a-4de1-4852-b4d3-5cab5ba488c0"), "Member of the Zephyr Guard");
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c11ab2f-d6f0-4d68-89f3-59e953823fb6"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
